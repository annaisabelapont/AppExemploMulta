using AppRegistroMultas.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppRegistroMultas.Formulario.Veiculo
{
    public partial class FormDeletarVeiculo: Form
    {
        List<Models.Veiculo> ListaVeiculos = new List<Models.Veiculo>();
        Models.Veiculo veiculoSelecionado = new Models.Veiculo();

        public FormDeletarVeiculo()
        {
            InitializeComponent();

            VeiculoContext veiculo = new VeiculoContext();
            ListaVeiculos = veiculo.ListarVeiculos();

            cbVeiculo.DataSource = ListaVeiculos.ToList();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            VeiculoContext context = new VeiculoContext();


            MultaContext multaContext = new MultaContext();
            var multasDoVeiculo = multaContext.ListarMultas().Where(mul => mul.VeiculoId == veiculoSelecionado.Id).ToList();

            foreach (var multa in multasDoVeiculo)
            {
                multaContext.DeletarMulta(multa);
            }
            context.DeletarVeiculo(veiculoSelecionado);

            txtMarca.Clear(); txtModelo.Clear(); txtPlaca.Clear(); cbVeiculo.SelectedIndex = -1;
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

                veiculoSelecionado = veiculosSelec;
            }
            else
            {
                txtMarca.Clear(); txtModelo.Clear(); txtPlaca.Clear();
            }
        }
    }
}
