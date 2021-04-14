using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Lab2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["usuarios"] = new List<String>();
            Application["profesores"] = new List<String>();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            List<String> users;
            switch (Session["tipousu"])
            {
                case 0:
                    users = (List<String>)Application["usuarios"];
                    users.Remove((String)Session["email"]);
                    break;
                case 1:
                    users = (List<String>)Application["profesores"];
                    users.Remove((String)Session["email"]);
                    break;
                case 2:
                    users = (List<String>)Application["profesores"];
                    users.Remove((String)Session["email"]);
                    break;
                default:
                    break;

            }
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}