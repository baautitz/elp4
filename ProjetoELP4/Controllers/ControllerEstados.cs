using ProjetoELP4.Data;

namespace ProjetoELP4.Controllers {
    internal class ControllerEstados : Controller {

        protected DAOEstados aDAOEstados;

        public ControllerEstados() {
            aDAOEstados = new DAOEstados();
        }

        public override object CarregaObjeto(int codigoObjeto) {
            return aDAOEstados.CarregaObjeto(codigoObjeto);
        }

        public override object CarregaTudo() {
            return aDAOEstados.CarregaTudo();
        }

        public override string Excluir(object obj) {
            return aDAOEstados.Excluir(obj);
        }

        public override string Salvar(object obj) {
            return aDAOEstados.Salvar(obj);
        }
    }
}
