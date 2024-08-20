using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
    internal class Paises {

        protected string codigo;
        protected string pais;
        protected string ddi;
        protected string sigla;
        protected string moeda;

        public Paises() {
            codigo = "";
            pais = "";
            ddi = "";
            sigla = "";
            moeda = "";
        }

        public Paises(string codigo, string pais, string ddi, string sigla, string moeda) {
            this.codigo = codigo;
            this.pais = pais;
            this.ddi = ddi;
            this.sigla = sigla;
            this.moeda = moeda;
        }

        public string Codigo { 
            get => codigo; 
            set => codigo = value; 
        }
        public string Pais { 
            get => pais; 
            set => pais = value; 
        }
        public string DDI { 
            get => ddi; 
            set => ddi = value; 
        }
        public string Sigla { 
            get => sigla; 
            set => sigla = value; 
        }
        public string Moeda { 
            get => moeda; 
            set => moeda = value; 
        }
    }
}
