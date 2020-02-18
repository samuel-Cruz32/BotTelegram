using System;
using System.Windows.Forms;


namespace BotTelegram
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach  (Control controle in this.Controls)
            {
                if(controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.fondo_azul_degradado_oscuro_1258_1365;
                    break;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envioDeMensagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EnviodeTexto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemDaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnviodeImagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnviodeImagemdoComputador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMensagemComEmogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTextoEmojs();
            frm.MdiParent = this;
            frm.Show();

        }

        private void HoraData_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }
    }
}
