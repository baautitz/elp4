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
        public FrmConsultaCidades() {
            InitializeComponent();
        }

        public override void SetFrmCadastro(object frm) {
            oFrmCadastroCidades = (FrmCadastroCidades) frm;
        }

        public override void Incluir() {
            oFrmCadastroCidades.ShowDialog();
        }

        public override void Alterar() {
            oFrmCadastroCidades.ShowDialog();
        }

        public override void Excluir() {
            oFrmCadastroCidades.ShowDialog();
        }

    }
}
