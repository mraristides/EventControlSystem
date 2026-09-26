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
    public partial class Frm_Select_Temporada : Form
    {
        public Frm_Select_Temporada()
        {
            InitializeComponent();
        }
        private DataClassesDataContext Database = new DataClassesDataContext();
        private DataTable DtTemporadas;

        private void Frm_Select_Temporada_Load(object sender, EventArgs e)
        {
            LoadDatabase();
            FilterGrid();
        }

        private void LoadDatabase()
        {
            DtTemporadas = new DataTable();
            DtTemporadas.Columns.Add("ID");
            DtTemporadas.Columns.Add("Nome");
            DtTemporadas.Columns.Add("Data");

            try
            {
                var tempordas = from x in Database.tb_seasons where x.Deletado.Equals(0) select x;
                foreach (var temporada in tempordas)
                {

                    DataRow InsertRow = DtTemporadas.NewRow();
                    InsertRow["ID"] = temporada.ID;
                    InsertRow["Nome"] = temporada.Nome;
                    InsertRow["Data"] = temporada.Data;
                    DtTemporadas.Rows.Add(InsertRow);
                }
            }
            catch
            {

            }

        }

        private void FilterGrid()
        {
            try
            {
                if (string.IsNullOrEmpty(NomeText.Text) && string.IsNullOrEmpty(DataText.Text))
                {
                    GridTemporadas.DataSource = DtTemporadas;
                }
                else
                {
                    DataView Dv = new DataView(DtTemporadas);
                    Dv.RowFilter = "Nome LIKE '%" + NomeText.Text + "%' AND Data LIKE '%" + DataText.Text + "%'";

                    if (Dv.Count > 0)
                    {
                        GridTemporadas.DataSource = Dv;
                    }
                    else
                    {
                        GridTemporadas.DataSource = DtTemporadas;
                    }
                }

            }
            catch
            {
                GridTemporadas.DataSource = DtTemporadas;
            }
        }

        private void GridTemporadas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = GridTemporadas.Rows[e.RowIndex];

            Frm_Temporada Temporada = new Frm_Temporada(Convert.ToInt32(row.Cells["ID"].Value));
            this.Close();
            Temporada.Show();


        }

        private void NomeText_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void DataText_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }
    }
}
