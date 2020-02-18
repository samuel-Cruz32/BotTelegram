namespace BotTelegram
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComEmogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.HoraData = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.enviarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.enviarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioDeMensagemSimplesToolStripMenuItem,
            this.envioDeMensagemComImagemToolStripMenuItem,
            this.envioDeMensagemComEmogToolStripMenuItem,
            this.envioDeMensagemComTemporizadorToolStripMenuItem});
            this.enviarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.enviarToolStripMenuItem.Text = "Enviar";
            // 
            // envioDeMensagemSimplesToolStripMenuItem
            // 
            this.envioDeMensagemSimplesToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.envioDeMensagemSimplesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.envioDeMensagemSimplesToolStripMenuItem.Name = "envioDeMensagemSimplesToolStripMenuItem";
            this.envioDeMensagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(448, 26);
            this.envioDeMensagemSimplesToolStripMenuItem.Text = "Envio de Mensagem Simples";
            this.envioDeMensagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemSimplesToolStripMenuItem_Click);
            // 
            // envioDeMensagemComImagemToolStripMenuItem
            // 
            this.envioDeMensagemComImagemToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.envioDeMensagemComImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDaWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.envioDeMensagemComImagemToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.envioDeMensagemComImagemToolStripMenuItem.Name = "envioDeMensagemComImagemToolStripMenuItem";
            this.envioDeMensagemComImagemToolStripMenuItem.Size = new System.Drawing.Size(448, 26);
            this.envioDeMensagemComImagemToolStripMenuItem.Text = "Envio de Mensagem com Imagem";
            // 
            // imagemDaWebToolStripMenuItem
            // 
            this.imagemDaWebToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.imagemDaWebToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagemDaWebToolStripMenuItem.Name = "imagemDaWebToolStripMenuItem";
            this.imagemDaWebToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.imagemDaWebToolStripMenuItem.Text = "Imagem da Web";
            this.imagemDaWebToolStripMenuItem.Click += new System.EventHandler(this.imagemDaWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.imagemLocalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.imagemLocalToolStripMenuItem.Text = "Imagem Local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // envioDeMensagemComEmogToolStripMenuItem
            // 
            this.envioDeMensagemComEmogToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.envioDeMensagemComEmogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.envioDeMensagemComEmogToolStripMenuItem.Name = "envioDeMensagemComEmogToolStripMenuItem";
            this.envioDeMensagemComEmogToolStripMenuItem.Size = new System.Drawing.Size(448, 26);
            this.envioDeMensagemComEmogToolStripMenuItem.Text = "Envio de Mensagem com Emojs";
            this.envioDeMensagemComEmogToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemComEmogToolStripMenuItem_Click);
            // 
            // envioDeMensagemComTemporizadorToolStripMenuItem
            // 
            this.envioDeMensagemComTemporizadorToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.envioDeMensagemComTemporizadorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Name = "envioDeMensagemComTemporizadorToolStripMenuItem";
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(448, 26);
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Text = "Envio de Mensagem com Temporizador";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHora.Location = new System.Drawing.Point(592, 96);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(111, 46);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.HoraData_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblData.Location = new System.Drawing.Point(430, 51);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(87, 37);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // HoraData
            // 
            this.HoraData.Enabled = true;
            this.HoraData.Tick += new System.EventHandler(this.HoraData_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Bot Telegram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDaWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComEmogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComTemporizadorToolStripMenuItem;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer HoraData;
    }
}

