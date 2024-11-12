using ProjetoELP4.Models;
using System;
using System.Data.SqlClient;

namespace ProjetoELP4.Data {
    internal class DAOCidades : DAO {
        public override object CarregaObjeto(int codigoObjeto) {
            string query =
                "SELECT c.CodigoCidade, c.Cidade, c.DDD, e.CodigoEstado, e.Estado, e.UF, p.CodigoPais, p.Pais, p.Sigla, p.DDI, p.Moeda " +
                "FROM Cidades as c " +
                "INNER JOIN Estados as e " +
                "ON c.CodigoEstado = e.CodigoEstado " +
                "INNER JOIN Paises as p " +
                "ON p.CodigoPais = e.CodigoPais " +
                "WHERE CodigoCidade = @codigo";
                
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@codigo", codigoObjeto);

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.Read()) {
                    return null;
                }

                int codigo = reader.GetInt32(reader.GetOrdinal("CodigoCidade"));
                string cidade = reader.GetString(reader.GetOrdinal("Cidade"));
                string ddd = reader.GetString(reader.GetOrdinal("DDD"));

                int codigoEstado = reader.GetInt32(reader.GetOrdinal("CodigoEstado"));
                string estado = reader.GetString(reader.GetOrdinal("Estado"));
                string uf = reader.GetString(reader.GetOrdinal("DDI"));

                int codigoPais = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                string pais = reader.GetString(reader.GetOrdinal("Pais"));
                string ddi = reader.GetString(reader.GetOrdinal("DDI"));
                string sigla = reader.GetString(reader.GetOrdinal("Sigla"));
                string moeda = reader.GetString(reader.GetOrdinal("Moeda"));

                Paises oPais = new Paises(codigoPais, pais, ddi, sigla, moeda);
                Estados oEstado = new Estados(codigo, estado, uf, oPais);

                return new Cidades(codigo, cidade, ddd, oEstado);
            }

        }

        public override object CarregaTudo() {
            string query =
                "SELECT c.CodigoCidade, c.Cidade, c.DDD, e.CodigoEstado, e.Estado, e.UF, p.CodigoPais, p.Pais, p.Sigla, p.DDI, p.Moeda " +
                "FROM Cidades as c " +
                "INNER JOIN Estados as e " +
                "ON c.CodigoEstado = e.CodigoEstado " +
                "INNER JOIN Paises as p " +
                "ON p.CodigoPais = e.CodigoPais";

            SqlCommand command = new SqlCommand(query, conn);
            ColecaoCidades colecaoCidades = new ColecaoCidades();

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.HasRows) {
                    return null;
                }

                while (reader.Read()) {
                    int codigo = reader.GetInt32(reader.GetOrdinal("CodigoCidade"));
                    string cidade = reader.GetString(reader.GetOrdinal("Cidade"));
                    string ddd = reader.GetString(reader.GetOrdinal("DDD"));

                    int codigoEstado = reader.GetInt32(reader.GetOrdinal("CodigoEstado"));
                    string estado = reader.GetString(reader.GetOrdinal("Estado"));
                    string uf = reader.GetString(reader.GetOrdinal("DDI"));

                    int codigoPais = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                    string pais = reader.GetString(reader.GetOrdinal("Pais"));
                    string ddi = reader.GetString(reader.GetOrdinal("DDI"));
                    string sigla = reader.GetString(reader.GetOrdinal("Sigla"));
                    string moeda = reader.GetString(reader.GetOrdinal("Moeda"));

                    Paises oPais = new Paises(codigoPais, pais, ddi, sigla, moeda);
                    Estados oEstado = new Estados(codigoEstado, estado, uf, oPais);
                    Cidades aCidade = new Cidades(codigo, cidade, ddd, oEstado);

                    colecaoCidades.Inserir(aCidade);
                }

                return colecaoCidades;
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
