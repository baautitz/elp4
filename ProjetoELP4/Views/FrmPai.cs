using ProjetoELP4.Controllers;
using System;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmPai : Form {
		public FrmPai() {
			InitializeComponent();
		}

        public virtual void ConhecaObjeto(object obj, Controller controller) {

        }

        private void btnSair_Click(object sender, EventArgs e) {
			Close();
		}

        private void FrmPai_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();

                e.SuppressKeyPress = true;
                return;
            }
        }

        private void FrmPai_KeyPress(object sender, KeyPressEventArgs e) {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
