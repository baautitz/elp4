using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
    internal class Cidades {

        protected string codigo;
        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

        public Cidades() {
            codigo = "";
            cidade = "";
            ddd = "";
            oEstado = new Estados();
        }

        public Cidades(string codigo, string cidade, string ddd, Estados oEstado) {
            this.codigo = codigo;
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado;
        }

        public string Codigo {
            get => codigo;
            set => codigo = value;
        }
        public string Cidade {
            get => cidade;
            set => cidade = value;
        }
        public string DDD {
            get => ddd;
            set => ddd = value;
        }
        public Estados OEstado {
            get => oEstado;
            set => oEstado = value;
        }
    }

}
