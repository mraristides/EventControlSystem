using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EventControlSystem.Code
{
    public class Season
    {
        private DataClassesDataContext Database = new DataClassesDataContext();

        public DataTable getAll()
        {
            DataTable DtTemporadas = new DataTable();
            DtTemporadas.Columns.Add("ID");
            DtTemporadas.Columns.Add("Nome");
            DtTemporadas.Columns.Add("Data");
            DtTemporadas.Columns.Add("Certificado");


            try
            {
                var temporadas = from x in Database.tb_seasons where x.Deletado.Equals(0) select x;
                if (temporadas != null)
                {
                    foreach (var temporada in temporadas)
                    {
                        DataRow InsertRow = DtTemporadas.NewRow();
                        InsertRow["ID"] = temporada.ID;
                        InsertRow["Nome"] = temporada.Nome;
                        if (!string.IsNullOrEmpty(temporada.Data))
                        {
                            InsertRow["Data"] = temporada.Data.Replace("/","");
                        }
                        InsertRow["Certificado"] = temporada.Certificado;
                        DtTemporadas.Rows.Add(InsertRow);
                    }
                }
            }
            catch
            {


            }

            return DtTemporadas;
        }
    }
}
