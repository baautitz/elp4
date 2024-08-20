using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultas : ProjetoELP4.FrmPai {
		public FrmConsultas() {
			InitializeComponent();
		}

        public virtual void Incluir() {

		}

        public virtual void Alterar() {

		}

        public virtual void Excluir() {

		}

        public virtual void ConhecaObjeto(object obj) { 
		
		}

		private void btnIncluir_Click(object sender, EventArgs e) {
			this.Incluir();
		}

		private void btnAlterar_Click(object sender, EventArgs e) {
			this.Alterar();
		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			this.Excluir();
		}

		public virtual void SetFrmCadastro(object frm) {

		}
	}
}
