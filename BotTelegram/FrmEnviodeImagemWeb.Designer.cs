namespace BotTelegram
{
    partial class FrmEnviodeImagemWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(36, 31);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(92, 19);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(40, 53);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(426, 112);
            this.txtMensagem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL da Imagem";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Info;
            this.txtURL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(40, 218);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(426, 29);
            this.txtURL.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatAppearance.BorderSize = 3;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(346, 253);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 38);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmEnviodeImagemWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnviodeImagemWeb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem com Imagem da Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnEnviar;
    }
}