using ProjetoELP4.Controllers;
using ProjetoELP4.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultaCidades : ProjetoELP4.FrmConsultas {

		FrmCadastroCidades oFrmCadastroCidades;
		ControllerCidades aControllerCidades;

		Cidades aCidade;
		List<Cidades> listaCidades;

		public FrmConsultaCidades() {
			InitializeComponent();
			listaCidades = new List<Cidades>();
		}

		public override void SetFrmCadastro(object frm) {
			oFrmCadastroCidades = (FrmCadastroCidades) frm;
		}

        public override void ConhecaObjeto(object obj, Controller controller) {
            aCidade = (Cidades) obj;
            aControllerCidades = (ControllerCidades) controller;
        }

        public override void Incluir() {
			oFrmCadastroCidades.ConhecaObjeto(aCidade);
			oFrmCadastroCidades.LimpaTxt();
			oFrmCadastroCidades.ShowDialog();

			SalvaObjetoLista();
			CarregaLV();
		}

		public override void Alterar() {
			oFrmCadastroCidades.LimpaTxt();
			oFrmCadastroCidades.ConhecaObjeto(aCidade);
			oFrmCadastroCidades.CarregaTxt();
			oFrmCadastroCidades.ShowDialog();
		}

		public override void Excluir() {
			oFrmCadastroCidades.LimpaTxt();
			oFrmCadastroCidades.ConhecaObjeto(aCidade);
			oFrmCadastroCidades.CarregaTxt();
			oFrmCadastroCidades.BloqueiaTxt();
			oFrmCadastroCidades.ShowDialog();
			oFrmCadastroCidades.DesbloqueiaTxt();
		}

		public override void CarregaLV() {
			base.CarregaLV();

			listV.Items.Clear();

			foreach (Cidades cidade in listaCidades) {
				ListViewItem listViewItem = new ListViewItem(cidade.Codigo.ToString());
				listViewItem.SubItems.Add(cidade.Cidade);
				listViewItem.SubItems.Add(cidade.DDD);
				listViewItem.SubItems.Add(cidade.OEstado.Estado);

				listV.Items.Add(listViewItem);
			}
		}

		public override void SalvaObjetoLista() {
			base.SalvaObjetoLista();

			Cidades cidade = aCidade.Clonar();

			if (cidade.Codigo == 0) return;
			if (listaCidades.Exists(c => c.Codigo == cidade.Codigo)) return;

			listaCidades.Add(cidade);
		}
	}
}
