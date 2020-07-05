using System;
using System.Data;
using Businesslogiclayer;


namespace presentationlayer
{
    public partial class Home3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                DisplayDplace();
            }
        }
        private void DisplayDplace()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayerclass();
            DataSet ds = objbll.Binddenames();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "dname";
            DropDownList1.DataValueField = "did";
            DropDownList1.DataBind();
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "dname";
            DropDownList2.DataValueField = "did";
            DropDownList2.DataBind();

        }
    }
}