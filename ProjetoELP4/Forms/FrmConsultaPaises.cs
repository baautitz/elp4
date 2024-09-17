using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultaPaises : ProjetoELP4.FrmConsultas {

		FrmCadastroPaises oFrmCadastroPaises;
		Paises oPais;
		List<Paises> listaPaises;
		public FrmConsultaPaises() {
			InitializeComponent();
			listaPaises = new List<Paises>();
		}

		public override void SetFrmCadastro(object frm) {
			oFrmCadastroPaises = (FrmCadastroPaises) frm;
		}

		public override void ConhecaObjeto(object obj) {
			oPais = (Paises) obj;
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

			foreach (Paises pais in listaPaises) {
				ListViewItem listViewItem = new ListViewItem(pais.Codigo.ToString());
				listViewItem.SubItems.Add(pais.Pais);
				listViewItem.SubItems.Add(pais.DDI);
				listViewItem.SubItems.Add(pais.Sigla);
				listViewItem.SubItems.Add(pais.Moeda);

				listV.Items.Add(listViewItem);
			}

		}

		public override void SalvaObjetoLista() {
			base.SalvaObjetoLista();

			Paises pais = oPais.Clone();

			if (pais.Codigo == 0) return;
			if (listaPaises.Exists(p => p.Codigo == pais.Codigo)) return;

			listaPaises.Add(pais);
		}

	}
}
