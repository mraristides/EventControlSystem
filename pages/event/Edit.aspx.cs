using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class control_event_Edit : System.Web.UI.Page
{
    
    private Command Cmd = new Command();
    private Eventos Eventos = new Eventos();
    private int SeasonID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
                SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
                if (Request.Cookies["EventEdit"] != null)
                {
                    string EventEdit = Request.Cookies["EventEdit"].Value;
                    if (EventEdit == "0")
                    {
                        SubmitButton.Text = "Registrar";

                    }
                    else if (EventEdit == "1")
                    {
                        SubmitButton.Text = "Editar";
                        if (Request.Cookies["EventID"] != null)
                        {
                            int eventID = Convert.ToInt32(Request.Cookies["EventID"].Value);
                            var customer = Eventos.getEvent(SeasonID, eventID);
                            if (customer != null)
                            {
                                nomeText.Text = customer.nome;
                                string Date = DateTime.Parse(customer.date.ToString()).ToShortDateString();
                                DataText_CalendarExtender.SelectedDate = DateTime.Parse(Date);
                                timeText.Text = Convert.ToString(customer.time);
                                DuracaoEventText.Text = Convert.ToString(customer.duracao);
                                if (customer.event_check == 0)
                                {
                                    RadioButtonList.SelectedIndex = 0;
                                    DuracaoText.Text = Convert.ToString(customer.event_time);
                                }
                                else if (customer.event_check == 1)
                                {
                                    RadioButtonList.SelectedIndex = 1;
                                    DuracaoText.Text = Convert.ToString(customer.event_time);
                                }
                            }
                            else
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi possivel encontrar o evento!")), false);
                            }
                        }                       

                    }
                }
            }
                     
        }

    protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {

        if (Request.Cookies["SEASON"] != null)
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            if (Request.Cookies["EventEdit"] != null)
            {
                string EventEdit = Request.Cookies["EventEdit"].Value;
                if (EventEdit == "1")
                {
                    if (Request.Cookies["EventID"] != null)
                    {
                        string eventID = Request.Cookies["EventID"].Value;
                        try
                        {
                            DataClassesDataContext Database = new DataClassesDataContext();
                            var tb_eventos = (from x in Database.tb_events where x.id.Equals(eventID) && x.season_id.Equals(SeasonID) select x).Single();
                            tb_eventos.nome = nomeText.Text;
                            tb_eventos.date = DateTime.Parse(DataText.Text);
                            tb_eventos.time = TimeSpan.Parse(timeText.Text);
                            tb_eventos.duracao = Convert.ToInt32(DuracaoEventText.Text);
                            if (RadioButtonList.SelectedIndex == 0)
                            {
                                tb_eventos.event_check = 0;
                                tb_eventos.event_time = DuracaoText.Text;
                            }
                            else if (RadioButtonList.SelectedIndex == 1)
                            {
                                tb_eventos.event_check = 1;
                                tb_eventos.event_time = DuracaoText.Text;
                            }
                            Database.SubmitChanges();
                            Response.Redirect("~/Eventos");
                        }
                        catch (Exception)
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi possivel Editar!!")), false);
                        }
                    }
                }
                else if (EventEdit == "0")
                {
                    int HasEvent = Eventos.getEventID(SeasonID, nomeText.Text);
                    if (HasEvent != 0)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Ja existe um evento com este nome")), false);
                    }
                    else
                    {
                        tb_event tb_event = new tb_event();
                        tb_event.nome = nomeText.Text;
                        tb_event.date = DateTime.Parse(DataText.Text);
                        tb_event.season_id = SeasonID;
                        tb_event.duracao = Convert.ToInt32(DuracaoEventText.Text);
                        if (timeText.Text != null)
                        {
                            tb_event.time = TimeSpan.Parse(timeText.Text);
                        }
                        if (RadioButtonList.SelectedIndex == 0)
                        {
                            tb_event.event_check = 0;
                            tb_event.event_time = DuracaoText.Text;
                        }
                        else if (RadioButtonList.SelectedIndex == 1)
                        {
                            tb_event.event_check = 1;
                            tb_event.event_time = DuracaoText.Text;
                        }
                        bool InsertValue = Eventos.InsertEvent(tb_event);

                        if (InsertValue == true)
                        {
                            Response.Redirect("~/Eventos");
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Não foi possivel cadastrar")), false);
                        }

                    }
                }
            }      
        }
    }



    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Eventos");
    }
}