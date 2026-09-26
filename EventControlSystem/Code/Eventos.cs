using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventControlSystem.Code
{
    public class Eventos
    {
        private DataClassesDataContext Database = new DataClassesDataContext();

        public DataTable getAll()
        {
            DataTable DtEvento = new DataTable();
            DtEvento.Columns.Add("ID");
            DtEvento.Columns.Add("Nome");
            DtEvento.Columns.Add("Entrada");
            DtEvento.Columns.Add("Saida");
            DtEvento.Columns.Add("Horas");
            DtEvento.Columns.Add("Season_ID");

            try
            {
                var tbEvents = from x in Database.tb_events where x.deletado.Equals(0) orderby x.nome select x;
                foreach (var eventos in tbEvents)
                {
                    DataRow InsertRow = DtEvento.NewRow();
                    InsertRow["ID"] = eventos.id;
                    InsertRow["Nome"] = eventos.nome;

                    string Entrada = DateTime.Parse(eventos.entrada.ToString()).ToString("dd/MM/yyyy HH:mm");
                    string Saida = DateTime.Parse(eventos.saida.ToString()).ToString("dd/MM/yyyy HH:mm");
                    InsertRow["Entrada"] = Entrada;
                    InsertRow["Saida"] = Saida;
                    InsertRow["Horas"] = eventos.horas;
                    InsertRow["Season_ID"] = eventos.season_id;
                    DtEvento.Rows.Add(InsertRow);
                }
            }
            catch
            {

            }

            return DtEvento;
        }

        public DataTable getEventos(int SeasonID)
        {
            DataTable DtEvento = new DataTable();
            DtEvento.Columns.Add("ID");
            DtEvento.Columns.Add("Nome");
            DtEvento.Columns.Add("Entrada");
            DtEvento.Columns.Add("Saida");
            DtEvento.Columns.Add("Horas");
            DtEvento.Columns.Add("Season_ID");

            try
            {
                var tbEvents = from x in Database.tb_events where x.season_id.Equals(SeasonID) && x.deletado.Equals(0) orderby x.nome  select x;
                foreach (var eventos in tbEvents)
                {
                    DataRow InsertRow = DtEvento.NewRow();
                    InsertRow["ID"] = eventos.id;
                    InsertRow["Nome"] = eventos.nome;
                    string Entrada = DateTime.Parse(eventos.entrada.ToString()).ToString("dd/MM/yyyy HH:mm");
                    string Saida = DateTime.Parse(eventos.saida.ToString()).ToString("dd/MM/yyyy HH:mm");
                    InsertRow["Entrada"] = Entrada;
                    InsertRow["Saida"] = Saida;
                    InsertRow["Horas"] = eventos.horas;
                    InsertRow["Season_ID"] = eventos.season_id;
                    DtEvento.Rows.Add(InsertRow);
                }
            }
            catch
            {

            }

            return DtEvento;

        }
    }
}
