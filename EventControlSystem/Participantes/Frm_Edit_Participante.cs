using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventControlSystem.Code;

namespace EventControlSystem.Participantes
{
    public partial class Frm_Edit_Participante : Form
    {
        public Frm_Edit_Participante()
        {
            InitializeComponent();
        }
        private DataClassesDataContext Database = new DataClassesDataContext();
        private DataTable DtParticipante;
        private Participante participante = new Participante();
        
        private void LoadDatabase()
        {

            DtParticipante = participante.getAll();
            GridParticipantes.DataSource = DtParticipante;
        }

        private void Frm_Edit_Participante_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void GridParticipantes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            DataGridViewRow row = GridParticipantes.Rows[e.RowIndex];
            NomeText.Text = row.Cells["nome"].Value.ToString();
            RGText.Text = row.Cells["rg"].Value.ToString();
            TelefoneText.Text = row.Cells["telefone"].Value.ToString();
            CelularText.Text = row.Cells["celular"].Value.ToString();
            EmailText.Text = row.Cells["email"].Value.ToString();
            CursoText.Text = row.Cells["curso"].Value.ToString();
            PeriodoText.Text = row.Cells["periodo"].Value.ToString();
            EnsinoText.Text = row.Cells["ensino"].Value.ToString();
            if (row.Cells["membro"].Value.ToString() == "1")
            {
                CheckMembro.Checked = true;
            }
            else
            {
                CheckMembro.Checked = false;
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

        private void FilterGrid()
        {
            try
            {
                DataView Dv = new DataView(DtParticipante);
                Dv.RowFilter = "nome LIKE '%" + NomeSearchText.Text + "%' AND curso LIKE '%" + CursoSearchText.Text + "%'";    

                if (Dv.Count > 0)
                {
                    GridParticipantes.DataSource = Dv;
                }
                else
                {
                    GridParticipantes.DataSource = DtParticipante;
                }
            }
            catch
            {
                GridParticipantes.DataSource = DtParticipante;
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = GridParticipantes.CurrentRow;
                int id = Convert.ToInt32(row.Cells["id"].Value);

                var tbUser = (from x in Database.tb_users where x.id.Equals(id) select x).Single();
                tbUser.nome = NomeText.Text;
                tbUser.rg = RGText.Text;
                tbUser.telefone = TelefoneText.Text;
                tbUser.celular = CelularText.Text;
                tbUser.email = EmailText.Text;
                tbUser.curso = CursoText.Text;
                tbUser.periodo = PeriodoText.Text;
                tbUser.ensino = EnsinoText.Text;
                tbUser.membro = Convert.ToByte(CheckMembro.Checked);
                Database.SubmitChanges();
                Msg.Info("Salvo com Sucesso!");
                ClearFields();
                LoadDatabase();
            }
            catch
            {
                Msg.ErrorCatch();
            }
        }

        private void NomeSearchText_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void CursoSearchText_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void NovoParticipante_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Participante Cadastrar = new Frm_Cadastrar_Participante();
            if (Cadastrar.ShowDialog() == DialogResult.OK)
            {
                LoadDatabase();
                FilterGrid();
            }
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
