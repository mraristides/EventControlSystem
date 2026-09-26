using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventControlSystem.Checkin
{
    public partial class Identificacao : Form
    {
        public Identificacao()
        {
            InitializeComponent();
        }

        private void RadioCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCodigo.Checked)
            {
                PanelCodigo.Visible = true;
                PanelCodigo.Enabled = true;
                PanelLeitor.Visible = false;
                PanelLeitor.Enabled = false;
            }
        }

        private void RadioLeitor_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioLeitor.Checked)
            {
                PanelLeitor.Visible = true;
                PanelLeitor.Enabled = true;
                PanelCodigo.Visible = false;
                PanelCodigo.Enabled = false;
            }
        }
    }
}
