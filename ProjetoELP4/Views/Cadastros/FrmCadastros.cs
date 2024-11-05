using System;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmCadastros : ProjetoELP4.FrmPai {
		public FrmCadastros() {
			InitializeComponent();
		}

		public virtual void ConhecaObjeto(object obj) {

		}

		public virtual void LimpaTxt() {

		}

		public virtual void CarregaTxt() {

		}

		public virtual void BloqueiaTxt() {

		}

		public virtual void DesbloqueiaTxt() {

		}

		public virtual void Salvar() {
			MessageBox.Show("Cadastro salvo com sucesso!");
		}

        private void btnSalvar_Click(object sender, EventArgs e) {
			Salvar();
        }
    }
}
