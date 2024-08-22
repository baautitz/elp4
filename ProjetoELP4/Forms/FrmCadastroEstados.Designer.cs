namespace ProjetoELP4.Forms {
    partial class FrmCadastroEstados {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.btnConsultaPaises = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 7;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(507, 26);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(200, 20);
            this.txtPais.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(81, 26);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(258, 20);
            this.txtEstado.TabIndex = 1;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(411, 26);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoPais.TabIndex = 3;
            // 
            // btnConsultaPaises
            // 
            this.btnConsultaPaises.Location = new System.Drawing.Point(713, 25);
            this.btnConsultaPaises.Name = "btnConsultaPaises";
            this.btnConsultaPaises.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaPaises.TabIndex = 5;
            this.btnConsultaPaises.Text = "Consultar";
            this.btnConsultaPaises.UseVisualStyleBackColor = true;
            this.btnConsultaPaises.Click += new System.EventHandler(this.btnConsultaPaises_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(78, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(408, 10);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(65, 13);
            this.lblCodigoPais.TabIndex = 12;
            this.lblCodigoPais.Text = "Código País";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(504, 10);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 13;
            this.lblPais.Text = "País";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(345, 26);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(60, 20);
            this.txtUF.TabIndex = 2;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(342, 10);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 15;
            this.lblUF.Text = "UF";
            // 
            // FrmCadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnConsultaPaises);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Name = "FrmCadastroEstados";
            this.Text = "Cadastro - Estados";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.btnConsultaPaises, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Button btnConsultaPaises;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
    }
}
