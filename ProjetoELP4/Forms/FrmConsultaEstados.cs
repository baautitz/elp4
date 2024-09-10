using ProjetoELP4.Forms;
using ProjetoELP4.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultaEstados : ProjetoELP4.FrmConsultas {

        FrmCadastroEstados oFrmCadastroEstados;
        Estados oEstado;
        List<Estados> listaEstados;
        public FrmConsultaEstados() {
            InitializeComponent();
            listaEstados = new List<Estados>();
        }

        public override void SetFrmCadastro(object frm) {
            oFrmCadastroEstados = (FrmCadastroEstados) frm;
        }

        public override void ConhecaObjeto(object obj) {
            oEstado = (Estados) obj;
        }

        public override void Incluir() {
            oFrmCadastroEstados.ConhecaObjeto(oEstado);
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.ShowDialog();

            CarregaLV();
            SalvaObjetoLista();
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

            ListViewItem listViewItem = new ListViewItem(oEstado.Codigo.ToString());
            listViewItem.SubItems.Add(oEstado.Estado);
            listViewItem.SubItems.Add(oEstado.OPais.Pais);

            listV.Items.Add(listViewItem);
		}

		public override void SalvaObjetoLista() {
			base.SalvaObjetoLista();

			listaEstados.Add(oEstado);
		}

	}
}
