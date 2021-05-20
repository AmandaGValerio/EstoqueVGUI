using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueVGUI
{
    public partial class ClientesDB : Form
    {
        public ClientesDB()
        {
            InitializeComponent();
        }

        private void ClienteDB_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.estoqueDataSet.clientes);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //se estiver presente no banco, atualiza
            //se não, adiciona
            try
            {
                clientesTableAdapter.Update(estoqueDataSet.clientes);
                //yourTableAdapter.Update(yourDataSet.tablename);
                MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error in Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
