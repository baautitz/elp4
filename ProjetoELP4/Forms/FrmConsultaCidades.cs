using ProjetoELP4.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmConsultaCidades : ProjetoELP4.FrmConsultas {

        FrmCadastroCidades oFrmCadastroCidades;
        Cidades aCidade;

        public FrmConsultaCidades() {
            InitializeComponent();
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

    }
}
