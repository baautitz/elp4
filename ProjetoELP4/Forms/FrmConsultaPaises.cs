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

            CarregaLV();
            SalvaObjetoLista();
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

            ListViewItem listViewItem = new ListViewItem(oPais.Codigo.ToString());
            listViewItem.SubItems.Add(oPais.Pais);
            listViewItem.SubItems.Add(oPais.DDI);
            listViewItem.SubItems.Add(oPais.Sigla);
            listViewItem.SubItems.Add(oPais.Moeda);

            listV.Items.Add(listViewItem);
		}

		public override void SalvaObjetoLista() {
            base.SalvaObjetoLista();

            listaPaises.Add(oPais);
		}

	}
}
