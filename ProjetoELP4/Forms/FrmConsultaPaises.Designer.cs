namespace ProjetoELP4 {
	partial class FrmConsultaPaises {
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
			this.País = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Moeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listV
			// 
			this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.País,
            this.DDI,
            this.Sigla,
            this.Moeda});
			// 
			// País
			// 
			this.País.Text = "País";
			this.País.Width = 532;
			// 
			// DDI
			// 
			this.DDI.Text = "DDI";
			this.DDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Sigla
			// 
			this.Sigla.Text = "Sigla";
			this.Sigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Moeda
			// 
			this.Moeda.Text = "Moeda";
			this.Moeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Codigo
			// 
			this.Codigo.Text = "Código";
			this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FrmConsultaPaises
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "FrmConsultaPaises";
			this.Text = "Consulta - Países";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ColumnHeader País;
		private System.Windows.Forms.ColumnHeader DDI;
		private System.Windows.Forms.ColumnHeader Sigla;
		private System.Windows.Forms.ColumnHeader Moeda;
		private System.Windows.Forms.ColumnHeader Codigo;
	}
}
