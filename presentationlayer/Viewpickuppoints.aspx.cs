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
    public partial class Viewpickuppoints : System.Web.UI.Page
    {
        private void Fillpickuppoints()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            DataSet ds = objbll.Viewpickpoints();
            GridView1.DataSource = ds;
            GridView1.DataBind();
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                Fillpickuppoints();
            }

        }
      
protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.pid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.Deletepickuppoint(objbo);
            if(i==1)
            {
                Fillpickuppoints();
                Response.Write("PICKUPPOINT DELETED SUCCESSFULLY");
            }
            else
            {
                Response.Write("FAILED");
            }
        }
    }
}