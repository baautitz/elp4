using ProjetoELP4.Controllers;
using ProjetoELP4.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultaEstados : ProjetoELP4.FrmConsultas {

		FrmCadastroEstados oFrmCadastroEstados;
		ControllerEstados aControllerEstados;

		Estados oEstado;
		List<Estados> listaEstados;

		public FrmConsultaEstados() {
			InitializeComponent();
			listaEstados = new List<Estados>();
		}

		public override void SetFrmCadastro(object frm) {
			oFrmCadastroEstados = (FrmCadastroEstados) frm;
		}

		public override void ConhecaObjeto(object obj, Controller controller) {
			oEstado = (Estados) obj;
			aControllerEstados = (ControllerEstados) controller;
		}

		public override void Incluir() {
			oFrmCadastroEstados.ConhecaObjeto(oEstado);
			oFrmCadastroEstados.LimpaTxt();
			oFrmCadastroEstados.ShowDialog();

			SalvaObjetoLista();
			CarregaLV();
		}

		public override void Alterar() {
			oFrmCadastroEstados.LimpaTxt();
			oFrmCadastroEstados.ConhecaObjeto(oEstado);
			oFrmCadastroEstados.CarregaTxt();
			oFrmCadastroEstados.ShowDialog();
		}

		public override void Excluir() {
			oFrmCadastroEstados.LimpaTxt();
			oFrmCadastroEstados.ConhecaObjeto(oEstado);
			oFrmCadastroEstados.CarregaTxt();
			oFrmCadastroEstados.BloqueiaTxt();
			oFrmCadastroEstados.ShowDialog();
			oFrmCadastroEstados.DesbloqueiaTxt();
		}

		public override void CarregaLV() {
			base.CarregaLV();

			listV.Items.Clear();

			foreach (Estados estado in listaEstados) {
				ListViewItem listViewItem = new ListViewItem(estado.Codigo.ToString());
				listViewItem.SubItems.Add(estado.Estado);
				listViewItem.SubItems.Add(estado.UF);
				listViewItem.SubItems.Add(estado.OPais.Pais);

				listV.Items.Add(listViewItem);
			}
		}

		public override void SalvaObjetoLista() {
			base.SalvaObjetoLista();

			Estados estado = oEstado.Clonar();

			if (estado.Codigo == 0) return;
			if (listaEstados.Exists(e => e.Codigo == estado.Codigo)) return;

			listaEstados.Add(estado);
		}

	}
}
