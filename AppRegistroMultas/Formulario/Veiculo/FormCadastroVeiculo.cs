using System;
using System.Windows.Forms;
using AppRegistroMultas.Models;
using AppRegistroMultas.Contexto;

namespace AppRegistroMultas.Formulario
{
    public partial class FormCadastroVeiculo : Form
    {
        public FormCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Modelo = txtModelo.Text;
            veiculo.Marca = txtMarca.Text;    
            veiculo.Placa = txtPlaca.Text;  

            VeiculoContext veiculoContext = new VeiculoContext();
            veiculoContext.InserirVeiculo(veiculo);

            Limpar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtModelo.Select();
        }
    }
}
