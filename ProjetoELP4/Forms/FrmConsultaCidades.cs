using ProjetoELP4.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoELP4 {
	public partial class FrmConsultaCidades : ProjetoELP4.FrmConsultas {

        FrmCadastroCidades oFrmCadastroCidades;
        Cidades aCidade;
        List<Cidades> listaCidades;

        public FrmConsultaCidades() {
            InitializeComponent();
            listaCidades = new List<Cidades>();
        }

        public override void ConhecaObjeto(object obj) {
            aCidade = (Cidades) obj;
        }

        public override void SetFrmCadastro(object frm) {
            oFrmCadastroCidades = (FrmCadastroCidades) frm;
        }

        public override void Incluir() {
            oFrmCadastroCidades.ConhecaObjeto(aCidade);
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.ShowDialog();

            CarregaLV();
            SalvaObjetoLista();
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

            ListViewItem listViewItem = new ListViewItem(aCidade.Codigo.ToString());
            listViewItem.SubItems.Add(aCidade.Cidade);
            listViewItem.SubItems.Add(aCidade.OEstado.Estado);

            listV.Items.Add(listViewItem);
		}

		public override void SalvaObjetoLista() {
			base.SalvaObjetoLista();

			listaCidades.Add(aCidade);
		}

	}
}
