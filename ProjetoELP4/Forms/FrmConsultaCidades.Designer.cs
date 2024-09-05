namespace ProjetoELP4 {
	partial class FrmConsultaCidades {
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
			this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listV
			// 
			this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Cidade,
            this.Estado});
			// 
			// Codigo
			// 
			this.Codigo.Text = "Código";
			// 
			// Cidade
			// 
			this.Cidade.Text = "Cidade";
			this.Cidade.Width = 472;
			// 
			// Estado
			// 
			this.Estado.Text = "Estado";
			this.Estado.Width = 240;
			// 
			// FrmConsultaCidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "FrmConsultaCidades";
			this.Text = "Consulta - Cidades";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColumnHeader Codigo;
		private System.Windows.Forms.ColumnHeader Cidade;
		private System.Windows.Forms.ColumnHeader Estado;
	}
}
