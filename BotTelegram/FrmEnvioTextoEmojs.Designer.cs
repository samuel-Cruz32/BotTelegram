namespace BotTelegram
{
    partial class FrmEnvioTextoEmojs
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 3;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(387, 171);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 32);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMensagem.Location = new System.Drawing.Point(12, 54);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(480, 102);
            this.txtMensagem.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(12, 23);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(92, 19);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem";
            // 
            // FrmEnvioTextoEmojs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 220);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnEnviar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioTextoEmojs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem de Texto com Emojs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
    }
}