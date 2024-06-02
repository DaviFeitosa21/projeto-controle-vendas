using MySql.Data.MySqlClient;
using ProjControl.Forms.Forms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjControl.Forms.Forms.Connection.Forms.DAO
{
    public class ClientesDAO
    {
        private MySqlConnection conexao;

        public ClientesDAO() 
        {
            this.conexao = new ConnectionBD().getconnection();
        }

        //Função para cadastrar clientes
        public void cadastrarClientes(Clientes obj)
        {
            try 
            {
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                conexao.Close();
            } 
            catch (Exception erro) 
            {
                MessageBox.Show("Erro:" + erro);
            }
        }

        //Função para listar clientes
        public void alterarClientes(Clientes obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, 
                               telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero,
                               complemento=@complemento, bairro=@bairro,cidade=@cidade, estado=@estado where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }
        }

        public void excluirClientes(Clientes obj)
        {
            try
            {
                string sql = @"delete from tb_clientes where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente removido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }
        }

        //Função para listagem de clientes
        public DataTable listarClientes()
        {
            try
            {
                DataTable tabelaClientes = new DataTable();
                string sql = "select * from tb_clientes";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter tabledat = new MySqlDataAdapter(executacmd);
                tabledat.Fill(tabelaClientes);

                conexao.Close();

                return tabelaClientes;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando SQL: " + erro);
                return null;
            }
        }
    }
}
