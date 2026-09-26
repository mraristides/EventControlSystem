using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventControlSystem.Code
{
    public class Participante
    {
        private DataClassesDataContext Database = new DataClassesDataContext();


        public DataTable getAll()
        {
            DataTable DtParticipante = new DataTable();
            DtParticipante.Columns.Add("id");
            DtParticipante.Columns.Add("nome");
            DtParticipante.Columns.Add("rg");
            DtParticipante.Columns.Add("telefone");
            DtParticipante.Columns.Add("celular");
            DtParticipante.Columns.Add("curso");
            DtParticipante.Columns.Add("email");
            DtParticipante.Columns.Add("ensino");
            DtParticipante.Columns.Add("periodo");
            DtParticipante.Columns.Add("membro");

            var tbParticipante = from x in Database.tb_users select x;
            foreach (var participante in tbParticipante)
            {
                DataRow InsertRow = DtParticipante.NewRow();
                InsertRow["id"] = participante.id;
                InsertRow["nome"] = participante.nome;
                InsertRow["rg"] = participante.rg;
                InsertRow["telefone"] = participante.telefone;
                InsertRow["celular"] = participante.celular;
                InsertRow["curso"] = participante.curso;
                InsertRow["email"] = participante.email;
                InsertRow["ensino"] = participante.ensino;
                InsertRow["periodo"] = participante.periodo;
                InsertRow["membro"] = participante.membro;
                DtParticipante.Rows.Add(InsertRow);
            }

            return DtParticipante;
        }

    }
}
