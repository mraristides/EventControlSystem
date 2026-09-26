namespace EventControlSystem.Eventos
{
    partial class Frm_Adicionar_Participante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridParticipantes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdicionarParticipante = new System.Windows.Forms.Button();
            this.GridParticipantesSelecionados = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GridEventos = new System.Windows.Forms.DataGridView();
            this.IDEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GridEventosSelecionados = new System.Windows.Forms.DataGridView();
            this.IDEvento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEvento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaEvento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaEvento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantesSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventosSelecionados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridParticipantes
            // 
            this.GridParticipantes.AllowUserToAddRows = false;
            this.GridParticipantes.AllowUserToDeleteRows = false;
            this.GridParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Curso});
            this.GridParticipantes.Location = new System.Drawing.Point(12, 71);
            this.GridParticipantes.MultiSelect = false;
            this.GridParticipantes.Name = "GridParticipantes";
            this.GridParticipantes.ReadOnly = true;
            this.GridParticipantes.RowHeadersWidth = 4;
            this.GridParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridParticipantes.Size = new System.Drawing.Size(465, 163);
            this.GridParticipantes.TabIndex = 23;
            this.GridParticipantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridParticipantes_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 150;
            // 
            // CursoSearchText
            // 
            this.CursoSearchText.Location = new System.Drawing.Point(364, 8);
            this.CursoSearchText.Name = "CursoSearchText";
            this.CursoSearchText.Size = new System.Drawing.Size(167, 20);
            this.CursoSearchText.TabIndex = 22;
            this.CursoSearchText.TextChanged += new System.EventHandler(this.CursoSearchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(324, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Curso";
            // 
            // NomeSearchText
            // 
            this.NomeSearchText.Location = new System.Drawing.Point(53, 8);
            this.NomeSearchText.Name = "NomeSearchText";
            this.NomeSearchText.Size = new System.Drawing.Size(265, 20);
            this.NomeSearchText.TabIndex = 21;
            this.NomeSearchText.TextChanged += new System.EventHandler(this.NomeSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome";
            // 
            // AdicionarParticipante
            // 
            this.AdicionarParticipante.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarParticipante.Image = global::EventControlSystem.Properties.Resources.Confirmar;
            this.AdicionarParticipante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdicionarParticipante.Location = new System.Drawing.Point(766, 385);
            this.AdicionarParticipante.Name = "AdicionarParticipante";
            this.AdicionarParticipante.Size = new System.Drawing.Size(182, 25);
            this.AdicionarParticipante.TabIndex = 24;
            this.AdicionarParticipante.Text = "Adicionar Participantes";
            this.AdicionarParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdicionarParticipante.UseVisualStyleBackColor = true;
            this.AdicionarParticipante.Click += new System.EventHandler(this.AdicionarParticipante_Click);
            // 
            // GridParticipantesSelecionados
            // 
            this.GridParticipantesSelecionados.AllowUserToAddRows = false;
            this.GridParticipantesSelecionados.AllowUserToDeleteRows = false;
            this.GridParticipantesSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParticipantesSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.nome2,
            this.curso2});
            this.GridParticipantesSelecionados.Location = new System.Drawing.Point(483, 71);
            this.GridParticipantesSelecionados.MultiSelect = false;
            this.GridParticipantesSelecionados.Name = "GridParticipantesSelecionados";
            this.GridParticipantesSelecionados.ReadOnly = true;
            this.GridParticipantesSelecionados.RowHeadersWidth = 4;
            this.GridParticipantesSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridParticipantesSelecionados.Size = new System.Drawing.Size(465, 163);
            this.GridParticipantesSelecionados.TabIndex = 23;
            this.GridParticipantesSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridParticipantesSeleciondados_CellDoubleClick);
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Visible = false;
            this.id2.Width = 50;
            // 
            // nome2
            // 
            this.nome2.DataPropertyName = "nome";
            this.nome2.HeaderText = "Nome";
            this.nome2.Name = "nome2";
            this.nome2.ReadOnly = true;
            this.nome2.Width = 300;
            // 
            // curso2
            // 
            this.curso2.DataPropertyName = "curso";
            this.curso2.HeaderText = "Curso";
            this.curso2.Name = "curso2";
            this.curso2.ReadOnly = true;
            this.curso2.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Todos os Participantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Participantes Selecionados";
            // 
            // GridEventos
            // 
            this.GridEventos.AllowUserToAddRows = false;
            this.GridEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEvento,
            this.NomeEvento,
            this.EntradaEvento,
            this.SaidaEvento});
            this.GridEventos.Location = new System.Drawing.Point(12, 261);
            this.GridEventos.MultiSelect = false;
            this.GridEventos.Name = "GridEventos";
            this.GridEventos.ReadOnly = true;
            this.GridEventos.RowHeadersWidth = 4;
            this.GridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEventos.Size = new System.Drawing.Size(465, 118);
            this.GridEventos.TabIndex = 30;
            this.GridEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEventos_CellDoubleClick);
            // 
            // IDEvento
            // 
            this.IDEvento.DataPropertyName = "id";
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
            this.NomeEvento.Width = 200;
            // 
            // EntradaEvento
            // 
            this.EntradaEvento.DataPropertyName = "Entrada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EntradaEvento.DefaultCellStyle = dataGridViewCellStyle2;
            this.EntradaEvento.HeaderText = "Entrada";
            this.EntradaEvento.Name = "EntradaEvento";
            this.EntradaEvento.ReadOnly = true;
            this.EntradaEvento.Width = 120;
            // 
            // SaidaEvento
            // 
            this.SaidaEvento.DataPropertyName = "Saida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SaidaEvento.DefaultCellStyle = dataGridViewCellStyle3;
            this.SaidaEvento.HeaderText = "Saida";
            this.SaidaEvento.Name = "SaidaEvento";
            this.SaidaEvento.ReadOnly = true;
            this.SaidaEvento.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Todos os Eventos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Eventos Selecionados";
            // 
            // GridEventosSelecionados
            // 
            this.GridEventosSelecionados.AllowUserToAddRows = false;
            this.GridEventosSelecionados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEventosSelecionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridEventosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEventosSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEvento2,
            this.NomeEvento2,
            this.EntradaEvento2,
            this.SaidaEvento2});
            this.GridEventosSelecionados.Location = new System.Drawing.Point(483, 261);
            this.GridEventosSelecionados.MultiSelect = false;
            this.GridEventosSelecionados.Name = "GridEventosSelecionados";
            this.GridEventosSelecionados.ReadOnly = true;
            this.GridEventosSelecionados.RowHeadersWidth = 4;
            this.GridEventosSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEventosSelecionados.Size = new System.Drawing.Size(465, 118);
            this.GridEventosSelecionados.TabIndex = 30;
            this.GridEventosSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEventosSelecionados_CellDoubleClick);
            // 
            // IDEvento2
            // 
            this.IDEvento2.DataPropertyName = "id";
            this.IDEvento2.HeaderText = "ID";
            this.IDEvento2.Name = "IDEvento2";
            this.IDEvento2.ReadOnly = true;
            this.IDEvento2.Visible = false;
            // 
            // NomeEvento2
            // 
            this.NomeEvento2.DataPropertyName = "Nome";
            this.NomeEvento2.HeaderText = "Nome";
            this.NomeEvento2.Name = "NomeEvento2";
            this.NomeEvento2.ReadOnly = true;
            this.NomeEvento2.Width = 200;
            // 
            // EntradaEvento2
            // 
            this.EntradaEvento2.DataPropertyName = "Entrada";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EntradaEvento2.DefaultCellStyle = dataGridViewCellStyle5;
            this.EntradaEvento2.HeaderText = "Entrada";
            this.EntradaEvento2.Name = "EntradaEvento2";
            this.EntradaEvento2.ReadOnly = true;
            this.EntradaEvento2.Width = 120;
            // 
            // SaidaEvento2
            // 
            this.SaidaEvento2.DataPropertyName = "Saida";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SaidaEvento2.DefaultCellStyle = dataGridViewCellStyle6;
            this.SaidaEvento2.HeaderText = "Saida";
            this.SaidaEvento2.Name = "SaidaEvento2";
            this.SaidaEvento2.ReadOnly = true;
            this.SaidaEvento2.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NomeSearchText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CursoSearchText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 35);
            this.panel1.TabIndex = 31;
            // 
            // Frm_Adicionar_Participante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridEventosSelecionados);
            this.Controls.Add(this.GridEventos);
            this.Controls.Add(this.AdicionarParticipante);
            this.Controls.Add(this.GridParticipantesSelecionados);
            this.Controls.Add(this.GridParticipantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Adicionar_Participante";
            this.ShowIcon = false;
            this.Text = "Adicionar Participantes";
            this.Load += new System.EventHandler(this.Frm_Adicionar_Participante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridParticipantesSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEventosSelecionados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridParticipantes;
        private System.Windows.Forms.TextBox CursoSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdicionarParticipante;
        private System.Windows.Forms.DataGridView GridParticipantesSelecionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso2;
        private System.Windows.Forms.DataGridView GridEventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridEventosSelecionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaidaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEvento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaEvento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaidaEvento2;
        private System.Windows.Forms.Panel panel1;
    }
}