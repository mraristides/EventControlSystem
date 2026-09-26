using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventControlSystem.Code
{
    public class Controle
    {
        private DataClassesDataContext Database = new DataClassesDataContext();

        public bool Insert(tb_control tbControl)
        {
            try
            {
                Database.tb_controls.InsertOnSubmit(tbControl);
                Database.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getAll()
        {
            DataTable DtControl = new DataTable();
            DtControl.Columns.Add("ID");
            DtControl.Columns.Add("Event_ID");
            DtControl.Columns.Add("User_ID");
            DtControl.Columns.Add("Nome");
            DtControl.Columns.Add("Entrada");
            DtControl.Columns.Add("Saida");
            DtControl.Columns.Add("Horas");
            DtControl.Columns.Add("Checkin");

            Dictionary<int, string> DicCheckin = new Dictionary<int, string>();
            DicCheckin.Add(0, "AUSENTE");
            DicCheckin.Add(1, "PRESENTE");
            DicCheckin.Add(2, "SAIDA");

            try
            {
                var tbControl = from x in Database.tb_controls select x ;
                foreach (var control in tbControl)
                {
                    DataRow InsertRow = DtControl.NewRow();
                    InsertRow["ID"] = control.id;
                    InsertRow["Event_ID"] = control.event_id;
                    InsertRow["User_ID"] = control.user_id;
                    InsertRow["Nome"] = control.nome;
                    string Entrada = DateTime.Parse(control.entrada.ToString()).ToString("dd/MM/yyyy HH:mm");
                    string Saida = DateTime.Parse(control.saida.ToString()).ToString("dd/MM/yyyy HH:mm");
                    InsertRow["Entrada"] = Entrada;
                    InsertRow["Saida"] = Saida;
                    InsertRow["Horas"] = control.horas;

                    int checkin = Convert.ToInt32(control.checkin);
                    InsertRow["Checkin"] = DicCheckin[checkin];
                    
                    DtControl.Rows.Add(InsertRow);

                }
            }
            catch
            {
            }

            return DtControl;
        }


    }
}
