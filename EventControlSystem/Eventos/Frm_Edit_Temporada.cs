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

namespace EventControlSystem.Eventos
{
    public partial class Frm_Edit_Temporada : Form
    {
        public Frm_Edit_Temporada()
        {
            InitializeComponent();
        }
        private DataClassesDataContext Database = new DataClassesDataContext();
        private Code.Eventos eventos = new Code.Eventos();
        private Code.Season seasons = new Code.Season();
        private DataTable DtTemporadas;
        private DataTable DtEventos;
        private int EventoIDSelect; 
        private int EventoRowSelect; 
        private string EventoNomeSelect; 
        private void Frm_Cadastrar_Evento_Load(object sender, EventArgs e)
        {
            LoadDatabase();
            LoadSeason();
        }


        private void LoadDatabase()
        {
            GridEventos.AutoGenerateColumns = false;

            DtTemporadas = seasons.getAll();
            if (DtTemporadas.Rows.Count > 0)
            {
                DropEventoNome.DisplayMember = "Nome";
                DropEventoNome.ValueMember = "ID";
                DropEventoNome.DataSource = DtTemporadas;
            }
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            DataTable DtEventos = new DataTable();
            DtEventos.Columns.Add("ID");
            DtEventos.Columns.Add("Nome");
            DtEventos.Columns.Add("Entrada");
            DtEventos.Columns.Add("Saida");
            DtEventos.Columns.Add("Horas");
            DtEventos.Columns.Add("Season_ID");

            string idSeason = Convert.ToString(DropEventoNome.SelectedValue);
            int Index = GridEventos.Rows.Add();
            DataGridViewRow row = GridEventos.Rows[Index];
            row.Cells["ID"].Value = "0";
            row.Cells["Nome"].Value = DescricaoText.Text;
            row.Cells["Entrada"].Value = EntradaText.Text;
            row.Cells["Saida"].Value = SaidaText.Text;
            row.Cells["Horas"].Value = HorasText.Text;
            row.Cells["Season_ID"].Value = idSeason;
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir essa temporada?", "Event Control System", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string idSeason = Convert.ToString(DropEventoNome.SelectedValue);
                var tbSeason = (from x in Database.tb_seasons where x.ID.Equals(idSeason) select x).Single();
                tbSeason.Deletado = 1;
                Database.SubmitChanges();
                Msg.Info("Deletado com sucesso!");
                LoadDatabase();
                LoadSeason();
            }

        }

        private void DropEventoNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSeason();
        }

        private void LoadSeason()
        {
            int idSeason = Convert.ToInt32(DropEventoNome.SelectedValue);
            GridEventos.Rows.Clear();

            DataRow[] DrSeason = DtTemporadas.Select("ID = '" + idSeason + "'");
            if (DrSeason.Count() > 0)
            {
                DropCetificado.Text = Convert.ToString(DrSeason[0]["Certificado"]);
                DataInicioText.Text = Convert.ToString(DrSeason[0]["Data"]);

                DtEventos = eventos.getEventos(idSeason);
                if (DtEventos.Rows.Count > 0)
                {
                    foreach (DataRow row in DtEventos.Rows)
                    {
                        string ID = row["ID"].ToString();
                        string Nome = row["Nome"].ToString();
                        string Entrada = row["Entrada"].ToString();
                        string Saida = row["Saida"].ToString();
                        string Horas = row["Horas"].ToString();
                        string Season_ID = row["Season_ID"].ToString();


                        GridEventos.Rows.Add(ID, Nome, Entrada, Saida, Horas, Season_ID);
                    }
                }
            }

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string idSeason = Convert.ToString(DropEventoNome.SelectedValue);
                var tbSeason = (from x in Database.tb_seasons where x.ID.Equals(idSeason) select x).Single();

                //tbSeason.Nome = DropEventoNome.Text;
                tbSeason.Certificado = DropCetificado.Text;
                tbSeason.Data = DataInicioText.Text;

                Database.SubmitChanges();

                foreach (DataGridViewRow row in GridEventos.Rows)
                {
                    if (row.Cells["ID"].Value.ToString().Equals("0"))
                    {
                        tb_event tbEvent = new tb_event();
                        tbEvent.nome = row.Cells["Nome"].Value.ToString();
                        tbEvent.entrada = DateTime.Parse(row.Cells["Entrada"].Value.ToString());
                        tbEvent.saida = DateTime.Parse(row.Cells["Saida"].Value.ToString());
                        tbEvent.horas = row.Cells["Horas"].Value.ToString();
                        tbEvent.season_id = Convert.ToInt32(row.Cells["Season_ID"].Value);
                        tbEvent.deletado = 0;
                        Database.tb_events.InsertOnSubmit(tbEvent);
                        Database.SubmitChanges();

                    }
                    else
                    {
                        string EventID = row.Cells["ID"].Value.ToString();

                        DataTable DrEventos = DtEventos.Select("ID = '" + EventID + "'").Take(1).CopyToDataTable();
                        if (DrEventos.Rows.Count > 0)
                        {
                            var tbEvent = (from x in Database.tb_events where x.id.Equals(EventID) select x).Single();
                            tbEvent.nome = row.Cells["Nome"].Value.ToString();
                            tbEvent.entrada =  DateTime.Parse(row.Cells["Entrada"].Value.ToString());
                            tbEvent.saida = DateTime.Parse(row.Cells["Saida"].Value.ToString());
                            tbEvent.horas = row.Cells["Horas"].Value.ToString();
                            Database.SubmitChanges();
                        }
                    }
                   

                }
                LoadDatabase();
                LoadSeason();
                Msg.Info("Salvo com Suceso!");

            }
            catch 
            {
                Msg.ErrorCatch();
            }
            Cursor.Current = Cursors.Default;
        }

        private void ButtonExcluirEvento_Click(object sender, EventArgs e)
        {
            if (Msg.Question("Deseja deletar o evento " + EventoNomeSelect + "?"))
            {
                if (EventoIDSelect == 0)
                {
                    GridEventos.Rows.RemoveAt(EventoRowSelect);
                }
                else
                {
                    var tbEvent = (from x in Database.tb_events where x.id.Equals(EventoIDSelect) select x).Single();
                    tbEvent.deletado = 1;
                    Database.SubmitChanges();
                    GridEventos.Rows.RemoveAt(EventoRowSelect);
                }
            }
        }

        private void GridEventos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridEventos.Rows[e.RowIndex];
            EventoIDSelect = Convert.ToInt32(row.Cells["ID"].Value);
            EventoRowSelect = e.RowIndex;
            EventoNomeSelect = Convert.ToString(row.Cells["Nome"].Value);
        }
    }
}
