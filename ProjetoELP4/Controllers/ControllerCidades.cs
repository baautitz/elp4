
using ProjetoELP4.Data;

namespace ProjetoELP4.Controllers {
    internal class ControllerCidades : Controller {

        protected DAOCidades aDAOCidades;

        public ControllerCidades() {
            aDAOCidades = new DAOCidades();
        }

        public override object CarregaObjeto(int codigoObjeto) {
            return aDAOCidades.CarregaObjeto(codigoObjeto);
        }

        public override object CarregaTudo() {
            return aDAOCidades.CarregaTudo();
        }

        public override string Excluir(object obj) {
            return aDAOCidades.Excluir(obj);
        }

        public override string Salvar(object obj) {
            return aDAOCidades.Salvar(obj);
        }
    }
}
