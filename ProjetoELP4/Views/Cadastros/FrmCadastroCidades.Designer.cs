namespace ProjetoELP4.Forms {
    partial class FrmCadastroCidades {
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.btnConsultaEstados = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
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
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(507, 26);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(200, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(81, 26);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(258, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.Location = new System.Drawing.Point(411, 26);
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoEstado.TabIndex = 3;
            // 
            // btnConsultaEstados
            // 
            this.btnConsultaEstados.Location = new System.Drawing.Point(713, 25);
            this.btnConsultaEstados.Name = "btnConsultaEstados";
            this.btnConsultaEstados.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaEstados.TabIndex = 5;
            this.btnConsultaEstados.Text = "Consultar";
            this.btnConsultaEstados.UseVisualStyleBackColor = true;
            this.btnConsultaEstados.Click += new System.EventHandler(this.btnConsultaEstados_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(78, 10);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(408, 10);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(76, 13);
            this.lblCodigoEstado.TabIndex = 12;
            this.lblCodigoEstado.Text = "Código Estado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(504, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(345, 26);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(60, 20);
            this.txtDDD.TabIndex = 2;
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(342, 10);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 15;
            this.lblDDD.Text = "DDD";
            // 
            // FrmCadastroCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.btnConsultaEstados);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Name = "FrmCadastroCidades";
            this.Text = "Cadastro - Cidades";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.btnConsultaEstados, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.Button btnConsultaEstados;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label lblDDD;
    }
}
