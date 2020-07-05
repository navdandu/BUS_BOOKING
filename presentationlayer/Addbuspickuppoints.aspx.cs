using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businesslogiclayer;
using System.Data.SqlClient;
using System.Data;

namespace presentationlayer
{
    public partial class Addbuspickuppoints : System.Web.UI.Page
    {
        private void BindSvno()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
           SqlDataReader dr= objbll.Bindserviceno();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    string svno = dr[0].ToString();
                    string fplace = dr[1].ToString();
                    string tplace = dr[2].ToString();
                    string s = svno + "/" + fplace + "/" + tplace;
                    DropDownList1.Items.Add(s);
                }
            }
        }

        private void BindPickuppoints()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            DataSet ds = objbll.Viewpickpoints();
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "pname";
            DropDownList2.DataValueField = "pid";
            DropDownList2.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                BindSvno();
                BindPickuppoints();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.pid = DropDownList2.SelectedValue.ToString();
            string s = DropDownList1.SelectedItem.ToString();
            string[] s1 = s.Split('/');
            objbo.Serviceno = s1[0].ToString();
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.Addbuspickuppoints(objbo);
            if(i==1)
            {
                Response.Write("ADDED");
            }
            else
            {
                Response.Write("FAILED");
            }
        }
    }
}