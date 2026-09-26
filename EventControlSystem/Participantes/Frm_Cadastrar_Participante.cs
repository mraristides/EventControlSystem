using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventControlSystem.Participantes
{
    public partial class Frm_Cadastrar_Participante : Form
    {
        public Frm_Cadastrar_Participante()
        {
            InitializeComponent();
        }
        private DataClassesDataContext Database = new DataClassesDataContext();

        private void Frm_Cadastrar_Participante_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_user tbUser = new tb_user();
                tbUser.nome = NomeText.Text;
                tbUser.rg = RGText.Text;
                tbUser.telefone = TelefoneText.Text;
                tbUser.celular = CelularText.Text;
                tbUser.email = EmailText.Text;
                tbUser.curso = CursoText.Text;
                tbUser.periodo = PeriodoText.Text;
                tbUser.ensino = EnsinoText.Text;
                tbUser.membro = Convert.ToByte(CheckMembro.Checked);
                Database.tb_users.InsertOnSubmit(tbUser);
                Database.SubmitChanges();
                Msg.Info("Cadastrado com sucesso!");
                DialogResult = DialogResult.OK;
            }
            catch
            {
                Msg.ErrorCatch();
            }
            
        }

        private void ClearFields()
        {
            NomeText.Clear();
            RGText.Clear();
            TelefoneText.Clear();
            CelularText.Clear();
            EmailText.Clear();
            CursoText.Clear();
            PeriodoText.Clear();
            EnsinoText.Clear();
            CheckMembro.Checked = false;
        }
    }
}
