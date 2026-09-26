namespace EventControlSystem.Eventos
{
    partial class Frm_Cadastrar_Temporada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelNomeEvento = new System.Windows.Forms.Label();
            this.NomeEventoText = new System.Windows.Forms.TextBox();
            this.LabelEntrada = new System.Windows.Forms.Label();
            this.EntradaText = new System.Windows.Forms.MaskedTextBox();
            this.LabelSaida = new System.Windows.Forms.Label();
            this.SaidaText = new System.Windows.Forms.MaskedTextBox();
            this.LabelHoras = new System.Windows.Forms.Label();
            this.HorasText = new System.Windows.Forms.MaskedTextBox();
            this.GridEventos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.DescricaoText = new System.Windows.Forms.TextBox();
            this.ButtonAdicionar = new System.Windows.Forms.Button();
            this.LabelDataInicio = new System.Windows.Forms.Label();
            this.DataInicioText = new System.Windows.Forms.MaskedTextBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.DropCetificado = new System.Windows.Forms.ComboBox();
            this.LabelCertificado = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(564, 38);
            this.PanelTitle.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(564, 38);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Cadastar Nova Temporada";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNomeEvento
            // 
            this.LabelNomeEvento.AutoSize = true;
            this.LabelNomeEvento.Location = new System.Drawing.Point(9, 47);
            this.LabelNomeEvento.Name = "LabelNomeEvento";
            this.LabelNomeEvento.Size = new System.Drawing.Size(130, 13);
            this.LabelNomeEvento.TabIndex = 1;
            this.LabelNomeEvento.Text = "Nome da  Temporada";
            // 
            // NomeEventoText
            // 
            this.NomeEventoText.Location = new System.Drawing.Point(12, 63);
            this.NomeEventoText.Name = "NomeEventoText";
            this.NomeEventoText.Size = new System.Drawing.Size(295, 21);
            this.NomeEventoText.TabIndex = 0;
            // 
            // LabelEntrada
            // 
            this.LabelEntrada.AutoSize = true;
            this.LabelEntrada.Location = new System.Drawing.Point(189, 96);
            this.LabelEntrada.Name = "LabelEntrada";
            this.LabelEntrada.Size = new System.Drawing.Size(51, 13);
            this.LabelEntrada.TabIndex = 1;
            this.LabelEntrada.Text = "Entrada";
            // 
            // EntradaText
            // 
            this.EntradaText.Location = new System.Drawing.Point(192, 112);
            this.EntradaText.Mask = "00/00/0000 90:00";
            this.EntradaText.Name = "EntradaText";
            this.EntradaText.Size = new System.Drawing.Size(115, 21);
            this.EntradaText.TabIndex = 4;
            this.EntradaText.ValidatingType = typeof(System.DateTime);
            // 
            // LabelSaida
            // 
            this.LabelSaida.AutoSize = true;
            this.LabelSaida.Location = new System.Drawing.Point(310, 96);
            this.LabelSaida.Name = "LabelSaida";
            this.LabelSaida.Size = new System.Drawing.Size(39, 13);
            this.LabelSaida.TabIndex = 1;
            this.LabelSaida.Text = "Saida";
            // 
            // SaidaText
            // 
            this.SaidaText.Location = new System.Drawing.Point(313, 112);
            this.SaidaText.Mask = "00/00/0000 90:00";
            this.SaidaText.Name = "SaidaText";
            this.SaidaText.Size = new System.Drawing.Size(115, 21);
            this.SaidaText.TabIndex = 5;
            this.SaidaText.ValidatingType = typeof(System.DateTime);
            // 
            // LabelHoras
            // 
            this.LabelHoras.AutoSize = true;
            this.LabelHoras.Location = new System.Drawing.Point(431, 96);
            this.LabelHoras.Name = "LabelHoras";
            this.LabelHoras.Size = new System.Drawing.Size(40, 13);
            this.LabelHoras.TabIndex = 1;
            this.LabelHoras.Text = "Horas";
            // 
            // HorasText
            // 
            this.HorasText.Location = new System.Drawing.Point(434, 112);
            this.HorasText.Mask = "00:00";
            this.HorasText.Name = "HorasText";
            this.HorasText.Size = new System.Drawing.Size(44, 21);
            this.HorasText.TabIndex = 6;
            this.HorasText.ValidatingType = typeof(System.DateTime);
            // 
            // GridEventos
            // 
            this.GridEventos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Entrada,
            this.Saida,
            this.Horas});
            this.GridEventos.Location = new System.Drawing.Point(12, 139);
            this.GridEventos.MultiSelect = false;
            this.GridEventos.Name = "GridEventos";
            this.GridEventos.ReadOnly = true;
            this.GridEventos.RowHeadersWidth = 4;
            this.GridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEventos.Size = new System.Drawing.Size(539, 170);
            this.GridEventos.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 170;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Entrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Width = 120;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "Saida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Saida.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            this.Saida.Width = 120;
            // 
            // Horas
            // 
            this.Horas.DataPropertyName = "Horas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Horas.DefaultCellStyle = dataGridViewCellStyle4;
            this.Horas.HeaderText = "Horas ACC";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 120;
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Location = new System.Drawing.Point(9, 96);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(101, 13);
            this.LabelDescricao.TabIndex = 1;
            this.LabelDescricao.Text = "Nome do Evento";
            // 
            // DescricaoText
            // 
            this.DescricaoText.Location = new System.Drawing.Point(12, 112);
            this.DescricaoText.Name = "DescricaoText";
            this.DescricaoText.Size = new System.Drawing.Size(174, 21);
            this.DescricaoText.TabIndex = 3;
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionar.Location = new System.Drawing.Point(484, 110);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(67, 23);
            this.ButtonAdicionar.TabIndex = 7;
            this.ButtonAdicionar.Text = "Adicionar";
            this.ButtonAdicionar.UseVisualStyleBackColor = true;
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // LabelDataInicio
            // 
            this.LabelDataInicio.AutoSize = true;
            this.LabelDataInicio.Location = new System.Drawing.Point(433, 47);
            this.LabelDataInicio.Name = "LabelDataInicio";
            this.LabelDataInicio.Size = new System.Drawing.Size(87, 13);
            this.LabelDataInicio.TabIndex = 1;
            this.LabelDataInicio.Text = "Data de Inicio";
            // 
            // DataInicioText
            // 
            this.DataInicioText.Location = new System.Drawing.Point(436, 63);
            this.DataInicioText.Mask = "00/00/0000";
            this.DataInicioText.Name = "DataInicioText";
            this.DataInicioText.Size = new System.Drawing.Size(115, 21);
            this.DataInicioText.TabIndex = 2;
            this.DataInicioText.ValidatingType = typeof(System.DateTime);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastrar.Image = global::EventControlSystem.Properties.Resources.Gravar;
            this.ButtonCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCadastrar.Location = new System.Drawing.Point(450, 315);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(100, 25);
            this.ButtonCadastrar.TabIndex = 8;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // DropCetificado
            // 
            this.DropCetificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropCetificado.FormattingEnabled = true;
            this.DropCetificado.Items.AddRange(new object[] {
            "CREA JR",
            "SEMEA"});
            this.DropCetificado.Location = new System.Drawing.Point(313, 63);
            this.DropCetificado.Name = "DropCetificado";
            this.DropCetificado.Size = new System.Drawing.Size(115, 21);
            this.DropCetificado.TabIndex = 1;
            // 
            // LabelCertificado
            // 
            this.LabelCertificado.AutoSize = true;
            this.LabelCertificado.Location = new System.Drawing.Point(310, 47);
            this.LabelCertificado.Name = "LabelCertificado";
            this.LabelCertificado.Size = new System.Drawing.Size(69, 13);
            this.LabelCertificado.TabIndex = 14;
            this.LabelCertificado.Text = "Certificado";
            // 
            // Frm_Cadastrar_Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 351);
            this.Controls.Add(this.DropCetificado);
            this.Controls.Add(this.LabelCertificado);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.ButtonAdicionar);
            this.Controls.Add(this.GridEventos);
            this.Controls.Add(this.HorasText);
            this.Controls.Add(this.SaidaText);
            this.Controls.Add(this.LabelHoras);
            this.Controls.Add(this.DataInicioText);
            this.Controls.Add(this.EntradaText);
            this.Controls.Add(this.LabelSaida);
            this.Controls.Add(this.LabelDataInicio);
            this.Controls.Add(this.LabelEntrada);
            this.Controls.Add(this.DescricaoText);
            this.Controls.Add(this.LabelDescricao);
            this.Controls.Add(this.NomeEventoText);
            this.Controls.Add(this.LabelNomeEvento);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastrar_Temporada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporada";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Evento_Load);
            this.PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelNomeEvento;
        private System.Windows.Forms.TextBox NomeEventoText;
        private System.Windows.Forms.Label LabelEntrada;
        private System.Windows.Forms.MaskedTextBox EntradaText;
        private System.Windows.Forms.Label LabelSaida;
        private System.Windows.Forms.MaskedTextBox SaidaText;
        private System.Windows.Forms.Label LabelHoras;
        private System.Windows.Forms.MaskedTextBox HorasText;
        private System.Windows.Forms.DataGridView GridEventos;
        private System.Windows.Forms.Label LabelDescricao;
        private System.Windows.Forms.TextBox DescricaoText;
        private System.Windows.Forms.Button ButtonAdicionar;
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Label LabelDataInicio;
        private System.Windows.Forms.MaskedTextBox DataInicioText;
        private System.Windows.Forms.ComboBox DropCetificado;
        private System.Windows.Forms.Label LabelCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
    }
}