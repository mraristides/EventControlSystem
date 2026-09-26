using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    private Command Cmd = new Command();
    private Season season = new Season();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DataClassesDataContext Database = new DataClassesDataContext();

            var seasons = season.getallSeason();
            DropDownSeason.DataSource = seasons;
            DropDownSeason.DataTextField = "nome";
            DropDownSeason.DataValueField = "id";
            DropDownSeason.DataBind();
        }
    }


    protected void seasonButton_Click(object sender, EventArgs e)
    {
        DataClassesDataContext Database = new DataClassesDataContext();
        int SeasonID = season.getSeasonID(nameSeasonText.Text);
        if (SeasonID != 0)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Ja Existe uma temporada com esse nome;")), false);
        }
        else
        {
            tb_season tbSeason = new tb_season();
            tbSeason.Nome = nameSeasonText.Text;
            tbSeason.Data = DataText.Text;
            tbSeason.Certificado = DropCertificadosModelo.SelectedValue;
            Database.tb_seasons.InsertOnSubmit(tbSeason);
            Database.SubmitChanges();

            string ID = tbSeason.ID.ToString();
            season.CreateFolder(ID);
            HttpCookie CK_Season = new HttpCookie("SEASON", ID);
            Response.Cookies.Add(CK_Season);
            Response.Redirect("~/Temporada");
        }
    }

    protected void editButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(DropDownSeason.SelectedValue))
        {            
        }
        else
        {
            int SeasonID = Convert.ToInt32(DropDownSeason.SelectedValue);
            HttpCookie CK_Season = new HttpCookie("SEASON", Convert.ToString(SeasonID));
            Response.Cookies.Add(CK_Season);
            Response.Redirect("~/Temporada");
        }


    }



}