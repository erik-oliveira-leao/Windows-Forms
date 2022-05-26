namespace ctrl_informatica.Apresentacao
{
    partial class Menus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnChamado = new System.Windows.Forms.Button();
            this.BtnServico = new System.Windows.Forms.Button();
            this.BtnCadCliente = new System.Windows.Forms.Button();
            this.BtnCadFunc = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChamado
            // 
            this.BtnChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChamado.Location = new System.Drawing.Point(347, 237);
            this.BtnChamado.Name = "BtnChamado";
            this.BtnChamado.Size = new System.Drawing.Size(161, 23);
            this.BtnChamado.TabIndex = 0;
            this.BtnChamado.Text = "CHAMADO";
            this.BtnChamado.UseVisualStyleBackColor = false;
            this.BtnChamado.Click += new System.EventHandler(this.BtnChamado_Click);
            // 
            // BtnServico
            // 
            this.BtnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServico.Location = new System.Drawing.Point(347, 162);
            this.BtnServico.Name = "BtnServico";
            this.BtnServico.Size = new System.Drawing.Size(161, 23);
            this.BtnServico.TabIndex = 1;
            this.BtnServico.Text = "ORDEM SERVIÇO";
            this.BtnServico.UseVisualStyleBackColor = false;
            this.BtnServico.Click += new System.EventHandler(this.BtnServico_Click);
            // 
            // BtnCadCliente
            // 
            this.BtnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadCliente.Location = new System.Drawing.Point(64, 162);
            this.BtnCadCliente.Name = "BtnCadCliente";
            this.BtnCadCliente.Size = new System.Drawing.Size(216, 23);
            this.BtnCadCliente.TabIndex = 2;
            this.BtnCadCliente.Text = "CADASTRAR CLIENTE";
            this.BtnCadCliente.UseVisualStyleBackColor = false;
            this.BtnCadCliente.Click += new System.EventHandler(this.BtnCadCliente_Click);
            // 
            // BtnCadFunc
            // 
            this.BtnCadFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadFunc.Location = new System.Drawing.Point(64, 237);
            this.BtnCadFunc.Name = "BtnCadFunc";
            this.BtnCadFunc.Size = new System.Drawing.Size(216, 23);
            this.BtnCadFunc.TabIndex = 3;
            this.BtnCadFunc.Text = "CADASTRAR FUNCIONARIO";
            this.BtnCadFunc.UseVisualStyleBackColor = false;
            this.BtnCadFunc.UseWaitCursor = true;
            this.BtnCadFunc.Click += new System.EventHandler(this.BtnCadFunc_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisa.Location = new System.Drawing.Point(628, 302);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(110, 35);
            this.BtnPesquisa.TabIndex = 4;
            this.BtnPesquisa.Text = "Pesquisar";
            this.BtnPesquisa.UseVisualStyleBackColor = false;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnCadFunc);
            this.Controls.Add(this.BtnCadCliente);
            this.Controls.Add(this.BtnServico);
            this.Controls.Add(this.BtnChamado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menus";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChamado;
        private System.Windows.Forms.Button BtnServico;
        private System.Windows.Forms.Button BtnCadCliente;
        private System.Windows.Forms.Button BtnCadFunc;
        private System.Windows.Forms.Button BtnPesquisa;
    }
}