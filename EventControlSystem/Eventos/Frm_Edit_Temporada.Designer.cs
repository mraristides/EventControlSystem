namespace EventControlSystem.Eventos
{
    partial class Frm_Edit_Temporada
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
            this.LabelEntrada = new System.Windows.Forms.Label();
            this.EntradaText = new System.Windows.Forms.MaskedTextBox();
            this.LabelSaida = new System.Windows.Forms.Label();
            this.SaidaText = new System.Windows.Forms.MaskedTextBox();
            this.LabelHoras = new System.Windows.Forms.Label();
            this.HorasText = new System.Windows.Forms.MaskedTextBox();
            this.GridEventos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.DescricaoText = new System.Windows.Forms.TextBox();
            this.ButtonAdicionar = new System.Windows.Forms.Button();
            this.DropEventoNome = new System.Windows.Forms.ComboBox();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.DataInicioText = new System.Windows.Forms.MaskedTextBox();
            this.LabelDataInicio = new System.Windows.Forms.Label();
            this.DropCetificado = new System.Windows.Forms.ComboBox();
            this.LabelCertificado = new System.Windows.Forms.Label();
            this.ButtonExcluirEvento = new System.Windows.Forms.Button();
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
            this.LabelTitle.Text = "Editar Temporada";
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
            // LabelEntrada
            // 
            this.LabelEntrada.AutoSize = true;
            this.LabelEntrada.Location = new System.Drawing.Point(189, 99);
            this.LabelEntrada.Name = "LabelEntrada";
            this.LabelEntrada.Size = new System.Drawing.Size(51, 13);
            this.LabelEntrada.TabIndex = 1;
            this.LabelEntrada.Text = "Entrada";
            // 
            // EntradaText
            // 
            this.EntradaText.Location = new System.Drawing.Point(192, 115);
            this.EntradaText.Mask = "00/00/0000 90:00";
            this.EntradaText.Name = "EntradaText";
            this.EntradaText.Size = new System.Drawing.Size(115, 21);
            this.EntradaText.TabIndex = 4;
            this.EntradaText.ValidatingType = typeof(System.DateTime);
            // 
            // LabelSaida
            // 
            this.LabelSaida.AutoSize = true;
            this.LabelSaida.Location = new System.Drawing.Point(310, 99);
            this.LabelSaida.Name = "LabelSaida";
            this.LabelSaida.Size = new System.Drawing.Size(39, 13);
            this.LabelSaida.TabIndex = 1;
            this.LabelSaida.Text = "Saida";
            // 
            // SaidaText
            // 
            this.SaidaText.Location = new System.Drawing.Point(313, 115);
            this.SaidaText.Mask = "00/00/0000 90:00";
            this.SaidaText.Name = "SaidaText";
            this.SaidaText.Size = new System.Drawing.Size(115, 21);
            this.SaidaText.TabIndex = 5;
            this.SaidaText.ValidatingType = typeof(System.DateTime);
            // 
            // LabelHoras
            // 
            this.LabelHoras.AutoSize = true;
            this.LabelHoras.Location = new System.Drawing.Point(431, 99);
            this.LabelHoras.Name = "LabelHoras";
            this.LabelHoras.Size = new System.Drawing.Size(40, 13);
            this.LabelHoras.TabIndex = 1;
            this.LabelHoras.Text = "Horas";
            // 
            // HorasText
            // 
            this.HorasText.Location = new System.Drawing.Point(434, 115);
            this.HorasText.Mask = "00:00";
            this.HorasText.Name = "HorasText";
            this.HorasText.Size = new System.Drawing.Size(44, 21);
            this.HorasText.TabIndex = 6;
            this.HorasText.ValidatingType = typeof(System.DateTime);
            // 
            // GridEventos
            // 
            this.GridEventos.AllowUserToAddRows = false;
            this.GridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Entrada,
            this.Saida,
            this.Horas,
            this.Season_ID});
            this.GridEventos.Location = new System.Drawing.Point(12, 142);
            this.GridEventos.MultiSelect = false;
            this.GridEventos.Name = "GridEventos";
            this.GridEventos.RowHeadersWidth = 4;
            this.GridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEventos.Size = new System.Drawing.Size(539, 170);
            this.GridEventos.TabIndex = 8;
            this.GridEventos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEventos_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 170;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Entrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.Width = 150;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "Saida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Saida.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            this.Saida.Width = 150;
            // 
            // Horas
            // 
            this.Horas.DataPropertyName = "Horas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Horas.DefaultCellStyle = dataGridViewCellStyle4;
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.Width = 60;
            // 
            // Season_ID
            // 
            this.Season_ID.DataPropertyName = "Season_ID";
            this.Season_ID.HeaderText = "Season_ID";
            this.Season_ID.Name = "Season_ID";
            this.Season_ID.Visible = false;
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Location = new System.Drawing.Point(9, 99);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(101, 13);
            this.LabelDescricao.TabIndex = 1;
            this.LabelDescricao.Text = "Nome do Evento";
            // 
            // DescricaoText
            // 
            this.DescricaoText.Location = new System.Drawing.Point(12, 115);
            this.DescricaoText.Name = "DescricaoText";
            this.DescricaoText.Size = new System.Drawing.Size(174, 21);
            this.DescricaoText.TabIndex = 3;
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionar.Location = new System.Drawing.Point(484, 113);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(67, 23);
            this.ButtonAdicionar.TabIndex = 7;
            this.ButtonAdicionar.Text = "Adicionar";
            this.ButtonAdicionar.UseVisualStyleBackColor = true;
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // DropEventoNome
            // 
            this.DropEventoNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropEventoNome.FormattingEnabled = true;
            this.DropEventoNome.Location = new System.Drawing.Point(12, 63);
            this.DropEventoNome.Name = "DropEventoNome";
            this.DropEventoNome.Size = new System.Drawing.Size(295, 21);
            this.DropEventoNome.TabIndex = 0;
            this.DropEventoNome.SelectedIndexChanged += new System.EventHandler(this.DropEventoNome_SelectedIndexChanged);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvar.Image = global::EventControlSystem.Properties.Resources.Gravar;
            this.ButtonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSalvar.Location = new System.Drawing.Point(471, 318);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(80, 25);
            this.ButtonSalvar.TabIndex = 9;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExcluir.Image = global::EventControlSystem.Properties.Resources.Excluir;
            this.ButtonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExcluir.Location = new System.Drawing.Point(313, 318);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(152, 25);
            this.ButtonExcluir.TabIndex = 10;
            this.ButtonExcluir.Text = "Excluir Temporada";
            this.ButtonExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExcluir.UseVisualStyleBackColor = true;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // DataInicioText
            // 
            this.DataInicioText.Location = new System.Drawing.Point(440, 63);
            this.DataInicioText.Mask = "00/00/0000";
            this.DataInicioText.Name = "DataInicioText";
            this.DataInicioText.Size = new System.Drawing.Size(115, 21);
            this.DataInicioText.TabIndex = 2;
            this.DataInicioText.ValidatingType = typeof(System.DateTime);
            // 
            // LabelDataInicio
            // 
            this.LabelDataInicio.AutoSize = true;
            this.LabelDataInicio.Location = new System.Drawing.Point(437, 47);
            this.LabelDataInicio.Name = "LabelDataInicio";
            this.LabelDataInicio.Size = new System.Drawing.Size(87, 13);
            this.LabelDataInicio.TabIndex = 10;
            this.LabelDataInicio.Text = "Data de Inicio";
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
            this.DropCetificado.Size = new System.Drawing.Size(121, 21);
            this.DropCetificado.TabIndex = 1;
            // 
            // LabelCertificado
            // 
            this.LabelCertificado.AutoSize = true;
            this.LabelCertificado.Location = new System.Drawing.Point(310, 47);
            this.LabelCertificado.Name = "LabelCertificado";
            this.LabelCertificado.Size = new System.Drawing.Size(69, 13);
            this.LabelCertificado.TabIndex = 12;
            this.LabelCertificado.Text = "Certificado";
            // 
            // ButtonExcluirEvento
            // 
            this.ButtonExcluirEvento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExcluirEvento.Image = global::EventControlSystem.Properties.Resources.Excluir;
            this.ButtonExcluirEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExcluirEvento.Location = new System.Drawing.Point(12, 318);
            this.ButtonExcluirEvento.Name = "ButtonExcluirEvento";
            this.ButtonExcluirEvento.Size = new System.Drawing.Size(127, 25);
            this.ButtonExcluirEvento.TabIndex = 10;
            this.ButtonExcluirEvento.Text = "Excluir Evento";
            this.ButtonExcluirEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExcluirEvento.UseVisualStyleBackColor = true;
            this.ButtonExcluirEvento.Click += new System.EventHandler(this.ButtonExcluirEvento_Click);
            // 
            // Frm_Edit_Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 351);
            this.Controls.Add(this.DropCetificado);
            this.Controls.Add(this.LabelCertificado);
            this.Controls.Add(this.DataInicioText);
            this.Controls.Add(this.LabelDataInicio);
            this.Controls.Add(this.ButtonExcluirEvento);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.DropEventoNome);
            this.Controls.Add(this.ButtonAdicionar);
            this.Controls.Add(this.GridEventos);
            this.Controls.Add(this.HorasText);
            this.Controls.Add(this.SaidaText);
            this.Controls.Add(this.LabelHoras);
            this.Controls.Add(this.EntradaText);
            this.Controls.Add(this.LabelSaida);
            this.Controls.Add(this.LabelEntrada);
            this.Controls.Add(this.DescricaoText);
            this.Controls.Add(this.LabelDescricao);
            this.Controls.Add(this.LabelNomeEvento);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Edit_Temporada";
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
        private System.Windows.Forms.ComboBox DropEventoNome;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.MaskedTextBox DataInicioText;
        private System.Windows.Forms.Label LabelDataInicio;
        private System.Windows.Forms.ComboBox DropCetificado;
        private System.Windows.Forms.Label LabelCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Season_ID;
        private System.Windows.Forms.Button ButtonExcluirEvento;
    }
}