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
using System.Windows.Forms.DataVisualization.Charting;

namespace EventControlSystem.Eventos
{
    public partial class Frm_Temporada : Form
    {
        private int SeasonID;
        public Frm_Temporada(int vSeasonID)
        {
            InitializeComponent();
            this.SeasonID = vSeasonID;
        }
        private DataClassesDataContext Database = new DataClassesDataContext();
        private Code.Eventos eventos = new Code.Eventos();
        private Controle controle = new Controle();
        private DataTable DtEventos;
        private DataTable DtControl;
        private int EventoIDSelect;
        private int EventoRowSelect;
        private string EventoNomeSelect;
        private void LoadDatabase()
        {
            try
            {
                DtControl = controle.getAll();
                DtEventos = eventos.getEventos(SeasonID);
                GridEventos.AutoGenerateColumns = false;
                GridParticipantes.AutoGenerateColumns = false;
                GridEventos.DataSource = DtEventos;
            }
            catch (Exception ex)
            {
                Msg.Info(ex.Message);
                Msg.ErrorCatch();
            }
            
        }

        private void LoadEvento()
        {
            if (DtControl.Rows.Count > 0)
            {
                try
                {
                    DataTable DtControlLoad = DtControl.Select("Event_ID = '" + EventoIDSelect + "'").CopyToDataTable();
                    if (DtControlLoad.Rows.Count > 0)
                    {
                        GridParticipantes.DataSource = DtControlLoad;
                        LoadChart();
                    }
                    else
                    {
                        GridParticipantes.DataSource = null;
                    }
                }
                catch
                {
                    GridParticipantes.DataSource = null;
                }
            }
        }

        private void LoadChart()
        {
            int AusentesCount = 0;
            int PresentesCount = 0;
            int SaidaCount = 0;
            int TotalCount = 0;

            foreach (DataGridViewRow row in GridParticipantes.Rows)
            {
                string checkin = Convert.ToString(row.Cells["Status"].Value);

                if (checkin == "AUSENTE")
                {
                    AusentesCount++;
                }
                else if (checkin == "PRESENTE")
                {
                    PresentesCount++;
                }
                else if (checkin == "SAIDA")
                {
                    SaidaCount++;
                }
                TotalCount++;
            }

            ChartTemp.Series.Clear();

            int MaxAxes = 1;
            int Count = 0;

            ChartTemp.Series.Add("Real");
            ChartTemp.Series["Real"].ChartType = SeriesChartType.Column;
            ChartTemp.Series["Real"].IsVisibleInLegend = false;
            ChartTemp.Series["Real"].IsValueShownAsLabel = true;

            if (TotalCount != 0)
            {
                ChartTemp.Series["Real"].Points.Add(TotalCount);
                ChartTemp.Series["Real"].Points[Count].AxisLabel = "Total";
                ChartTemp.Series["Real"].Points[Count].Label = TotalCount.ToString();
                ChartTemp.Series["Real"].Points[Count].Color = Color.Blue;
                MaxAxes++;
                Count++;
            }


            if (AusentesCount != 0)
            {
                ChartTemp.Series["Real"].Points.Add(AusentesCount);
                ChartTemp.Series["Real"].Points[Count].AxisLabel = "Ausentes";
                ChartTemp.Series["Real"].Points[Count].Label = AusentesCount.ToString();
                ChartTemp.Series["Real"].Points[Count].Color = Color.Red;
                MaxAxes++;
                Count++;
            }

            if (PresentesCount != 0)
            {
                ChartTemp.Series["Real"].Points.Add(PresentesCount);
                ChartTemp.Series["Real"].Points[Count].AxisLabel = "Presentes";
                ChartTemp.Series["Real"].Points[Count].Label = PresentesCount.ToString();
                ChartTemp.Series["Real"].Points[Count].Color = Color.Green;
                MaxAxes++;
                Count++;
            }

            if (SaidaCount != 0)
            {
                ChartTemp.Series["Real"].Points.Add(SaidaCount);
                ChartTemp.Series["Real"].Points[Count].AxisLabel = "Saida";
                ChartTemp.Series["Real"].Points[Count].Label = SaidaCount.ToString();
                ChartTemp.Series["Real"].Points[Count].Color = Color.Maroon;
                MaxAxes++;
                Count++;
            }

            ChartTemp.ChartAreas["ChartArea1"].AxisY.Maximum = TotalCount + 5;
            ChartTemp.ChartAreas["ChartArea1"].AxisX.Maximum = MaxAxes;

        }


        private void Frm_Temporada_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void ButtonAddParticipante_Click(object sender, EventArgs e)
        {
            Frm_Adicionar_Participante Adicionar = new Frm_Adicionar_Participante(DtEventos,DtControl,SeasonID);
            if (Adicionar.ShowDialog() == DialogResult.OK)
            {
                LoadDatabase();
            }
        }

        private void GridEventos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridEventos.Rows[e.RowIndex];
            EventoIDSelect = Convert.ToInt32(row.Cells["IDEvento"].Value);
            EventoNomeSelect = Convert.ToString(row.Cells["NomeEvento"].Value);
            EventoRowSelect = e.RowIndex;
            LoadEvento();
        }

        private void GridParticipantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value.ToString() == "AUSENTE")
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 5 && e.Value.ToString() == "PRESENTE")
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 5 && e.Value.ToString() == "SAIDA")
            {
                e.CellStyle.BackColor = Color.Maroon;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void GridParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridParticipantes.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string nome = row.Cells["Nome"].Value.ToString();
            string status = row.Cells["Status"].Value.ToString();
            
            if (status == "AUSENTE")
            {
                if (Msg.Question("Deseja deletar " + nome + " do evento " + EventoNomeSelect + "?"))
                {
                    var UserControl = (from x in Database.tb_controls where x.id.Equals(id) select x).Single();
                    Database.tb_controls.DeleteOnSubmit(UserControl);
                    Database.SubmitChanges();
                    Msg.Success("Deletado com Sucesso!");
                    LoadDatabase();
                }
            }
            else
            {
                Msg.Info("Não é possivel deletar um participante Presente ou que ja deu saida do evento!!");
            }

            
            
            
        }
    }
}
