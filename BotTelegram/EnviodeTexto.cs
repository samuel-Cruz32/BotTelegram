using System;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegram
{
    public partial class EnviodeTexto : Form
    {
        public EnviodeTexto()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

       

        private async void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a Mensagem para o Envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("913963364:AAFPUirdKySVUUsodnky9Im2VCXYiXr_yIs");
                await telegramBot.SendTextMessageAsync(chatId: "-1001278825026", text: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem Enviada com Sucesso!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Enviar Mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }
        }
    }
    
}

