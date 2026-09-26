namespace EventControlSystem
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.MenuHeader = new System.Windows.Forms.MenuStrip();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.FooterContainer = new System.Windows.Forms.SplitContainer();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.SenhaText = new System.Windows.Forms.MaskedTextBox();
            this.LoginText = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelAutenticacao = new System.Windows.Forms.Label();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FooterContainer)).BeginInit();
            this.FooterContainer.Panel1.SuspendLayout();
            this.FooterContainer.Panel2.SuspendLayout();
            this.FooterContainer.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuHeader
            // 
            this.MenuHeader.BackColor = System.Drawing.SystemColors.Control;
            this.MenuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.checkinToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.MenuHeader.Location = new System.Drawing.Point(0, 0);
            this.MenuHeader.Name = "MenuHeader";
            this.MenuHeader.Size = new System.Drawing.Size(976, 24);
            this.MenuHeader.TabIndex = 2;
            this.MenuHeader.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEventoToolStripMenuItem,
            this.editarEventoToolStripMenuItem,
            this.acessarEventoToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // cadastrarEventoToolStripMenuItem
            // 
            this.cadastrarEventoToolStripMenuItem.Name = "cadastrarEventoToolStripMenuItem";
            this.cadastrarEventoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cadastrarEventoToolStripMenuItem.Text = "Cadastrar Evento";
            this.cadastrarEventoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEventoToolStripMenuItem_Click);
            // 
            // editarEventoToolStripMenuItem
            // 
            this.editarEventoToolStripMenuItem.Name = "editarEventoToolStripMenuItem";
            this.editarEventoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editarEventoToolStripMenuItem.Text = "Editar Evento";
            this.editarEventoToolStripMenuItem.Click += new System.EventHandler(this.editarEventoToolStripMenuItem_Click);
            // 
            // acessarEventoToolStripMenuItem
            // 
            this.acessarEventoToolStripMenuItem.Name = "acessarEventoToolStripMenuItem";
            this.acessarEventoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.acessarEventoToolStripMenuItem.Text = "Acessar Evento";
            this.acessarEventoToolStripMenuItem.Click += new System.EventHandler(this.acessarEventoToolStripMenuItem_Click);
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Visible = false;
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 120000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // FooterContainer
            // 
            this.FooterContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterContainer.Location = new System.Drawing.Point(0, 504);
            this.FooterContainer.Name = "FooterContainer";
            // 
            // FooterContainer.Panel1
            // 
            this.FooterContainer.Panel1.Controls.Add(this.LabelNome);
            // 
            // FooterContainer.Panel2
            // 
            this.FooterContainer.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FooterContainer.Panel2.Controls.Add(this.LabelStatus);
            this.FooterContainer.Size = new System.Drawing.Size(976, 25);
            this.FooterContainer.SplitterDistance = 320;
            this.FooterContainer.TabIndex = 6;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(3, 6);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelNome.Size = new System.Drawing.Size(35, 12);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "label1";
            this.LabelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.Color.Green;
            this.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelStatus.Location = new System.Drawing.Point(636, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(32, 25);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "On";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelLogin.Controls.Add(this.SenhaText);
            this.PanelLogin.Controls.Add(this.LoginText);
            this.PanelLogin.Controls.Add(this.panel2);
            this.PanelLogin.Controls.Add(this.ButtonSair);
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Controls.Add(this.LabelSenha);
            this.PanelLogin.Controls.Add(this.LabelUsuario);
            this.PanelLogin.Location = new System.Drawing.Point(394, 142);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(224, 215);
            this.PanelLogin.TabIndex = 7;
            // 
            // SenhaText
            // 
            this.SenhaText.Cursor = System.Windows.Forms.Cursors.Default;
            this.SenhaText.ForeColor = System.Drawing.Color.DimGray;
            this.SenhaText.Location = new System.Drawing.Point(38, 115);
            this.SenhaText.Name = "SenhaText";
            this.SenhaText.PasswordChar = '*';
            this.SenhaText.Size = new System.Drawing.Size(148, 21);
            this.SenhaText.TabIndex = 1;
            this.SenhaText.Text = "Senha";
            this.SenhaText.UseSystemPasswordChar = true;
            this.SenhaText.Enter += new System.EventHandler(this.SenhaText_Enter);
            this.SenhaText.Leave += new System.EventHandler(this.SenhaText_Leave);
            // 
            // LoginText
            // 
            this.LoginText.ForeColor = System.Drawing.Color.DimGray;
            this.LoginText.Location = new System.Drawing.Point(38, 75);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(147, 21);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "Usuario";
            this.LoginText.Enter += new System.EventHandler(this.LoginText_Enter);
            this.LoginText.Leave += new System.EventHandler(this.LoginText_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.LabelAutenticacao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 39);
            this.panel2.TabIndex = 3;
            // 
            // LabelAutenticacao
            // 
            this.LabelAutenticacao.AutoSize = true;
            this.LabelAutenticacao.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAutenticacao.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelAutenticacao.Location = new System.Drawing.Point(29, 7);
            this.LabelAutenticacao.Name = "LabelAutenticacao";
            this.LabelAutenticacao.Size = new System.Drawing.Size(152, 23);
            this.LabelAutenticacao.TabIndex = 0;
            this.LabelAutenticacao.Text = "Autenticação";
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(39, 142);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(147, 26);
            this.ButtonSair.TabIndex = 3;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonLogin.Location = new System.Drawing.Point(39, 174);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(147, 26);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Entrar";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Location = new System.Drawing.Point(35, 99);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(43, 13);
            this.LabelSenha.TabIndex = 0;
            this.LabelSenha.Text = "Senha";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(35, 60);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(50, 13);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "Usuario";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelPrincipal.BackgroundImage = global::EventControlSystem.Properties.Resources.logo_3;
            this.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 24);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(976, 480);
            this.PanelPrincipal.TabIndex = 10;
            this.PanelPrincipal.Visible = false;
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.checkinToolStripMenuItem.Text = "Checkin";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(976, 529);
            this.ControlBox = false;
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.FooterContainer);
            this.Controls.Add(this.MenuHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Control System";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.MenuHeader.ResumeLayout(false);
            this.MenuHeader.PerformLayout();
            this.FooterContainer.Panel1.ResumeLayout(false);
            this.FooterContainer.Panel1.PerformLayout();
            this.FooterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FooterContainer)).EndInit();
            this.FooterContainer.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuHeader;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarEventoToolStripMenuItem;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.SplitContainer FooterContainer;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.MaskedTextBox SenhaText;
        private System.Windows.Forms.MaskedTextBox LoginText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelAutenticacao;
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem editarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
    }
}

