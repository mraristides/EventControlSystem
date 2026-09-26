
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class Page : System.Web.UI.MasterPage
{    
    Command Cmd = new Command();
    protected void Page_Load(object sender, EventArgs e)
    {
        ImageButton.ImageUrl = "/lib/img/logo.png";
        string Title = this.Page.Title;
        if (Title == "Inicio" || Title == "Config" || Title == "Certificados" || Title == "Check" || Title == "Configurar Certificado")
        {
            if (Title == "Inicio")
            {
                seasonLabel.Text = "Temporadas";
            }
            else if (Title == "Configurar Certificado")
            {
                seasonLabel.Text = "Configurar Certificado";
            }
            else if (Title == "Config")
            {

                seasonLabel.Text = "Configurações";
            }
            else if (Title == "Certificados")
            {

                seasonLabel.Text = "Certificados";
            }
            else if (Title == "Check")
            {
                seasonLabel.Text = "Checkin";
            }
        }   
        else
        {        
            try
            {
                if (Request.Cookies["SEASON"] != null)
                {
                    
                    Season Season = new Season();
                    int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
                    var season = Season.getSeason(SeasonID);
                    if (season != null)
                    {
                        PainelBar.Visible = true;
                        string[] Counts = Season.getCountUsers(SeasonID);
                        seasonLabel.Text = season.Nome;
                        UsersLabel.Text = Counts[0];
                        PagoLabel.Text = Counts[1];
                        PendenteLabel.Text = Counts[2];
                        LabelSmall.Text = "Temporada";
                        if (Title == "Season")
                        {
                            LabelSmall.Visible = true;
                            LabelSmall.Enabled = true;
                            string Date = season.Data.ToString();
                            LabelSmall.Text = DateTime.Parse(Date).ToShortDateString();
                        }
                    }                 
                }
                else
                {
                    Response.Redirect("~/");
                }

            }
            catch(Exception)
            {

            }
                
                 
        }  
    }

    protected void Atualizar_Click(object sender, EventArgs e)
    {
        Response.Redirect(this.Request.RawUrl);
    }
}
