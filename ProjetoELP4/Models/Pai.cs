﻿namespace ProjetoELP4.Models {
	internal class Pai {

        protected int codigo;
        protected string dataCadastro;
        protected string dataUltimaAtt;
        protected int codigoUsuario;

        public Pai(int codigo, string dataCadastro, string dataUltimaAtt, int codigoUsuario) {
            this.codigo = codigo;
            this.dataCadastro = dataCadastro;
            this.dataUltimaAtt = dataUltimaAtt;
            this.codigoUsuario = codigoUsuario;
        }

        public Pai() {
            codigo = 0;
            dataCadastro = "";
            dataUltimaAtt = "";
        }

        public int Codigo {
            get => codigo;
            set => codigo = value;
        }
        public string DataCadastro {
            get => dataCadastro;
            set => dataCadastro = value;
        }
        public string DataUltimaAtt {
            get => dataUltimaAtt;
            set => dataUltimaAtt = value;
        }
        public int CodigoUsuario {
            get => codigoUsuario;
            set => codigoUsuario = value;
        }

    }
}
