using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;

namespace AppRegistroMultas.Formulario
{
    public partial class FormConsultaVeiculo : Form
    {
        int cont = 1; 
        List<Veiculo> listaVeiculos = new List<Veiculo>();  
        List<Multa> listaMulta = new List<Multa>();

        public FormConsultaVeiculo()
        {
            InitializeComponent();

            VeiculoContext veiculoContext = new VeiculoContext();
            listaVeiculos = veiculoContext.ListarVeiculos();

            MultaContext multaContext = new MultaContext();
            listaMulta = multaContext.ListarMultas();

            cbVeiculo.DataSource = listaVeiculos.ToList();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linhaSelec = cbVeiculo.SelectedIndex;
            if (linhaSelec > -1 && cont > 1)
            {
                var veiculo = listaVeiculos[linhaSelec];
                txtModelo.Text = veiculo.Modelo;
                txtMarca.Text = veiculo.Marca;
                txtPlaca.Text = veiculo.Placa;
                
                var listaMultasVinc = listaMulta.Where(multa => multa.VeiculoId == veiculo.Id).ToList();

                dtTabela.DataSource = listaMultasVinc.ToList();
            }
            cont++;
        }
    }
}
