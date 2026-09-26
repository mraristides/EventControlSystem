using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventControlSystem
{
    public class Msg
    {
        public static void Info(string msg)
        {
            MessageBox.Show(msg,"Event Control System", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public static void Error(string msg)
        {
            MessageBox.Show(msg, "Event Control System", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void Stop(string msg)
        {
            MessageBox.Show(msg, "Event Control System", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
        }

        public static void ErrorCatch()
        {
            MessageBox.Show("Error, Entre em contato com o administrador do sistema!", "Event Control System", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void Success(string msg)
        {
            MessageBox.Show(msg, "Event Control System", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        public static bool Question(string msg)
        {
            if (MessageBox.Show(msg, "Event Control System", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
