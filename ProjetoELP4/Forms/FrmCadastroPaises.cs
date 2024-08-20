using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4 {
    public partial class FrmCadastroPaises : ProjetoELP4.FrmCadastros {

        Paises oPais;

        public FrmCadastroPaises() {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj) {
            oPais = (Paises) obj;
        }

        public override void LimpaTxt() {
            txtCodigo.Clear();
            txtPais.Clear();
            txtSigla.Clear();
            txtDDI.Clear();
            txtMoeda.Clear();
        }

        public override void CarregaTxt() {
            txtCodigo.Text = oPais.Codigo; 
            txtPais.Text = oPais.Pais;
            txtSigla.Text = oPais.Sigla;
            txtDDI.Text = oPais.DDI;
            txtMoeda.Text = oPais.Moeda;
        }

        public override void BloqueiaTxt() {
            txtCodigo.Enabled = false;
            txtPais.Enabled = false;
            txtSigla.Enabled = false;   
            txtDDI.Enabled = false;
            txtMoeda.Enabled = false;
        }

        public override void DesbloqueiaTxt() {
            txtCodigo.Enabled = true;
            txtPais.Enabled = true;
            txtSigla.Enabled = true;
            txtDDI.Enabled = true;
            txtMoeda.Enabled = true;
        }

        public override void Salvar() {
            base.Salvar();
            oPais.Codigo = txtCodigo.Text;
            oPais.Pais = txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.DDI = txtDDI.Text;
            oPais.Moeda = txtMoeda.Text;
        }

    }
}
