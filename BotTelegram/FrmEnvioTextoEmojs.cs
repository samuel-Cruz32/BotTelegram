using System;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegram
{
    public partial class FrmEnvioTextoEmojs : Form
    {
        public FrmEnvioTextoEmojs()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
                {
                MessageBox.Show("Informe a Mensagem para Envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                 }
            try
            {
                var telegramBot = new TelegramBotClient("913963364:AAFPUirdKySVUUsodnky9Im2VCXYiXr_yIs");
                var strMensagem = txtMensagem.Text.Trim();

                if (strMensagem.Contains(":white_check_mark:"))
                    strMensagem = strMensagem.Replace(":white_check_mark:", Char.ConvertFromUtf32(0x2705));
                if (strMensagem.Contains(":smile:"))
                    strMensagem = strMensagem.Replace(":smile:", Char.ConvertFromUtf32(0x1F604));
                await telegramBot.SendTextMessageAsync(chatId: "-1001278825026", text: strMensagem, parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem Enviada com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Enviar Mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }
        }
    }
}
