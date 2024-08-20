using ProjetoELP4.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
	internal class Interfaces {

		FrmConsultaPaises frmConsultaPaises;
		FrmConsultaEstados frmConsultaEstados;
		FrmConsultaCidades frmConsultaCidades;

		FrmCadastroPaises frmCadastroPaises;
		FrmCadastroEstados frmCadastroEstados;
		FrmCadastroCidades frmCadastroCidades;

		public Interfaces() {
			frmConsultaPaises = new FrmConsultaPaises();
			frmConsultaEstados = new FrmConsultaEstados();
			frmConsultaCidades = new FrmConsultaCidades();

			frmCadastroPaises = new FrmCadastroPaises();
			frmCadastroEstados = new FrmCadastroEstados();
			frmCadastroCidades = new FrmCadastroCidades();

			frmConsultaPaises.SetFrmCadastro(frmCadastroPaises);
			frmConsultaEstados.SetFrmCadastro(frmCadastroEstados);
			frmConsultaCidades.SetFrmCadastro(frmCadastroCidades);
        }

		public void PecaPaises(object obj) {
			frmConsultaPaises.ConhecaObjeto(obj);
			frmConsultaPaises.ShowDialog();
		}

		public void PecaEstados(object obj) {
            frmConsultaEstados.ConhecaObjeto(obj);
            frmConsultaEstados.ShowDialog();
		}

		public void PecaCidades(object obj) {
            frmConsultaCidades.ConhecaObjeto(obj);
            frmConsultaCidades.ShowDialog();
		}

	}
}
