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
using EventControlSystem.Participantes;

namespace EventControlSystem.Eventos
{
    public partial class Frm_Adicionar_Participante : Form
    {
        private DataTable DtEventos;
        private DataTable DtParticipantes;
        private DataTable DtControl;
        private int SeasonID;
        private Participante participante = new Participante();
        private Controle controle = new Controle();
        public Frm_Adicionar_Participante(DataTable vDtEventos,DataTable vDtControl,int vSeasonID)
        {
            InitializeComponent();
            this.DtEventos = vDtEventos;
            this.DtControl = vDtControl;
            this.SeasonID = vSeasonID;
        }

        private void Frm_Adicionar_Participante_Load(object sender, EventArgs e)
        {

            LoadDatabase();
        }

        private void LoadDatabase()
        {
            DtParticipantes = participante.getAll();

            foreach (DataRow row in DtParticipantes.Rows)
            {
                string id = row["id"].ToString();
                string nome = row["nome"].ToString();
                string curso = row["curso"].ToString();

                GridParticipantes.Rows.Add(id, nome, curso);
            }


            foreach (DataRow row in DtEventos.Rows)
            {
                string id = row["id"].ToString();
                string nome = row["nome"].ToString();
                string entrada = row["entrada"].ToString();
                string saida = row["saida"].ToString();

                GridEventos.Rows.Add(id, nome,entrada,saida);
            }


        }

        private void AdicionarParticipante_Click(object sender, EventArgs e)
        {
            if (GridEventosSelecionados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridEventosSelecionados.Rows)
                {
                    int eventoid = Convert.ToInt32(row.Cells["IDEvento2"].Value);
                    DateTime entrada = DateTime.Parse(row.Cells["EntradaEvento2"].Value.ToString());
                    DateTime saida = DateTime.Parse(row.Cells["SaidaEvento2"].Value.ToString());

                    if (GridParticipantesSelecionados.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow rowParticipantes in GridParticipantesSelecionados.Rows)
                        {
                            int userid = Convert.ToInt32(rowParticipantes.Cells["id2"].Value);
                            string nome = rowParticipantes.Cells["nome2"].Value.ToString();

                            DataRow[] HasControl = DtControl.Select("Event_ID = '" + eventoid + "' AND User_ID = '" + userid + "'");

                            if (HasControl.Count() > 0)
                            {

                            }
                            else
                            {
                                tb_control tbControl = new tb_control();
                                tbControl.event_id = eventoid;
                                tbControl.user_id = userid;
                                tbControl.nome = nome;
                                tbControl.entrada = entrada;
                                tbControl.saida = saida;
                                tbControl.horas = "0";
                                tbControl.checkin = 0;

                                if (!controle.Insert(tbControl))
                                {
                                    Msg.ErrorCatch();
                                }
                            }
                        }
                    }
                    else
                    {
                        Msg.Info("Adicione os Participantes");
                        break;
                    }
                }
                Msg.Success("Registrado com Sucesso");
                DialogResult = DialogResult.OK;
            }
            else
            {
                Msg.Info("Adicione os Eventos!");
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

        private void FilterGrid()
        {
            try
            {
                DataView Dv = new DataView(DtParticipantes);
                Dv.RowFilter = "nome LIKE '%" + NomeSearchText.Text + "%' AND curso LIKE '%" + CursoSearchText.Text + "%'";

                if (Dv.Count > 0)
                {
                    GridParticipantes.DataSource = Dv;
                }
                else
                {
                    GridParticipantes.DataSource = DtParticipantes;
                }
            }
            catch
            {
                GridParticipantes.DataSource = DtParticipantes;
            }
        }

        private void NovoParticipante_Click(object sender, EventArgs e)
        {
        }

        private void GridParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridParticipantes.Rows[e.RowIndex];
            GridParticipantesSelecionados.Rows.Add(row.Cells["id"].Value.ToString(), row.Cells["nome"].Value.ToString(), row.Cells["curso"].Value.ToString());
            GridParticipantes.Rows.Remove(row);
        }

        private void GridParticipantesSeleciondados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridParticipantesSelecionados.Rows[e.RowIndex];
            GridParticipantes.Rows.Add(row.Cells["id2"].Value.ToString(), row.Cells["nome2"].Value.ToString(), row.Cells["curso2"].Value.ToString());
            GridParticipantesSelecionados.Rows.Remove(row);
        }

        private void GridEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridEventos.Rows[e.RowIndex];
            GridEventosSelecionados.Rows.Add(row.Cells["IDEvento"].Value.ToString(), row.Cells["NomeEvento"].Value.ToString(), row.Cells["EntradaEvento"].Value.ToString(), row.Cells["SaidaEvento"].Value.ToString());
            GridEventos.Rows.Remove(row);

        }

        private void GridEventosSelecionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridEventosSelecionados.Rows[e.RowIndex];
            GridEventos.Rows.Add(row.Cells["IDEvento2"].Value.ToString(), row.Cells["NomeEvento2"].Value.ToString(), row.Cells["EntradaEvento2"].Value.ToString(), row.Cells["SaidaEvento2"].Value.ToString());
            GridEventosSelecionados.Rows.Remove(row);
        }
    }
}
