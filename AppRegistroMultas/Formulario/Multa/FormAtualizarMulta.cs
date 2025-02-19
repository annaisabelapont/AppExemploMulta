using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;

namespace AppRegistroMultas.Formulario
{
    public partial class FormAtualizarMulta : Form
    {
        private List<Multa> listaMultas = new List<Multa>();

        public FormAtualizarMulta()
        {
            InitializeComponent();
            MultaContext context = new MultaContext();
            listaMultas = context.ListarMultas();

            cbVeiculo.DataSource = listaMultas.ToList();
            cbVeiculo.DisplayMember = "Descricao";
            cbVeiculo.ValueMember = "Id";
            cbVeiculo.SelectedIndex = -1;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (cbVeiculo.SelectedIndex > -1)
            {
                int idMultaSelecionada = (int)cbVeiculo.SelectedValue;
                var multaSelecionada = listaMultas.FirstOrDefault(m => m.Id == idMultaSelecionada);
                multaSelecionada.ValorMulta = Convert.ToDecimal(txtValor.Text);
                multaSelecionada.Descricao = txtDescricao.Text;

                MultaContext context = new MultaContext();
                context.AtualizarMulta(multaSelecionada);

                MessageBox.Show("ATUALIZADO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbVeiculo.SelectedIndex = -1;
                txtMarca.Clear();
                txtModelo.Clear();
                txtPlaca.Clear();
                txtDescricao.Clear();
                txtValor.Clear();
            }
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVeiculo.SelectedIndex > -1)
            {
                var multaSelecionada = listaMultas[cbVeiculo.SelectedIndex];

                txtDescricao.Text = multaSelecionada.Descricao;
                txtValor.Text = multaSelecionada.ValorMulta.ToString("N2");

                VeiculoContext veiculoContext = new VeiculoContext();
                var veiculo = veiculoContext.ListarVeiculos().FirstOrDefault(veic => veic.Id == multaSelecionada.VeiculoId);

                if (veiculo != null)
                {
                    txtModelo.Text = veiculo.Modelo;
                    txtMarca.Text = veiculo.Marca;
                    txtPlaca.Text = veiculo.Placa;
                }
                else
                {
                    txtModelo.Clear();
                    txtMarca.Clear();
                    txtPlaca.Clear();
                }
            }
            else
            {
                txtDescricao.Clear();
                txtValor.Clear();
                txtModelo.Clear();
                txtMarca.Clear();
                txtPlaca.Clear();
            }
        }
    }
}

