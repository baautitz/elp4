namespace ProjetoELP4 {
	partial class FrmConsultaEstados {
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
			this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.UF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listV
			// 
			this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Estado,
            this.UF,
            this.Pais});
			// 
			// Codigo
			// 
			this.Codigo.Text = "Código";
			// 
			// Estado
			// 
			this.Estado.Text = "Estado";
			this.Estado.Width = 472;
			// 
			// Pais
			// 
			this.Pais.Text = "País";
			this.Pais.Width = 240;
			// 
			// UF
			// 
			this.UF.Text = "UF";
			// 
			// FrmConsultaEstados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "FrmConsultaEstados";
			this.Text = "Consulta - Estados";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColumnHeader Codigo;
		private System.Windows.Forms.ColumnHeader Estado;
		private System.Windows.Forms.ColumnHeader Pais;
		private System.Windows.Forms.ColumnHeader UF;
	}
}
