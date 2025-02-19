using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models; 

namespace AppRegistroMultas.Formulario
{
    public partial class FormCadastroMulta : Form
    {
        int cont = 1;
        int idVeiculo;
        static int idMulta = 1;

        public List<Veiculo> listaVeiculos = new List<Veiculo>();    
        public List<Multa> listaMultasTemp = new List<Multa>();

        public FormCadastroMulta()
        {
            InitializeComponent();
           VeiculoContext context = new VeiculoContext();
            listaVeiculos = context.ListarVeiculos();
            cbVeiculo.DataSource = listaVeiculos.ToList();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linhaSelec = cbVeiculo.SelectedIndex;
            if(linhaSelec>-1 && cont > 1)
            {
                var veiculo = listaVeiculos[linhaSelec]; 
                txtModelo.Text = veiculo.Modelo;
                txtMarca.Text = veiculo.Marca;
                txtPlaca.Text = veiculo.Placa;
                idVeiculo = veiculo.Id;
            }
            cont++; 
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Multa multa = new Multa();

            multa.Descricao = txtDescricao.Text;    
            multa.ValorMulta = Convert.ToDecimal(txtValor.Text);
            multa.Id = idMulta;
            multa.VeiculoId = idVeiculo;

            listaMultasTemp.Add(multa);

            idMulta++;

            //

            dtTabela.DataSource = listaMultasTemp.ToList();

            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear(); txtValor.Clear();
            txtMarca.Clear(); txtModelo.Clear();
            txtPlaca.Clear(); cbVeiculo.SelectedIndex = -1;
            listaMultasTemp.Clear();
            dtTabela.DataSource = listaMultasTemp.ToList();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MultaContext multaContext = new MultaContext();

            if (listaMultasTemp.Count == 0)
            {
                MessageBox.Show("NÃO HÁ MULTAS", "2°A INF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var multa in listaMultasTemp)
            {
                multaContext.InserirMulta(multa);
            }

            MessageBox.Show("MULTAS SALVAS COM SUCESSO", "2A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDescricao.Clear();
            txtValor.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            cbVeiculo.SelectedIndex = -1; 
            listaMultasTemp.Clear(); 
            dtTabela.DataSource = listaMultasTemp.ToList();
        }
    }
}
