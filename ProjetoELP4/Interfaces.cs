using ProjetoELP4.Controllers;
using ProjetoELP4.Forms;

namespace ProjetoELP4 {
    internal class Interfaces {

        FrmConsultaPaises frmConsultaPaises;
        FrmConsultaEstados frmConsultaEstados;
        FrmConsultaCidades frmConsultaCidades;

        FrmCadastroPaises frmCadastroPaises;
        FrmCadastroEstados frmCadastroEstados;
        FrmCadastroCidades frmCadastroCidades;

        ControllerPaises controllerPaises;
        ControllerEstados controllerEstados;
        ControllerCidades controllerCidades;

        public Interfaces() {
            frmConsultaPaises = new FrmConsultaPaises();
            frmConsultaEstados = new FrmConsultaEstados();
            frmConsultaCidades = new FrmConsultaCidades();

            frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroEstados = new FrmCadastroEstados();
            frmCadastroCidades = new FrmCadastroCidades();

            controllerPaises = new ControllerPaises();
            controllerEstados = new ControllerEstados();
            controllerCidades = new ControllerCidades();

            frmConsultaPaises.SetFrmCadastro(frmCadastroPaises);

            frmConsultaEstados.SetFrmCadastro(frmCadastroEstados);
            frmCadastroEstados.SetFrmConsultaPaises(frmConsultaPaises);

            frmConsultaCidades.SetFrmCadastro(frmCadastroCidades);
            frmCadastroCidades.SetFrmConsultaEstados(frmConsultaEstados);
        }

        public void PecaPaises(object obj) {
            frmConsultaPaises.ConhecaObjeto(obj, controllerPaises);
            frmConsultaPaises.ShowDialog();
        }

        public void PecaEstados(object obj) {
            frmConsultaEstados.ConhecaObjeto(obj, controllerEstados);
            frmConsultaEstados.ShowDialog();
        }

        public void PecaCidades(object obj) {
            frmConsultaCidades.ConhecaObjeto(obj, controllerCidades);
            frmConsultaCidades.ShowDialog();
        }

    }
}
