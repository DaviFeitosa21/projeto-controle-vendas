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

            tabelaClientes.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

            obj.codigo = int.Parse(txtCodigo.Text);

            ClientesDAO dao = new ClientesDAO();
            dao.alterarClientes(obj);

            tabelaClientes.DataSource = dao.listarClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            obj.codigo = int.Parse(txtCodigo.Text);

            ClientesDAO excluiClientes = new ClientesDAO();
            excluiClientes.excluirClientes(obj);

            tabelaClientes.DataSource = excluiClientes.listarClientes();
        }

        private void tabelaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaClientes.CurrentRow.Cells[1].Value.ToString();
            mTxtRG.Text = tabelaClientes.CurrentRow.Cells[2].Value.ToString();
            mTxtCPF.Text = tabelaClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaClientes.CurrentRow.Cells[4].Value.ToString();
            mTxtTelefone.Text = tabelaClientes.CurrentRow.Cells[5].Value.ToString();
            mTxtCelular.Text = tabelaClientes.CurrentRow.Cells[6].Value.ToString();
            mTxtCep.Text = tabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtEnd.Text = tabelaClientes.CurrentRow.Cells[8].Value.ToString();
            txtNum.Text = tabelaClientes.CurrentRow.Cells[9].Value.ToString();
            txtComple.Text = tabelaClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaClientes.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaClientes.CurrentRow.Cells[12].Value.ToString();
            cBoxEstado.Text = tabelaClientes.CurrentRow.Cells[13].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClientesDAO consultClientes = new ClientesDAO();
            tabelaClientes.DataSource = consultClientes.listarClientes();
            tabelaClientes.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
