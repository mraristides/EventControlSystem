using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

public partial class Config : System.Web.UI.Page
{
    private Command Cmd = new Command();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void InsertButton_Click(object sender, EventArgs e)
    {
        Cmd.System_Insert(1200);
    }
}