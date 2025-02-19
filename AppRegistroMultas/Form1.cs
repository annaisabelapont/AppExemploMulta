using System;
using System.Windows.Forms;
using AppRegistroMultas.Formulario;
using AppRegistroMultas.Formulario.Veiculo;

namespace AppRegistroMultas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastroVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastroVeiculo form = new FormCadastroVeiculo(); 
            form.ShowDialog();
        }

        private void btCadastroMulta_Click(object sender, EventArgs e)
        {
            FormCadastroMulta form = new FormCadastroMulta();
            form.ShowDialog();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormConsultarMultas form = new FormConsultarMultas();
            form.ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarVeiculo form = new FormAtualizarVeiculo();
            form.ShowDialog();
        }

        private void btAtualizarMulta_Click(object sender, EventArgs e)
        {
            FormAtualizarMulta form = new FormAtualizarMulta();
            form.ShowDialog();
        }

        private void btDeletarMulta_Click(object sender, EventArgs e)
        {
            FormDeletarMulta form = new FormDeletarMulta();
            form.ShowDialog();
        }

        private void btConsultaVeiculo_Click(object sender, EventArgs e)
        {
            FormConsultarVeiculo form = new FormConsultarVeiculo();
            form.ShowDialog();
        }

        private void btDeletarVeiculo_Click(object sender, EventArgs e)
        {
            FormDeletarVeiculo form = new FormDeletarVeiculo();
            form.ShowDialog();
        }
    }
}
