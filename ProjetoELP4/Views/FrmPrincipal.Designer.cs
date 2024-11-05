namespace ProjetoELP4 {
	partial class FrmPrincipal {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paísesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// consultasToolStripMenuItem
			// 
			this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paísesToolStripMenuItem,
            this.estadosToolStripMenuItem,
            this.cidadesToolStripMenuItem});
			this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
			this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.consultasToolStripMenuItem.Text = "Consultas";
			// 
			// paísesToolStripMenuItem
			// 
			this.paísesToolStripMenuItem.Name = "paísesToolStripMenuItem";
			this.paísesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.paísesToolStripMenuItem.Text = "Países";
			this.paísesToolStripMenuItem.Click += new System.EventHandler(this.paísesToolStripMenuItem_Click);
			// 
			// estadosToolStripMenuItem
			// 
			this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
			this.estadosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.estadosToolStripMenuItem.Text = "Estados";
			this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
			// 
			// cidadesToolStripMenuItem
			// 
			this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
			this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.cidadesToolStripMenuItem.Text = "Cidades";
			this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.cidadesToolStripMenuItem_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal";
			this.Text = "Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paísesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;

		#endregion

	}
}