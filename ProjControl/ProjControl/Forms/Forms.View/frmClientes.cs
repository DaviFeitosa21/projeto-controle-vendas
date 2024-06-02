using ProjControl.Forms.Forms.Connection.Forms.DAO;
using ProjControl.Forms.Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjControl.Forms.Forms.View
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            obj.nome = txtNome.Text;
            obj.rg = mTxtRG.Text;
            obj.cpf = mTxtCPF.Text;
            obj.email = txtEmail.Text;
            obj.telefone = mTxtTelefone.Text;
            obj.celular = mTxtCelular.Text;
            obj.cep = mTxtCep.Text;
            obj.endereco = txtEnd.Text;
            obj.numero = int.Parse(txtNum.Text);
            obj.complemento = txtComple.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cBoxEstado.Text;

            ClientesDAO dao = new ClientesDAO();
            dao.cadastrarClientes(obj);
        }
    }
}
