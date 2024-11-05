using System;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmPrincipal : Form {

		Interfaces interfaces;
		Paises oPais;
		Estados oEstado;
		Cidades aCidade;
		public FrmPrincipal() {
			interfaces = new Interfaces();
			
			oPais = new Paises();
			oEstado = new Estados();
			aCidade = new Cidades();

			InitializeComponent();
		}

		private void paísesToolStripMenuItem_Click(object sender, EventArgs e) {
			interfaces.PecaPaises(oPais);
		}

		private void estadosToolStripMenuItem_Click(object sender, EventArgs e) {
			interfaces.PecaEstados(oEstado);
		}

		private void cidadesToolStripMenuItem_Click(object sender, EventArgs e) {
			interfaces.PecaCidades(aCidade);
		}
	}
}
