using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class control_event_Default : System.Web.UI.Page
{
    private Command Cmd = new Command();
    private Eventos Eventos = new Eventos();
    private int SeasonID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
        if (!IsPostBack)
        {
            if (Request.Cookies["SEASON"] != null)
            {
                var table = Eventos.getAllEvents(SeasonID);
                DownList.DataSource = table;    
                DownList.DataTextField = "nome";
                DownList.DataValueField = "id";
                DownList.DataBind();
            }
        }
    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        HttpCookie Cookie = new HttpCookie("EventEdit", "0");
        Response.Cookies.Add(Cookie);
        Response.Redirect("~/Evento");
    }

    protected void EditButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(DownList.SelectedValue))
        {

        }
        else
        {
            int EventID = Convert.ToInt32(DownList.SelectedValue);
            HttpCookie CookieEvent = new HttpCookie("EventEdit", "1");
            Response.Cookies.Add(CookieEvent);
            HttpCookie CookieID = new HttpCookie("EventID", Convert.ToString(EventID));
            Response.Cookies.Add(CookieID);
            Response.Redirect("~/Evento");
        }       
    }

    protected void ApagarButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(DownList.SelectedValue))
        {

        }
        else
        {
            bool DelCheck = Eventos.deleteEvent(Convert.ToInt32(DownList.SelectedValue));
            if (DelCheck == true)
            {
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }
    }


    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Temporada");
    }

    protected void QueryButton_Click(object sender, EventArgs e)
    {
        var query = Eventos.queryEvent(SeasonID, QueryText.Text);
        if (query != null)
        {
            DownList.DataSource = query;
            DownList.DataTextField = "nome";
            DownList.DataValueField = "id";
            DownList.DataBind();
        }
    }
}