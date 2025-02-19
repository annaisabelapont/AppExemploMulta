using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppRegistroMultas.Formulario
{
    public partial class FormConsultarVeiculo: Form
    {
        List<Veiculo> ListaVeiculos = new List<Veiculo>();

        public FormConsultarVeiculo()
        {
            InitializeComponent();
            VeiculoContext veiculo = new VeiculoContext();
            ListaVeiculos = veiculo.ListarVeiculos();

            cbVeiculo.DataSource = ListaVeiculos.ToList();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbVeiculo.SelectedIndex;
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
    }
}
