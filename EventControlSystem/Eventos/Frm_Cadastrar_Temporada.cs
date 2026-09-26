using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventControlSystem.Eventos
{
    public partial class Frm_Cadastrar_Temporada : Form
    {
        private DataClassesDataContext Database = new DataClassesDataContext();
        public Frm_Cadastrar_Temporada()
        {
            InitializeComponent();
        }

        private void Frm_Cadastrar_Evento_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            DataTable DtEventos = new DataTable();
            DtEventos.Columns.Add("Nome");
            DtEventos.Columns.Add("Entrada");
            DtEventos.Columns.Add("Saida");
            DtEventos.Columns.Add("Horas");

            int Index = GridEventos.Rows.Add();
            DataGridViewRow row = GridEventos.Rows[Index];
            row.Cells["Nome"].Value = DescricaoText.Text;
            row.Cells["Entrada"].Value = EntradaText.Text;
            row.Cells["Saida"].Value = SaidaText.Text;
            row.Cells["Horas"].Value = HorasText.Text;
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (CheckFields() == "")
            {
                tb_season tbSeason = new tb_season();
                tbSeason.Nome = NomeEventoText.Text;
                tbSeason.Data = DataInicioText.Text;
                tbSeason.Certificado = DropCetificado.Text;
                tbSeason.Deletado = 0;
                Database.tb_seasons.InsertOnSubmit(tbSeason);
                Database.SubmitChanges();

                foreach (DataGridViewRow row in GridEventos.Rows)
                {
                    string Nome = row.Cells["Nome"].Value.ToString();
                    string Entrada = row.Cells["Entrada"].Value.ToString();
                    string Saida = row.Cells["Entrada"].Value.ToString();
                    string Horas = row.Cells["Horas"].Value.ToString();


                    tb_event tbEvent = new tb_event();
                    tbEvent.nome = Nome;
                    tbEvent.entrada = DateTime.Parse(Entrada);
                    tbEvent.saida = DateTime.Parse(Saida);
                    tbEvent.horas = Horas;
                    tbEvent.season_id = tbSeason.ID;
                    tbEvent.deletado = 0;

                    Database.tb_events.InsertOnSubmit(tbEvent);
                    Database.SubmitChanges();

                }
                Cursor.Current = Cursors.Default;
                Msg.Info("Registrado!");
                this.Close();
                Frm_Temporada Temporada = new Frm_Temporada(tbSeason.ID);
                Temporada.Show();
                             
            }
            else
            {
                Msg.Stop("O campo " + CheckFields() + " deve ser preenchido");
            }

          




        }


        private string CheckFields()
        {
            if (string.IsNullOrEmpty(NomeEventoText.Text))
            {
                NomeEventoText.Focus();
                return "Nome da Temporada";
            }
            else if (string.IsNullOrEmpty(DropCetificado.Text))
            {
                DropCetificado.Focus();
                return "Certificado";
            }
            else if (string.IsNullOrEmpty(DataInicioText.Text))
            {
                DataInicioText.Focus();
                return "Data de Inicio";
            }
            else if (GridEventos.Rows.Count < 1)
            {
                GridEventos.Focus();
                return "Eventos";
            }
            else
            {
                return "";
            }

        }
    }
}
