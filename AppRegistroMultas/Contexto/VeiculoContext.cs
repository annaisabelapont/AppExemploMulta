using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using AppRegistroMultas;
using AppRegistroMultas.Models;

namespace AppRegistroMultas.Contexto
{
    public class VeiculoContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public VeiculoContext()
        {
            dados_conexao = "server=localhost;port = 3306;database=bd_registro_multa;user=root;password=root;Persist Security Info = False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }//fim do método construtor

        public List<Veiculo> ListarVeiculos()
        {
            List<Veiculo> listaVeiculosParaExportar = new List<Veiculo>();// para retornar (return) o resutaldo e ser utilizado na aplicação
            string sql = "SELECT * FROM VEICULO"; //consulta SQL para trazer todas as pessoas
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);//objeto "comando" responsável por ir até o banco e realizar ações
                conexao.Open();//abrir a porta do banco para realizar a consulta
                MySqlDataReader dados = comando.ExecuteReader(); //"comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                //laço responsável por percorrer todos os registros que estão dentro do objeto "dados"
                while (dados.Read())
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.Id = Convert.ToInt32(dados["Id"]);
                    veiculo.Marca = dados["Marca"].ToString();
                    veiculo.Modelo = dados["Modelo"].ToString();
                    veiculo.Placa = dados["Placa"].ToString();
                    listaVeiculosParaExportar.Add(veiculo);
                }
                conexao.Close(); // Fechar a porta do banco após resultado da consulta         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return listaVeiculosParaExportar; //retornar o resultado (exportar para aplicação)
        }//fim do método para consultar e listar Veículos

        public void InserirVeiculo(Veiculo veiculo)
        {
            string sql = "INSERT INTO VEICULO (Placa, Modelo, Marca) VALUES (@Placa,@Modelo, @Marca)"; //para inserir uma pessoa no banco

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); //executa o comando e mostrar quantas linhas foran afetadas

                MessageBox.Show("Veículo cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir veículo: " + ex.Message);
            }

            finally
            {
                conexao.Close(); // Fecha as portas do banco, mesmo que ocorra erro
            }
        }//fim do método para inserir veículos

        public void AtualizarVeiculo(Veiculo veiculo)
        {            // Comando SQL para atualizar os dados da pessoa
            string sql = "UPDATE VEICULO SET Placa = @Placa, Modelo = @Modelo, Marca = @Marca WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);
                comando.Parameters.AddWithValue("@Id", veiculo.Id);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foran afetadas

                if (LinhasAfestadas > 0)
                {
                    MessageBox.Show("Veículo atualizado com sucesso!");
                }

                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar veículo: " + ex.Message);
            }

            finally
            {
                conexao.Close(); // Fecha a conexao com o banco
            }
        } // fim do Atualizar veiculo

        public void DeletarVeiculo(Veiculo veiculo)
        {
            string sql = "delete from veiculo where Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Id", veiculo.Id);

                conexao.Open();
                int LinhasAfestadas = comando.ExecuteNonQuery();

                if (LinhasAfestadas > 0)
                {
                    MessageBox.Show("Veículo e suas multas foram deletados com sucesso!");
                }

                else
                {
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar veículo: " + ex.Message);
            }

            finally
            {
                conexao.Close();
            }
        }

    }//fim da classe

}//fim do namespace
