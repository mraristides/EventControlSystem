using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventControlSystem.Account;
using EventControlSystem.Eventos;
using EventControlSystem.Participantes;

namespace EventControlSystem
{
    public partial class Frm_Principal : Form
    {
        private  User usuario = new User();
        public Frm_Principal()
        {
            InitializeComponent();
           
        }

        public void Start()
        {
            Offline();
            //Online();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {


            // Check Login
            if (usuario.CheckUser(User.Login, User.Senha))
            {
                User.Status = true;
                LabelStatus.Text = "On";
                LabelStatus.BackColor = Color.Green;
            }
            else
            {
                User.Status = false;
                LabelStatus.Text = "Off";
                LabelStatus.BackColor = Color.Red;
            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (usuario.CheckUser(LoginText.Text,SenhaText.Text))
            {
                Online();
                Msg.Info("Conectado");
            }
            else
            {
                Msg.Info("Autenticação Invalida!");
            }
            Cursor.Current = Cursors.Default;
        }

        public void Online()
        {
            MenuHeader.Visible = true;
            MenuHeader.Enabled = true;
            PanelLogin.Visible = false;
            PanelLogin.Enabled = false;
            FooterContainer.Visible = true;
            FooterContainer.Enabled = true;
            desconectarToolStripMenuItem.Visible = true;
            desconectarToolStripMenuItem.Enabled = true;
            PanelPrincipal.Visible = true;
            PanelPrincipal.Enabled = true;
            LabelNome.Text = "Nome: " + User.Nome + " | Ultimo Acesso: " + User.UltimoAcesso.ToString("dd/MM/yyyy HH:mm");
        }

        public void Offline()
        {
            MenuHeader.Visible = false;
            MenuHeader.Enabled = false;
            PanelLogin.Visible = true;
            PanelLogin.Enabled = true;
            FooterContainer.Visible = false;
            FooterContainer.Enabled = false;
            desconectarToolStripMenuItem.Visible = false;
            desconectarToolStripMenuItem.Enabled = false;
            PanelPrincipal.Visible = false;
            PanelPrincipal.Enabled = false;
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Status)
            {
                Msg.Info("Desconectado");
                Offline();
                usuario.Saida();
            }
            else
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (User.Status)
            {
                Offline();
                usuario.Saida();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cadastrarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Temporada frmCadastarEvento = (Frm_Cadastrar_Temporada)Application.OpenForms["Frm_Cadastrar_Evento"];
            if (frmCadastarEvento == null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Frm_Cadastrar_Temporada CadastrarEvento = new Frm_Cadastrar_Temporada();
                CadastrarEvento.Show();
                Cursor.Current = Cursors.Default;
            }


        }

        private void editarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_Edit_Temporada frmEditEvento = (Frm_Edit_Temporada)Application.OpenForms["Frm_Edit_Evento"];
            if (frmEditEvento == null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Frm_Edit_Temporada EditarEvento = new Frm_Edit_Temporada();
                EditarEvento.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void acessarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Select_Temporada SelectTemporada = new Frm_Select_Temporada();
            SelectTemporada.Show();
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginText.Text))
            {
                LoginText.Text = "Usuario";
                LoginText.ForeColor = Color.DimGray;
            }
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text.Equals("Usuario"))
            {
                LoginText.ForeColor = Color.Black;
                LoginText.Clear();
            }
        }
        private void SenhaText_Enter(object sender, EventArgs e)
        {
            if (SenhaText.Text.Equals("Senha"))
            {
                SenhaText.ForeColor = Color.Black;
                SenhaText.Clear();
            }
        }

        private void SenhaText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginText.Text))
            {
                SenhaText.Text = "Senha";
                SenhaText.ForeColor = Color.DimGray;
            }
        }

        private void criarNovoParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Cadastrar_Participante frmCadastarParticipante = (Frm_Cadastrar_Participante)Application.OpenForms["Frm_Cadastrar_Participante"];
            if (frmCadastarParticipante == null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Frm_Cadastrar_Participante CadastrarParticipante = new Frm_Cadastrar_Participante();
                CadastrarParticipante.Show();
                Cursor.Current = Cursors.Default;
            }
        }


        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Edit_Participante frmEditParticipante = (Frm_Edit_Participante)Application.OpenForms["Frm_Edit_Participante"];
            if (frmEditParticipante == null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Frm_Edit_Participante EditarParticipante = new Frm_Edit_Participante();
                EditarParticipante.Show();
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
