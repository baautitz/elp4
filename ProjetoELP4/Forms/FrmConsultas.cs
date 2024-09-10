using System;

namespace ProjetoELP4 {
	public partial class FrmConsultas : ProjetoELP4.FrmPai {
		public FrmConsultas() {
			InitializeComponent();
		}

		public virtual void SetFrmCadastro(object frm) {

		}

		public virtual void ConhecaObjeto(object obj) {

		}

		public virtual void Incluir() {

		}

        public virtual void Alterar() {

		}

        public virtual void Excluir() {

		}

		public virtual void CarregaLV() { 
		
		}

		public virtual void SalvaObjetoLista() {

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
	}
}
