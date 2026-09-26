using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class control_users_Default : System.Web.UI.Page
{
    private Command Cmd = new Command();
    private Users Users = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["SEASON"] != null)
            {
                int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);

                var Usuarios = Users.getAllUsers(SeasonID);
                DownList.DataSource = Usuarios;
                DownList.DataTextField = "nome";
                DownList.DataValueField = "id";
                DownList.DataBind();

                var UsuariosPen = Users.getUsersPen(SeasonID);
                pendenteList.DataSource = UsuariosPen;
                pendenteList.DataTextField = "nome";
                pendenteList.DataValueField = "id";
                pendenteList.DataBind();
            }
        }
    }

    protected void editButton_Click(object sender, EventArgs e)
    { 
        if (!string.IsNullOrEmpty(DownList.SelectedValue))
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            HttpCookie UserIDCK = new HttpCookie("UserID", Convert.ToString(DownList.SelectedValue));
            Response.Cookies.Add(UserIDCK);
            HttpCookie UserEDITCK = new HttpCookie("UsersEdit", "1");
            Response.Cookies.Add(UserEDITCK);
            Response.Redirect("~/Participante");
        }   
        
             
        
    }

    protected void registerButton_Click(object sender, EventArgs e)
    {
        HttpCookie UserEDITCK = new HttpCookie("UsersEdit", "0");
        Response.Cookies.Add(UserEDITCK);
        Response.Redirect("~/Participante");
    }

    protected void deleteButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(DownList.SelectedValue))
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            DataClassesDataContext db = new DataClassesDataContext();

            bool DeleteUser = Users.DeleteUser(SeasonID, Convert.ToInt32(DownList.SelectedValue));
            if (DeleteUser == true)
            {
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não existe participantes nessa temporada")), false);

            }
        }
    }

    protected void queryButton_Click(object sender, EventArgs e)
    {        
        int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
        var query = Users.QueryUsers(SeasonID, queryText.Text);

        if (query != null)
        {
            DownList.DataSource = query;
            DownList.DataTextField = "nome";
            DownList.DataValueField = "id";
            DownList.DataBind();
        }
        else
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi possivel encontrar esse participante")), false);

        }
    }

    protected void pagoButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(pendenteList.SelectedValue))
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            bool CheckPago = Users.UsersPago(SeasonID, Convert.ToInt32(pendenteList.SelectedValue));
            if (CheckPago == true)
            {
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }            
        }          
        else
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi encontrado!")), false);
        }

    }


    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Temporada");
    }
}