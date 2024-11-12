using ProjetoELP4.Models;
using System;
using System.Data.SqlClient;

namespace ProjetoELP4.Data {
    internal class DAOEstados : DAO {
        public override object CarregaObjeto(int codigoObjeto) {
            string query =
                "SELECT e.CodigoEstado, e.Estado, e.UF, p.CodigoPais, p.Pais, p.Sigla, p.DDI, p.Moeda " +
                "FROM Estados as e " +
                "INNER JOIN Paises as p " +
                "ON e.CodigoPais = p.CodigoPais" +
                "WHERE e.CodigoEstado = @codigo";


            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@codigo", codigoObjeto);

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.Read()) {
                    return null;
                }

                int codigo = reader.GetInt32(reader.GetOrdinal("CodigoEstado"));
                string estado = reader.GetString(reader.GetOrdinal("Estado"));
                string uf = reader.GetString(reader.GetOrdinal("DDI"));

                int codigoPais = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                string pais = reader.GetString(reader.GetOrdinal("Pais"));
                string ddi = reader.GetString(reader.GetOrdinal("DDI"));
                string sigla = reader.GetString(reader.GetOrdinal("Sigla"));
                string moeda = reader.GetString(reader.GetOrdinal("Moeda"));

                Paises oPais = new Paises(codigoPais, pais, ddi, sigla, moeda);

                return new Estados(codigo, estado, uf, oPais);
            }

        }

        public override object CarregaTudo() {
            string query =
                "SELECT e.CodigoEstado, e.Estado, e.UF, p.CodigoPais, p.Pais, p.Sigla, p.DDI, p.Moeda " +
                "FROM Estados as e " +
                "INNER JOIN Paises as p " +
                "ON e.CodigoPais = p.CodigoPais";

            SqlCommand command = new SqlCommand(query, conn);
            ColecaoEstados colecaoEstados = new ColecaoEstados();

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.HasRows) {
                    return null;
                }

                while (reader.Read()) {
                    int codigo = reader.GetInt32(reader.GetOrdinal("CodigoEstado"));
                    string estado = reader.GetString(reader.GetOrdinal("Estado"));
                    string uf = reader.GetString(reader.GetOrdinal("DDI"));

                    int codigoPais = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                    string pais = reader.GetString(reader.GetOrdinal("Pais"));
                    string ddi = reader.GetString(reader.GetOrdinal("DDI"));
                    string sigla = reader.GetString(reader.GetOrdinal("Sigla"));
                    string moeda = reader.GetString(reader.GetOrdinal("Moeda"));

                    Paises oPais = new Paises(codigoPais, pais, ddi, sigla, moeda);

                    Estados oEstado = new Estados(codigo, estado, uf, oPais);

                    colecaoEstados.Inserir(oEstado);
                }

                return colecaoEstados;
            }

        }

        public override string Excluir(object obj) {
            throw new NotImplementedException();
        }

        public override string Salvar(object obj) {
            throw new NotImplementedException();
        }
    }
}
