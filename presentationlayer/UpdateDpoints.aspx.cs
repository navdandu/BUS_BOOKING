using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businesslogiclayer;
namespace presentationlayer
{
    public partial class UpdateDpoints : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                TextBox1.Text = Session["did"].ToString();
                TextBox2.Text = Session["dname"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.Did = TextBox1.Text;
            objbo.Dname = TextBox2.Text;
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.UpdateDestination(objbo);
            if(i==1)
            {
                Response.Write("Updated");
            }
            else
            {
                Response.Write("update failed");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}