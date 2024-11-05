using ProjetoELP4.Controllers;
using ProjetoELP4.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmConsultaPaises : FrmConsultas {

		FrmCadastroPaises oFrmCadastroPaises;
		ControllerPaises aControllerPaises;

		Paises oPais;
		public FrmConsultaPaises() {
			InitializeComponent();
		}

		public override void SetFrmCadastro(object frm) {
			oFrmCadastroPaises = (FrmCadastroPaises) frm;
		}

		public override void ConhecaObjeto(object obj, Controller controller) {
			oPais = (Paises) obj;
			aControllerPaises = (ControllerPaises) controller;
		}

		public override void Incluir() {
			oFrmCadastroPaises.ConhecaObjeto(oPais);
			oFrmCadastroPaises.LimpaTxt();
			oFrmCadastroPaises.ShowDialog();

			SalvaObjetoLista();
			CarregaLV();
		}

		public override void Alterar() {
			oFrmCadastroPaises.LimpaTxt();
			oFrmCadastroPaises.ConhecaObjeto(oPais);
			oFrmCadastroPaises.CarregaTxt();
			oFrmCadastroPaises.ShowDialog();
		}

		public override void Excluir() {
			oFrmCadastroPaises.LimpaTxt();
			oFrmCadastroPaises.ConhecaObjeto(oPais);
			oFrmCadastroPaises.CarregaTxt();
			oFrmCadastroPaises.BloqueiaTxt();
			oFrmCadastroPaises.ShowDialog();
			oFrmCadastroPaises.DesbloqueiaTxt();
		}

		public override void CarregaLV() {
			base.CarregaLV();

			listV.Items.Clear();

			ColecaoPaises colecaoPaises = (ColecaoPaises) aControllerPaises.CarregaTudo();
			if (colecaoPaises == null) return;

			foreach (Paises pais in colecaoPaises.ListaTudo()) {
				ListViewItem listViewItem = new ListViewItem(pais.Codigo.ToString());
				listViewItem.SubItems.Add(pais.Pais);
				listViewItem.SubItems.Add(pais.DDI);
				listViewItem.SubItems.Add(pais.Sigla);
				listViewItem.SubItems.Add(pais.Moeda);

				listV.Items.Add(listViewItem);
			}

		}

		public override void SalvaObjetoLista() {
			//base.SalvaObjetoLista();

			//Paises pais = oPais.Clonar();

			//if (pais.Codigo == 0) return;
			//if (listaPaises.Exists(p => p.Codigo == pais.Codigo)) return;

			//listaPaises.Add(pais);
		}

        private void FrmConsultaPaises_Load(object sender, System.EventArgs e) {
			CarregaLV();
        }
    }
}
