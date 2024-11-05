using ProjetoELP4.Controllers;
using System;

namespace ProjetoELP4.Forms {
    public partial class FrmCadastroEstados : FrmCadastros {

        Estados oEstado;
        FrmConsultaPaises oFrmConsultaPaises;
        ControllerEstados aControllerEstados;

        public FrmCadastroEstados() {
            InitializeComponent();
        }
        public override void ConhecaObjeto(object obj) {
            oEstado = (Estados) obj;
        }

        public void SetFrmConsultaPaises(object obj) {
            oFrmConsultaPaises = (FrmConsultaPaises) obj;
        }

        public override void LimpaTxt() {
            txtCodigo.Clear();
            txtEstado.Clear();
            txtUF.Clear();
            txtCodigoPais.Clear();
            txtPais.Clear();
        }

        public override void CarregaTxt() {
            txtCodigo.Text = oEstado.Codigo.ToString();
            txtEstado.Text = oEstado.Estado;
            txtUF.Text = oEstado.UF;
            txtCodigoPais.Text = oEstado.OPais.Codigo.ToString();
            txtPais.Text = oEstado.OPais.Pais;
        }

        public override void BloqueiaTxt() {
            txtCodigo.Enabled = false;
            txtEstado.Enabled = false;
            txtUF.Enabled = false;
            txtCodigoPais.Enabled = false;
            txtPais.Enabled = false;
            btnConsultaPaises.Enabled = false;
        }

        public override void DesbloqueiaTxt() {
            txtCodigo.Enabled = true;
            txtEstado.Enabled = true;
            txtUF.Enabled = true;
            txtCodigoPais.Enabled = true;
            txtPais.Enabled = true;
            btnConsultaPaises.Enabled = true;
        }

        public override void Salvar() {
            base.Salvar();

            int codigo = 0;
            int.TryParse(txtCodigo.Text, out codigo);

        	oEstado.Codigo = codigo;
            oEstado.Estado = txtEstado.Text;
            oEstado.UF = txtUF.Text;
        }

        private void btnConsultaPaises_Click(object sender, EventArgs e) {
            //oFrmConsultaPaises.ConhecaObjeto(oEstado.OPais);
            oFrmConsultaPaises.ShowDialog();
            txtCodigoPais.Text = oEstado.OPais.Codigo.ToString();
            txtPais.Text = oEstado.OPais.Pais;
        }
    }
}
