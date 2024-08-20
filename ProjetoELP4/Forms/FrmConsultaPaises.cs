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

        public override void ConhecaObjeto(object obj) {
            oPais = (Paises) obj;
        }

    }
}
