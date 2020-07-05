using System;
using System.Web.UI.WebControls;
using System.Data;
namespace presentationlayer
{
    public partial class ViewBus : System.Web.UI.Page
    {
        private void FillBusData()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            DataSet ds = objbll.Viewbus();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                FillBusData();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string svno = GridView1.DataKeys[e.RowIndex].Value.ToString();
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.Serviceno = svno;
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.DeleteBus(objbo);
            if(i==1)
            {
                Response.Write("BUS DELETION SUCCESFULL");
            }
            else
            {
                Response.Write("FAILED");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillBusData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillBusData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("txtsvno");
            objbo.Serviceno = t1.Text;

            TextBox t2 = (TextBox)row.FindControl("txtfplace");
            objbo.Fromplace = t2.Text;

            TextBox t3 = (TextBox)row.FindControl("txttplace");
            objbo.Toplace = t3.Text;

            TextBox t4 = (TextBox)row.FindControl("txtcapacity");
            objbo.Capacity = t4.Text;

            TextBox t5 = (TextBox)row.FindControl("txtarrtime");
            objbo.Arrivaltime = t5.Text;

            TextBox t6 = (TextBox)row.FindControl("txtdeptime");
            objbo.Depaturetime = t6.Text;

            TextBox t7 = (TextBox)row.FindControl("txttravelagencyname");
            objbo.Travelagencyname = t7.Text;

            TextBox t8 = (TextBox)row.FindControl("txtbustype");
            objbo.bustype = t8.Text;

            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.Editbus(objbo);
            if (i==1)
            {
                Response.Write("ROW UPDATED SUCCESSFULLY");
            }
            else
            {
                Response.Write("ROW UPDATING FAILED");
            }
        }
    }
}