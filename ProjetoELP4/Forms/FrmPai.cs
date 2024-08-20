using System;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmPai : Form {
		public FrmPai() {
			InitializeComponent();
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
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
        }
    }
}
