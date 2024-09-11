using System;


namespace ProjetoELP4.Forms {
    public partial class FrmCadastroCidades : ProjetoELP4.FrmCadastros {

        Cidades aCidade;
        FrmConsultaEstados oFrmConsultaEstados;

        public FrmCadastroCidades() {
            InitializeComponent();
        }
        public override void ConhecaObjeto(object obj) {
            aCidade = (Cidades) obj;
        }

        public void SetFrmConsultaEstados(object obj) {
            oFrmConsultaEstados = (FrmConsultaEstados) obj;
        }

        public override void LimpaTxt() {
            txtCodigo.Clear();
            txtCidade.Clear();
            txtDDD.Clear();
            txtCodigoEstado.Clear();
            txtEstado.Clear();
        }

        public override void CarregaTxt() {
            txtCodigo.Text = aCidade.Codigo.ToString();
            txtCidade.Text = aCidade.Cidade;
            txtDDD.Text = aCidade.DDD;
            txtCodigoEstado.Text = aCidade.OEstado.Codigo.ToString();
            txtEstado.Text = aCidade.OEstado.Estado;
        }

        public override void BloqueiaTxt() {
            txtCodigo.Enabled = false;
            txtCidade.Enabled = false;
            txtDDD.Enabled = false;
            txtCodigoEstado.Enabled = false;
            txtEstado.Enabled = false;
            btnConsultaEstados.Enabled = false;
        }

        public override void DesbloqueiaTxt() {
            txtCodigo.Enabled = true;
            txtCidade.Enabled = true;
            txtDDD.Enabled = true;
            txtCodigoEstado.Enabled = true;
            txtEstado.Enabled = true;
            btnConsultaEstados.Enabled = true;
        }

        public override void Salvar() {
            base.Salvar();

            int codigo = 0;
            int.TryParse(txtCodigo.Text, out codigo);

            aCidade.Codigo = codigo;
            aCidade.Cidade = txtCidade.Text;
            aCidade.DDD = txtDDD.Text;
        }

        private void btnConsultaEstados_Click(object sender, EventArgs e) {
            oFrmConsultaEstados.ConhecaObjeto(aCidade.OEstado);
            oFrmConsultaEstados.ShowDialog();
            txtCodigoEstado.Text = aCidade.OEstado.Codigo.ToString();
            txtEstado.Text = aCidade.OEstado.Estado;
        }
    }
}
