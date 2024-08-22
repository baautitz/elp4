using ProjetoELP4.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmConsultaEstados : ProjetoELP4.FrmConsultas {

        FrmCadastroEstados oFrmCadastroEstados;
        Estados oEstado;
        public FrmConsultaEstados() {
            InitializeComponent();
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

    }
}
