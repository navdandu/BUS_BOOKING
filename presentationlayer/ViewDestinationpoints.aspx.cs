using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businesslogiclayer;
using System.Data;
namespace presentationlayer
{
    public partial class ViewDestinationpoints : System.Web.UI.Page
    {
        private void FillDpoints()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
           DataSet ds= objbll.ViewDpoints();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          if(IsPostBack==false)
            {
                FillDpoints();
            }  

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillDpoints();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
             if(e.CommandName.ToString()=="cmddelete")
            {
                int rowindex = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = (GridViewRow)GridView1.Rows[rowindex];
                Label l = (Label)row.FindControl("Label1");
                Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
                objbo.Did = l.Text;
                Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
                int i = objbll.DeleteDestinationpoint(objbo);
                FillDpoints();

            }
             else if(e.CommandName.ToString()=="cmdupdate")
            {

                int rowindex = Convert.ToInt32(e.CommandArgument.ToString());
                GridViewRow row = (GridViewRow)GridView1.Rows[rowindex];
                Label l = (Label)row.FindControl("Label1");
                Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
                objbo.Did = l.Text;
                Label l1 = (Label)row.FindControl("Label2");
                objbo.Dname = l1.Text;
                Session["did"] = l.Text;
                Session["dname"] = l1.Text;
                Response.Redirect("updateDpoints.aspx");
            }
        }
    }
}