using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
