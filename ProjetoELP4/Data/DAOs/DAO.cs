using System.Data.SqlClient;

namespace ProjetoELP4.Data {
    public abstract class DAO {
        protected SqlConnection conn;

        public DAO() {
            conn = Banco.Abrir();
        }

        public void Abrir() {
            conn = Banco.Abrir();
        }

        public abstract string Salvar(object obj);
        public abstract string Excluir(object obj);
        public abstract object CarregaTudo();
        public abstract object CarregaObjeto(int codigoObjeto);
    }
}
