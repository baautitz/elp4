using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmConsultaPaises : ProjetoELP4.FrmConsultas {

        FrmCadastroPaises oFrmCadastroPaises;
        Paises oPais;
        public FrmConsultaPaises() {
            InitializeComponent();
        }

        public override void SetFrmCadastro(object frm) {
            oFrmCadastroPaises = (FrmCadastroPaises) frm;
        }

        public override void Incluir() {
            oFrmCadastroPaises.ConhecaObjeto(oPais);
            oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.ShowDialog();
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

            ListViewItem listViewItem = new ListViewItem(oPais.Codigo.ToString());
            listViewItem.SubItems.Add(oPais.Pais);
            listViewItem.SubItems.Add(oPais.DDI);
            listViewItem.SubItems.Add(oPais.Sigla);
            listViewItem.SubItems.Add(oPais.Moeda);

            listV.Items.Add(listViewItem);
		}

		public override void ConhecaObjeto(object obj) {
            oPais = (Paises) obj;
        }

    }
}
