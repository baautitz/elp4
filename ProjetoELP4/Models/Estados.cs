using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
    internal class Estados {

        protected string codigo;
        protected string estado;
        protected string uf;
        protected Paises oPais;

        public Estados() {
            codigo = "";
            estado = "";
            uf = "";
            oPais = new Paises();
        }

        public Estados(string codigo, string estado, string uf, Paises oPais) {
            this.codigo = codigo;
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais;
        }

        public string Codigo {
            get => codigo;
            set => codigo = value;
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
