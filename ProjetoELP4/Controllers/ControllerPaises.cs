
using ProjetoELP4.Data;

namespace ProjetoELP4.Controllers {
    internal class ControllerPaises : Controller {

        protected DAOPaises aDAOPaises;

        public ControllerPaises() {
            aDAOPaises = new DAOPaises();
        }

        public override object CarregaObjeto(int codigoObjeto) {
            return aDAOPaises.CarregaObjeto(codigoObjeto);
        }

        public override object CarregaTudo() {
            return aDAOPaises.CarregaTudo();
        }

        public override string Excluir(object obj) {
            return aDAOPaises.Excluir(obj);
        }

        public override string Salvar(object obj) {
            return aDAOPaises.Salvar(obj);
        }
    }
}
