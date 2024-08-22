using ProjetoELP4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
    internal class Cidades : Pai {

        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

        public Cidades() : base() {
            cidade = "";
            ddd = "";
            oEstado = new Estados();
        }

        public Cidades(int codigo, string cidade, string ddd, Estados oEstado) : base(codigo, "", "", 0) {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado;
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
