namespace EstoqueVGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPecas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPedido = new System.Windows.Forms.Button();
            this.BtnServico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPecas
            // 
            this.BtnPecas.Location = new System.Drawing.Point(202, 88);
            this.BtnPecas.Name = "BtnPecas";
            this.BtnPecas.Size = new System.Drawing.Size(221, 29);
            this.BtnPecas.TabIndex = 0;
            this.BtnPecas.Text = "Peças";
            this.BtnPecas.UseVisualStyleBackColor = true;
            this.BtnPecas.Click += new System.EventHandler(this.BtnPecas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnPedido
            // 
            this.BtnPedido.Location = new System.Drawing.Point(202, 141);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(221, 29);
            this.BtnPedido.TabIndex = 2;
            this.BtnPedido.Text = "Pedido";
            this.BtnPedido.UseVisualStyleBackColor = true;
            this.BtnPedido.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // BtnServico
            // 
            this.BtnServico.Location = new System.Drawing.Point(202, 194);
            this.BtnServico.Name = "BtnServico";
            this.BtnServico.Size = new System.Drawing.Size(221, 29);
            this.BtnServico.TabIndex = 3;
            this.BtnServico.Text = "Serviços";
            this.BtnServico.UseVisualStyleBackColor = true;
            this.BtnServico.Click += new System.EventHandler(this.BtnServico_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair/Desconectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(202, 244);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(221, 29);
            this.BtnCliente.TabIndex = 5;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 354);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnServico);
            this.Controls.Add(this.BtnPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPecas);
            this.Name = "Form1";
            this.Text = "Sistema de Estoque - Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPedido;
        private System.Windows.Forms.Button BtnServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCliente;
    }
}

