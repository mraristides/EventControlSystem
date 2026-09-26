using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Season : System.Web.UI.Page
{
    
    private Command Cmd = new Command();
    private Season Season = new Season();
    private Doc doc = new Doc();
    private int SeasonID; 

    protected void Page_Load(object sender, EventArgs e)
    { 
        if (Request.Cookies["SEASON"] != null)
        {
            SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);            
            if (!IsPostBack)
            {
                tb_season season = Season.getSeason(SeasonID);
                DropCertificado.SelectedValue = season.Certificado;
                DataText.Text = season.Data;
                
                /*
                Users user = new Users();
                object Obusers = user.getAllUsers(SeasonID);
                Gv.DataSource = Obusers;
                Gv.DataBind(); */
            } 
        }
    }

    protected void EventButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Eventos");
    }

    protected void UsersButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Participantes");
    }

    

    protected void DeleteButton_Click(object sender, EventArgs e)
    {       
        bool DeleteCheck = Season.deleteSeason(SeasonID);
        if (DeleteCheck == true)
        {
            Response.Redirect("~/");
        }
        else
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi possivel deletar essa temporada!")), false);
        }
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/");
    }

    protected void GerarButton_Click(object sender, EventArgs e)
    {
        string MapPath = Server.MapPath("..\\lib\\img\\certificados\\");
        doc.Certificado(SeasonID, MapPath);
        Response.Redirect("~/Seasons/season" + SeasonID.ToString() + "/Certificados.pdf");
    }


    protected void GerarCrachar_Click(object sender, EventArgs e)
    {
        string MapPath = Server.MapPath("..\\lib\\img\\certificados\\");
        doc.Crachar(SeasonID, MapPath);
        Response.Redirect("~/Seasons/season" + SeasonID.ToString() + "/Crachas.pdf");
    }


    protected void ButtonUpdateSeason_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var season = (from x in db.tb_seasons where x.ID.Equals(SeasonID) select x).Single();
        season.Certificado = DropCertificado.Text;
        season.Data = DataText.Text;
        db.SubmitChanges();       

    }
}