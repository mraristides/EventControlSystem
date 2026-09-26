namespace EventControlSystem.Eventos
{
    partial class Frm_Temporada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridParticipantes = new System.Windows.Forms.DataGridView();
            this.PanelParticipantes = new System.Windows.Forms.Panel();
            this.DropStatusParticipantes = new System.Windows.Forms.ComboBox();
            this.NomeParticipanteText = new System.Windows.Forms.TextBox();
            this.LabelStatusParticipante = new System.Windows.Forms.Label();
            this.LabelNomeParticipante = new System.Windows.Forms.Label();
            this.LableTitleParticipantes = new System.Windows.Forms.Label();
            this.ButtonAddParticipante = new System.Windows.Forms.Button();
            this.ButtonGerarCertificado = new System.Windows.Forms.Button();
            this.ButtonGerarCracha = new System.Windows.Forms.Button();
            this.PanelEventos = new System.Windows.Forms.Panel();
            this.LabelEventos = new System.Windows.Forms.Label();
            this.GridEventos = new System.Windows.Forms.DataGridView();
            this.IDEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.ChartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasContabilizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantes)).BeginInit();
            this.PanelParticipantes.SuspendLayout();
            this.PanelEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).BeginInit();
            this.PanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // GridParticipantes
            // 
            this.GridParticipantes.AllowUserToAddRows = false;
            this.GridParticipantes.AllowUserToDeleteRows = false;
            this.GridParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Entrada,
            this.Saida,
            this.HorasContabilizadas,
            this.Status});
            this.GridParticipantes.Location = new System.Drawing.Point(0, 79);
            this.GridParticipantes.Name = "GridParticipantes";
            this.GridParticipantes.ReadOnly = true;
            this.GridParticipantes.RowHeadersWidth = 4;
            this.GridParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridParticipantes.Size = new System.Drawing.Size(761, 215);
            this.GridParticipantes.TabIndex = 0;
            this.GridParticipantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridParticipantes_CellDoubleClick);
            this.GridParticipantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridParticipantes_CellFormatting);
            // 
            // PanelParticipantes
            // 
            this.PanelParticipantes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelParticipantes.Controls.Add(this.DropStatusParticipantes);
            this.PanelParticipantes.Controls.Add(this.NomeParticipanteText);
            this.PanelParticipantes.Controls.Add(this.LabelStatusParticipante);
            this.PanelParticipantes.Controls.Add(this.LabelNomeParticipante);
            this.PanelParticipantes.Controls.Add(this.LableTitleParticipantes);
            this.PanelParticipantes.Controls.Add(this.GridParticipantes);
            this.PanelParticipantes.Location = new System.Drawing.Point(12, 155);
            this.PanelParticipantes.Name = "PanelParticipantes";
            this.PanelParticipantes.Size = new System.Drawing.Size(761, 294);
            this.PanelParticipantes.TabIndex = 1;
            // 
            // DropStatusParticipantes
            // 
            this.DropStatusParticipantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropStatusParticipantes.FormattingEnabled = true;
            this.DropStatusParticipantes.Location = new System.Drawing.Point(343, 52);
            this.DropStatusParticipantes.Name = "DropStatusParticipantes";
            this.DropStatusParticipantes.Size = new System.Drawing.Size(121, 21);
            this.DropStatusParticipantes.TabIndex = 6;
            // 
            // NomeParticipanteText
            // 
            this.NomeParticipanteText.Location = new System.Drawing.Point(8, 53);
            this.NomeParticipanteText.Name = "NomeParticipanteText";
            this.NomeParticipanteText.Size = new System.Drawing.Size(329, 20);
            this.NomeParticipanteText.TabIndex = 4;
            // 
            // LabelStatusParticipante
            // 
            this.LabelStatusParticipante.AutoSize = true;
            this.LabelStatusParticipante.Location = new System.Drawing.Point(340, 36);
            this.LabelStatusParticipante.Name = "LabelStatusParticipante";
            this.LabelStatusParticipante.Size = new System.Drawing.Size(37, 13);
            this.LabelStatusParticipante.TabIndex = 5;
            this.LabelStatusParticipante.Text = "Status";
            // 
            // LabelNomeParticipante
            // 
            this.LabelNomeParticipante.AutoSize = true;
            this.LabelNomeParticipante.Location = new System.Drawing.Point(5, 37);
            this.LabelNomeParticipante.Name = "LabelNomeParticipante";
            this.LabelNomeParticipante.Size = new System.Drawing.Size(109, 13);
            this.LabelNomeParticipante.TabIndex = 5;
            this.LabelNomeParticipante.Text = "Nome do Participante";
            // 
            // LableTitleParticipantes
            // 
            this.LableTitleParticipantes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LableTitleParticipantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.LableTitleParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableTitleParticipantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LableTitleParticipantes.Location = new System.Drawing.Point(0, 0);
            this.LableTitleParticipantes.Name = "LableTitleParticipantes";
            this.LableTitleParticipantes.Size = new System.Drawing.Size(759, 31);
            this.LableTitleParticipantes.TabIndex = 1;
            this.LableTitleParticipantes.Text = "Participantes";
            this.LableTitleParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAddParticipante
            // 
            this.ButtonAddParticipante.Image = global::EventControlSystem.Properties.Resources.adicionar;
            this.ButtonAddParticipante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddParticipante.Location = new System.Drawing.Point(778, 155);
            this.ButtonAddParticipante.Name = "ButtonAddParticipante";
            this.ButtonAddParticipante.Size = new System.Drawing.Size(161, 28);
            this.ButtonAddParticipante.TabIndex = 2;
            this.ButtonAddParticipante.Text = "Adicionar Participante";
            this.ButtonAddParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddParticipante.UseVisualStyleBackColor = true;
            this.ButtonAddParticipante.Click += new System.EventHandler(this.ButtonAddParticipante_Click);
            // 
            // ButtonGerarCertificado
            // 
            this.ButtonGerarCertificado.Image = global::EventControlSystem.Properties.Resources.imprimir;
            this.ButtonGerarCertificado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGerarCertificado.Location = new System.Drawing.Point(778, 189);
            this.ButtonGerarCertificado.Name = "ButtonGerarCertificado";
            this.ButtonGerarCertificado.Size = new System.Drawing.Size(161, 28);
            this.ButtonGerarCertificado.TabIndex = 2;
            this.ButtonGerarCertificado.Text = "Gerar Certificado";
            this.ButtonGerarCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGerarCertificado.UseVisualStyleBackColor = true;
            // 
            // ButtonGerarCracha
            // 
            this.ButtonGerarCracha.Image = global::EventControlSystem.Properties.Resources.imprimir;
            this.ButtonGerarCracha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGerarCracha.Location = new System.Drawing.Point(778, 223);
            this.ButtonGerarCracha.Name = "ButtonGerarCracha";
            this.ButtonGerarCracha.Size = new System.Drawing.Size(161, 28);
            this.ButtonGerarCracha.TabIndex = 2;
            this.ButtonGerarCracha.Text = "Gerar Crachá";
            this.ButtonGerarCracha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGerarCracha.UseVisualStyleBackColor = true;
            // 
            // PanelEventos
            // 
            this.PanelEventos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelEventos.Controls.Add(this.LabelEventos);
            this.PanelEventos.Controls.Add(this.GridEventos);
            this.PanelEventos.Location = new System.Drawing.Point(12, 12);
            this.PanelEventos.Name = "PanelEventos";
            this.PanelEventos.Size = new System.Drawing.Size(565, 137);
            this.PanelEventos.TabIndex = 2;
            // 
            // LabelEventos
            // 
            this.LabelEventos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEventos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelEventos.Location = new System.Drawing.Point(0, 0);
            this.LabelEventos.Name = "LabelEventos";
            this.LabelEventos.Size = new System.Drawing.Size(563, 27);
            this.LabelEventos.TabIndex = 7;
            this.LabelEventos.Text = "Eventos";
            this.LabelEventos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridEventos
            // 
            this.GridEventos.AllowUserToAddRows = false;
            this.GridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.GridEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEvento,
            this.NomeEvento,
            this.EntradaEvento,
            this.SaidaEvento,
            this.Horas});
            this.GridEventos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridEventos.Location = new System.Drawing.Point(0, 27);
            this.GridEventos.MultiSelect = false;
            this.GridEventos.Name = "GridEventos";
            this.GridEventos.ReadOnly = true;
            this.GridEventos.RowHeadersWidth = 4;
            this.GridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEventos.Size = new System.Drawing.Size(563, 108);
            this.GridEventos.TabIndex = 6;
            this.GridEventos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEventos_CellEnter);
            // 
            // IDEvento
            // 
            this.IDEvento.DataPropertyName = "ID";
            this.IDEvento.HeaderText = "ID";
            this.IDEvento.Name = "IDEvento";
            this.IDEvento.ReadOnly = true;
            this.IDEvento.Visible = false;
            // 
            // NomeEvento
            // 
            this.NomeEvento.DataPropertyName = "Nome";
            this.NomeEvento.HeaderText = "Nome";
            this.NomeEvento.Name = "NomeEvento";
            this.NomeEvento.ReadOnly = true;
            this.NomeEvento.Width = 170;
            // 
            // EntradaEvento
            // 
            this.EntradaEvento.DataPropertyName = "Entrada";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EntradaEvento.DefaultCellStyle = dataGridViewCellStyle14;
            this.EntradaEvento.HeaderText = "Entrada";
            this.EntradaEvento.Name = "EntradaEvento";
            this.EntradaEvento.ReadOnly = true;
            this.EntradaEvento.Width = 120;
            // 
            // SaidaEvento
            // 
            this.SaidaEvento.DataPropertyName = "Saida";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SaidaEvento.DefaultCellStyle = dataGridViewCellStyle15;
            this.SaidaEvento.HeaderText = "Saida";
            this.SaidaEvento.Name = "SaidaEvento";
            this.SaidaEvento.ReadOnly = true;
            this.SaidaEvento.Width = 120;
            // 
            // Horas
            // 
            this.Horas.DataPropertyName = "Horas";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Horas.DefaultCellStyle = dataGridViewCellStyle16;
            this.Horas.HeaderText = "Horas ACC";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 120;
            // 
            // PanelChart
            // 
            this.PanelChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelChart.Controls.Add(this.ChartTemp);
            this.PanelChart.Location = new System.Drawing.Point(583, 12);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(357, 137);
            this.PanelChart.TabIndex = 3;
            // 
            // ChartTemp
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.ChartTemp.ChartAreas.Add(chartArea2);
            this.ChartTemp.Location = new System.Drawing.Point(-2, -2);
            this.ChartTemp.Name = "ChartTemp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Series2";
            this.ChartTemp.Series.Add(series2);
            this.ChartTemp.Size = new System.Drawing.Size(357, 137);
            this.ChartTemp.TabIndex = 0;
            this.ChartTemp.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Situação da Temporada";
            this.ChartTemp.Titles.Add(title2);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Entrada.DefaultCellStyle = dataGridViewCellStyle9;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "Saida";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Saida.DefaultCellStyle = dataGridViewCellStyle10;
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            // 
            // HorasContabilizadas
            // 
            this.HorasContabilizadas.DataPropertyName = "Horas";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HorasContabilizadas.DefaultCellStyle = dataGridViewCellStyle11;
            this.HorasContabilizadas.HeaderText = "Horas";
            this.HorasContabilizadas.Name = "HorasContabilizadas";
            this.HorasContabilizadas.ReadOnly = true;
            this.HorasContabilizadas.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Checkin";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle12;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 120;
            // 
            // Frm_Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 461);
            this.Controls.Add(this.PanelChart);
            this.Controls.Add(this.PanelEventos);
            this.Controls.Add(this.ButtonGerarCracha);
            this.Controls.Add(this.ButtonGerarCertificado);
            this.Controls.Add(this.ButtonAddParticipante);
            this.Controls.Add(this.PanelParticipantes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Temporada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporada Nome";
            this.Load += new System.EventHandler(this.Frm_Temporada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantes)).EndInit();
            this.PanelParticipantes.ResumeLayout(false);
            this.PanelParticipantes.PerformLayout();
            this.PanelEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).EndInit();
            this.PanelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridParticipantes;
        private System.Windows.Forms.Panel PanelParticipantes;
        private System.Windows.Forms.Label LableTitleParticipantes;
        private System.Windows.Forms.Button ButtonAddParticipante;
        private System.Windows.Forms.Button ButtonGerarCertificado;
        private System.Windows.Forms.Button ButtonGerarCracha;
        private System.Windows.Forms.Panel PanelEventos;
        private System.Windows.Forms.Label LabelEventos;
        private System.Windows.Forms.DataGridView GridEventos;
        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTemp;
        private System.Windows.Forms.TextBox NomeParticipanteText;
        private System.Windows.Forms.Label LabelNomeParticipante;
        private System.Windows.Forms.ComboBox DropStatusParticipantes;
        private System.Windows.Forms.Label LabelStatusParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaidaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasContabilizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}