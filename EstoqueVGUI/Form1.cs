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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPecas_Click(object sender, EventArgs e)
        {
            (new PecasDB()).Show();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            (new ClientesDB()).Show();
        }

        private void BtnServico_Click(object sender, EventArgs e)
        {
            (new ServicosDB()).Show();
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
