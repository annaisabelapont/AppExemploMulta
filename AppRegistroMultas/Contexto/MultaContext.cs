using AppRegistroMultas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroMultas.Contexto
{
    public class MultaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public MultaContext()
        {
            dados_conexao = "server=localhost;port = 3306;database=bd_registro_multa;user=root;password=root;Persist Security Info = False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public List<Multa> ListarMultas()
        {
            List<Multa> ListaMultas = new List<Multa>();
            string sql = "SELECT * FROM MULTA";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);//objeto "comando" responsável por ir até o banco e realizar ações
                conexao.Open();//abrir a porta do banco para realizar a consulta
                MySqlDataReader dados = comando.ExecuteReader(); //"comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                //laço responsável por percorrer todos os registros que estão dentro do objeto "dados"
                while (dados.Read())
                {
                    Multa multa = new Multa();
                    multa.Id = Convert.ToInt32(dados["Id"]);
                    multa.Descricao = dados["Descricao"].ToString();
                    multa.ValorMulta = decimal.Parse(dados["ValorMulta"].ToString());
                    multa.VeiculoId = int.Parse(dados["VeiculoId"].ToString());
                    ListaMultas.Add(multa);
                }
                conexao.Close(); // Fechar a porta do banco após resultado da consulta         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return ListaMultas; //retornar o resultado (exportar para aplicação)
        }//fim do método para consultar e listar Veículos

        public void InserirMulta(Multa multa)
        {
            string sql = "INSERT INTO MULTA (Descricao, ValorMulta, VeiculoId) VALUES (@Descricao, @ValorMulta, @VeiculoId)"; //para inserir uma pessoa no banco

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); //executa o comando e mostrar quantas linhas foran afetadas

                MessageBox.Show("Multa cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                
            }

            finally
            {
                conexao.Close(); // Fecha as portas do banco, mesmo que ocorra erro
            }
        }//fim do método para inserir veículos

        public void AtualizarMulta(Multa multa)
        {
            string sql = "UPDATE MULTA SET Descricao = @Descricao, ValorMulta = @ValorMulta, VeiculoId = @VeiculoId WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);
                comando.Parameters.AddWithValue("@Id", multa.Id);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foran afetadas

                if (LinhasAfestadas > 0)
                {
                    MessageBox.Show("Multa atualizada com sucesso!");
                }

                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar multa: " + ex.Message);
            }

            finally
            {
                conexao.Close(); // Fecha a conexao com o banco
            }
        } // fim do Atualizar veiculo

        public void DeletarMulta(Multa multa)
        {
            // Comando SQL para atualizar os dados da pessoa
            string sql = "DELETE FROM MULTA WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);
                comando.Parameters.AddWithValue("@Id", multa.Id);
                conexao.Open(); // Abrir conexão com o banco
                int linhasAfetadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foram alteradas

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Multa deletada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar multa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }
        } //fim do Deletar Pessoa

    }
}
