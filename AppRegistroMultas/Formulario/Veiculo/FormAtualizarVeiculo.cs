using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;

namespace AppRegistroMultas.Formulario
{
    public partial class FormAtualizarVeiculo : Form
    {
        List<Veiculo> ListaVeiculos = new List<Veiculo>();

        public FormAtualizarVeiculo()
        {
            InitializeComponent();
            VeiculoContext veiculo = new VeiculoContext();
            ListaVeiculos = veiculo.ListarVeiculos();

            comboBox1.DataSource = ListaVeiculos.ToList();
            comboBox1.DisplayMember = "Placa";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1)
            {
                var veiculosSelec = ListaVeiculos[linhaSelec];
                txtMarca.Text = veiculosSelec.Marca;
                txtModelo.Text = veiculosSelec.Modelo;
                txtPlaca.Text = veiculosSelec.Placa;
            }
            else
            {
                txtMarca.Clear(); txtModelo.Clear(); txtPlaca.Clear();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1)
            {
                var veiculosSelec = ListaVeiculos[linhaSelec];
                veiculosSelec.Marca = txtMarca.Text;
                veiculosSelec.Modelo = txtModelo.Text;
                veiculosSelec.Placa = txtPlaca.Text;

                VeiculoContext context = new VeiculoContext();
                context.AtualizarVeiculo(veiculosSelec);

                comboBox1.SelectedIndex = -1;
                txtMarca.Clear(); txtModelo.Clear(); txtPlaca.Clear(); comboBox1.SelectedIndex = -1;
            }
        }
    }
}
