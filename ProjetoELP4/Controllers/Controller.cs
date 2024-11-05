namespace ProjetoELP4.Controllers {
    public abstract class Controller {

        public abstract string Salvar(object obj);
        public abstract string Excluir(object obj);
        public abstract object CarregaTudo();
        public abstract object CarregaObjeto(int codigoObjeto);

    }
}
