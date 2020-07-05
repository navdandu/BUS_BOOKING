using System;
using System.Web.UI.WebControls;
namespace presentationlayer
{
    public partial class Loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Businesslogiclayer.Businesslogiclayerclass objll = new Businesslogiclayer.Businesslogiclayerclass();
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.Username = Login1.UserName;
            objbo.Password = Login1.Password;
            int i = objll.Adminlogin(objbo);
            if(i==1)
            {
                Response.Write("Valid User");
                Response.Redirect("Addbus.aspx");
            }
            else
            {
                Login1.FailureText = "Invalid User";
            }
        }
    }
}