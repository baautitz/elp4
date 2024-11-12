using ProjetoELP4.Models;
using System;
using System.Data.SqlClient;

namespace ProjetoELP4.Data {
    internal class DAOPaises : DAO {
        public override object CarregaObjeto(int codigoObjeto) {
            string query = "SELECT codigo, pais, ddi, sigla, moeda FROM Paises WHERE codigo = @codigo";


            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@codigo", codigoObjeto);

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.Read()) {
                    return null;
                }

                int codigo = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                string pais = reader.GetString(reader.GetOrdinal("pais"));
                string ddi = reader.GetString(reader.GetOrdinal("ddi"));
                string sigla = reader.GetString(reader.GetOrdinal("sigla"));
                string moeda = reader.GetString(reader.GetOrdinal("moeda"));

                return new Paises(codigo, pais, ddi, sigla, moeda);
            }

        }

        public override object CarregaTudo() {
            string query = "SELECT CodigoPais, Pais, DDI, Sigla, Moeda FROM Paises";

            SqlCommand command = new SqlCommand(query, conn);
            ColecaoPaises colecaoPaises = new ColecaoPaises();

            using (SqlDataReader reader = command.ExecuteReader()) {
                if (!reader.HasRows) {
                    return null;
                }

                while (reader.Read()) {
                    int codigo = reader.GetInt32(reader.GetOrdinal("CodigoPais"));
                    string pais = reader.GetString(reader.GetOrdinal("Pais"));
                    string ddi = reader.GetString(reader.GetOrdinal("DDI"));
                    string sigla = reader.GetString(reader.GetOrdinal("Sigla"));
                    string moeda = reader.GetString(reader.GetOrdinal("Moeda"));

                    Paises oPais = new Paises(codigo, pais, ddi, sigla, moeda);

                    colecaoPaises.Inserir(oPais);
                }

                return colecaoPaises;
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
