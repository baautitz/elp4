﻿using ProjetoELP4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4 {
    internal class Paises : Pai {

        protected string pais;
        protected string ddi;
        protected string sigla;
        protected string moeda;

        public Paises() : base () {
            pais = "";
            ddi = "";
            sigla = "";
            moeda = "";
        }

        public Paises(int codigo, string pais, string ddi, string sigla, string moeda) : base(codigo, "", "", 0) {
            this.pais = pais;
            this.ddi = ddi;
            this.sigla = sigla;
            this.moeda = moeda;
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