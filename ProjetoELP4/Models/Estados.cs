﻿using ProjetoELP4.Models;

namespace ProjetoELP4 {
	internal class Estados : Pai {

        protected string estado;
        protected string uf;
        protected Paises oPais;

        public Estados() : base() {
            estado = "";
            uf = "";
            oPais = new Paises();
        }

        public Estados(int codigo, string estado, string uf, Paises oPais) : base(codigo, "", "", 0) {
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais;
        }

        public string Estado {
            get => estado;
            set => estado = value;
        }
        public string UF {
            get => uf;
            set => uf = value;
        }
        public Paises OPais {
            get => oPais;
            set => oPais = value;
        }
    }

}
