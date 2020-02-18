using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegram
{
    public partial class FrmEnviodeImagemdoComputador : Form
    {
        public FrmEnviodeImagemdoComputador()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        private Stream ToStream(Image image, ImageFormat formato)
            {
            var stream = new MemoryStream();
            image.Save(stream, formato);
            stream.Position = 0;
            return stream;

            }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\Imagens\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                    txtCaminhodaImagem.Text = ofd.FileName;            

            }
        }

        private async void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (txtCaminhodaImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve Selecionar a Imagem para o Envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("913963364:AAFPUirdKySVUUsodnky9Im2VCXYiXr_yIs");
               

                using (var imgEnvio = Image.FromFile(txtCaminhodaImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Jpeg);

                    await telegramBot.SendPhotoAsync(chatId: "-1001278825026", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }
                MessageBox.Show("Mensagem Enviada com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Enviar Mensagem!"+ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtCaminhodaImagem.Text = string.Empty;
            }
        }
    }
}
