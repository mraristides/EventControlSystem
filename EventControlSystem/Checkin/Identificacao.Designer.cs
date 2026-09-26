namespace EventControlSystem.Checkin
{
    partial class Identificacao
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
            this.RadioCodigo = new System.Windows.Forms.RadioButton();
            this.RadioLeitor = new System.Windows.Forms.RadioButton();
            this.PanelIdentificacao = new System.Windows.Forms.Panel();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.PanelLeitor = new System.Windows.Forms.Panel();
            this.LabelLeitor = new System.Windows.Forms.Label();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.PanelTitle.SuspendLayout();
            this.PanelIdentificacao.SuspendLayout();
            this.PanelCodigo.SuspendLayout();
            this.PanelLeitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(475, 38);
            this.PanelTitle.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(475, 38);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Identificação";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioCodigo
            // 
            this.RadioCodigo.AutoSize = true;
            this.RadioCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCodigo.Location = new System.Drawing.Point(12, 14);
            this.RadioCodigo.Name = "RadioCodigo";
            this.RadioCodigo.Size = new System.Drawing.Size(163, 20);
            this.RadioCodigo.TabIndex = 3;
            this.RadioCodigo.TabStop = true;
            this.RadioCodigo.Text = "Codigo do Participante";
            this.RadioCodigo.UseVisualStyleBackColor = true;
            this.RadioCodigo.CheckedChanged += new System.EventHandler(this.RadioCodigo_CheckedChanged);
            // 
            // RadioLeitor
            // 
            this.RadioLeitor.AutoSize = true;
            this.RadioLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioLeitor.Location = new System.Drawing.Point(181, 14);
            this.RadioLeitor.Name = "RadioLeitor";
            this.RadioLeitor.Size = new System.Drawing.Size(187, 20);
            this.RadioLeitor.TabIndex = 3;
            this.RadioLeitor.TabStop = true;
            this.RadioLeitor.Text = "Leitor de Codigo de Barras";
            this.RadioLeitor.UseVisualStyleBackColor = true;
            this.RadioLeitor.CheckedChanged += new System.EventHandler(this.RadioLeitor_CheckedChanged);
            // 
            // PanelIdentificacao
            // 
            this.PanelIdentificacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelIdentificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelIdentificacao.Controls.Add(this.RadioCodigo);
            this.PanelIdentificacao.Controls.Add(this.RadioLeitor);
            this.PanelIdentificacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelIdentificacao.Location = new System.Drawing.Point(0, 38);
            this.PanelIdentificacao.Name = "PanelIdentificacao";
            this.PanelIdentificacao.Size = new System.Drawing.Size(475, 48);
            this.PanelIdentificacao.TabIndex = 4;
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Controls.Add(this.CodigoText);
            this.PanelCodigo.Controls.Add(this.LabelCodigo);
            this.PanelCodigo.Enabled = false;
            this.PanelCodigo.Location = new System.Drawing.Point(236, 86);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(230, 168);
            this.PanelCodigo.TabIndex = 5;
            this.PanelCodigo.Visible = false;
            // 
            // PanelLeitor
            // 
            this.PanelLeitor.Controls.Add(this.LabelLeitor);
            this.PanelLeitor.Enabled = false;
            this.PanelLeitor.Location = new System.Drawing.Point(0, 86);
            this.PanelLeitor.Name = "PanelLeitor";
            this.PanelLeitor.Size = new System.Drawing.Size(230, 168);
            this.PanelLeitor.TabIndex = 6;
            this.PanelLeitor.Visible = false;
            // 
            // LabelLeitor
            // 
            this.LabelLeitor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelLeitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelLeitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeitor.Location = new System.Drawing.Point(0, 0);
            this.LabelLeitor.Name = "LabelLeitor";
            this.LabelLeitor.Size = new System.Drawing.Size(230, 28);
            this.LabelLeitor.TabIndex = 0;
            this.LabelLeitor.Text = "Passe o Leitor";
            this.LabelLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(0, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(230, 28);
            this.LabelCodigo.TabIndex = 1;
            this.LabelCodigo.Text = "Digite o Codigo";
            this.LabelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodigoText
            // 
            this.CodigoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.CodigoText.Location = new System.Drawing.Point(0, 28);
            this.CodigoText.Multiline = true;
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(230, 63);
            this.CodigoText.TabIndex = 2;
            // 
            // Identificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 262);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.PanelLeitor);
            this.Controls.Add(this.PanelIdentificacao);
            this.Controls.Add(this.PanelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Identificacao";
            this.ShowIcon = false;
            this.Text = "Identificação de Participante";
            this.PanelTitle.ResumeLayout(false);
            this.PanelIdentificacao.ResumeLayout(false);
            this.PanelIdentificacao.PerformLayout();
            this.PanelCodigo.ResumeLayout(false);
            this.PanelCodigo.PerformLayout();
            this.PanelLeitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.RadioButton RadioCodigo;
        private System.Windows.Forms.RadioButton RadioLeitor;
        private System.Windows.Forms.Panel PanelIdentificacao;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Panel PanelLeitor;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelLeitor;
        private System.Windows.Forms.TextBox CodigoText;
    }
}