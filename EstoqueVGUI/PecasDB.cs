﻿using System;
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
    public partial class PecasDB : Form
    {
        public PecasDB()
        {
            InitializeComponent();
        }

        private void EstoquePecas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.pecas'. Você pode movê-la ou removê-la conforme necessário.
            this.pecasTableAdapter.Fill(this.estoqueDataSet.pecas);

        }
    }
}