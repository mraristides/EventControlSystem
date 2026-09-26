using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
/// <summary>
/// ///////////////////////////////////////////////
/// ///////// <!-- Code developed by Blind --> ////
/// ///////////////////// 我看你 ///////////////////
/// </summary>

   

public class Command
{
    /// <summary>
    ///  Retorna string de alerta javascript 
    /// </summary>
    /// <param name="error"></param>
    /// <returns>string valor</returns>
    /// 
    public System.Text.StringBuilder Msg(string msg)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("window.onload=function(){");
        sb.Append("alert('");
        sb.Append(msg);
        sb.Append("')};");
        sb.Append("</script>");
        return sb;
    }

    public string DebugMode(string error)
    {
        string value = "<script>confirm('" + error + "')</script>";
        return value;
    }
    
    
    public void System_Insert(int Q)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        for (int i = 0; i < Q; i++)
        {
            tb_user user = new tb_user();
            user.nome = "Participante " + i.ToString();
            user.season_id = 1;
            user.horas_total = "0";
            db.tb_users.InsertOnSubmit(user);
            db.SubmitChanges();

            tb_control tb_control = new tb_control();
            tb_control.event_id = 1;
            tb_control.user_id = user.id;
            db.tb_controls.InsertOnSubmit(tb_control);
            db.SubmitChanges();

        }
    } 

    public string getMonth(int month)
    {

        string[] months = new string[12];
        months[0] = "Janeiro";
        months[1] = "Fervereiro";
        months[2] = "Março";
        months[3] = "Abril";
        months[4] = "Maio";
        months[5] = "Junho";
        months[6] = "Julho";
        months[7] = "Agosto";
        months[8] = "Setembro";
        months[9] = "Outubro";
        months[10] = "Novembro";
        months[11] = "Dezembro";
        int m = month - 1;
        return months[m];
    }

    public void DeleteFile(string path)
    {
        FileInfo file = new FileInfo(path);
        if (file.Exists)
        {
            file.Delete();
        }
    }

    public string FormatRG(string rg)
    {
        rg = rg.Insert(2, "-");
        rg = rg.Insert(5, ".");
        rg = rg.Insert(9, ".");
        rg = rg.ToUpper();
        return rg;
    }




    }



