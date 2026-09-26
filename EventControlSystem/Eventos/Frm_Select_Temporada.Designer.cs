namespace EventControlSystem.Eventos
{
    partial class Frm_Select_Temporada
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
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataText = new System.Windows.Forms.TextBox();
            this.LabelData = new System.Windows.Forms.Label();
            this.NomeText = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.GridTemporadas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemporadas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(485, 38);
            this.PanelTitle.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(485, 38);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Selecione a Temporada";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.DataText);
            this.panel1.Controls.Add(this.LabelData);
            this.panel1.Controls.Add(this.NomeText);
            this.panel1.Controls.Add(this.LabelNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 51);
            this.panel1.TabIndex = 2;
            // 
            // DataText
            // 
            this.DataText.Location = new System.Drawing.Point(357, 25);
            this.DataText.Name = "DataText";
            this.DataText.Size = new System.Drawing.Size(116, 20);
            this.DataText.TabIndex = 2;
            this.DataText.TextChanged += new System.EventHandler(this.DataText_TextChanged);
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(354, 9);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(30, 13);
            this.LabelData.TabIndex = 3;
            this.LabelData.Text = "Data";
            // 
            // NomeText
            // 
            this.NomeText.Location = new System.Drawing.Point(12, 25);
            this.NomeText.Name = "NomeText";
            this.NomeText.Size = new System.Drawing.Size(339, 20);
            this.NomeText.TabIndex = 2;
            this.NomeText.TextChanged += new System.EventHandler(this.NomeText_TextChanged);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(9, 9);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(107, 13);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome da Temporada";
            // 
            // GridTemporadas
            // 
            this.GridTemporadas.AllowUserToAddRows = false;
            this.GridTemporadas.AllowUserToDeleteRows = false;
            this.GridTemporadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTemporadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Temporada,
            this.Data});
            this.GridTemporadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTemporadas.Location = new System.Drawing.Point(0, 89);
            this.GridTemporadas.MultiSelect = false;
            this.GridTemporadas.Name = "GridTemporadas";
            this.GridTemporadas.ReadOnly = true;
            this.GridTemporadas.RowHeadersWidth = 4;
            this.GridTemporadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTemporadas.Size = new System.Drawing.Size(485, 169);
            this.GridTemporadas.TabIndex = 3;
            this.GridTemporadas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTemporadas_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Temporada
            // 
            this.Temporada.DataPropertyName = "Nome";
            this.Temporada.HeaderText = "Temporada";
            this.Temporada.Name = "Temporada";
            this.Temporada.ReadOnly = true;
            this.Temporada.Width = 350;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Frm_Select_Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 258);
            this.Controls.Add(this.GridTemporadas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Select_Temporada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporadas";
            this.Load += new System.EventHandler(this.Frm_Select_Temporada_Load);
            this.PanelTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTemporadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NomeText;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.DataGridView GridTemporadas;
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}