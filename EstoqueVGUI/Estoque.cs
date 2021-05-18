using Estoque;
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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bug que muda uma vez só e depois não muda mais
            string nameTable;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = estoqueDataSet;
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Cliente")
            {
                nameTable = "clientes";
               

            }
            else if(comboBox1.GetItemText(comboBox1.SelectedItem) == "Peça")
            {
                nameTable = "pecas";
            }
            else 
            {
                nameTable = "servicos";
                
            }
            dataGridView1.DataMember = nameTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar função para salvar banco e atualizar
            estoqueDataSet.AcceptChanges();
        }



    }
}
