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
    public partial class ServicosDB : Form
    {
        public ServicosDB()
        {
            InitializeComponent();
        }

        private void ServicosDB_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.estoqueDataSet.servicos);

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                servicosTableAdapter.Update(estoqueDataSet.servicos);
                //yourTableAdapter.Update(yourDataSet.tablename);
                MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error in Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
