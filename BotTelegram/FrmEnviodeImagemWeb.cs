using System;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegram
{
    public partial class FrmEnviodeImagemWeb : Form
    {
        public FrmEnviodeImagemWeb()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da Imagem para Envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("913963364:AAFPUirdKySVUUsodnky9Im2VCXYiXr_yIs");
                var imagemRequest = WebRequest.Create(txtURL.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();

                    await telegramBot.SendPhotoAsync(chatId: "-1001278825026", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }
                MessageBox.Show("Mensagem Enviada com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Enviar Mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtURL.Text = string.Empty;
            }
        }
    }
    
}
