namespace BotTelegram
{
    partial class FrmEnviodeImagemdoComputador
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
            this.txtCaminhodaImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnBuscarImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatAppearance.BorderSize = 3;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(414, 303);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 38);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtCaminhodaImagem
            // 
            this.txtCaminhodaImagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtCaminhodaImagem.Enabled = false;
            this.txtCaminhodaImagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhodaImagem.Location = new System.Drawing.Point(40, 267);
            this.txtCaminhodaImagem.Multiline = true;
            this.txtCaminhodaImagem.Name = "txtCaminhodaImagem";
            this.txtCaminhodaImagem.Size = new System.Drawing.Size(423, 30);
            this.txtCaminhodaImagem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho da Imagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(40, 67);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(494, 149);
            this.txtMensagem.TabIndex = 6;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(36, 45);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(92, 19);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Mensagem";
            // 
            // btnBuscarImagem
            // 
            this.btnBuscarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarImagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarImagem.FlatAppearance.BorderSize = 3;
            this.btnBuscarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBuscarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarImagem.Location = new System.Drawing.Point(469, 267);
            this.btnBuscarImagem.Name = "btnBuscarImagem";
            this.btnBuscarImagem.Size = new System.Drawing.Size(65, 30);
            this.btnBuscarImagem.TabIndex = 7;
            this.btnBuscarImagem.Text = "...";
            this.btnBuscarImagem.UseVisualStyleBackColor = true;
            this.btnBuscarImagem.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmEnviodeImagemdoComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 364);
            this.Controls.Add(this.btnBuscarImagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCaminhodaImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnviodeImagemdoComputador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Imagem do Computador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtCaminhodaImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnBuscarImagem;
    }
}