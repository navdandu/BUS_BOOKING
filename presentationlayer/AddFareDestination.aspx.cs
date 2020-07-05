using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Businessobjects;

namespace presentationlayer
{
    public partial class AddFareDestination : System.Web.UI.Page
    {
        private void BindSvno()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            SqlDataReader dr = objbll.Bindserviceno();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string svno = dr[0].ToString();
                    Session["svno"] = svno;
                    string fplace = dr[1].ToString();
                    string tplace = dr[2].ToString();
                    string s = svno + "/" + fplace + "/" + tplace;
                    DropDownList1.Items.Add(s);
                }
            }
        }
        private void Bindpointsbasedonsvno()
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            string s = DropDownList1.SelectedItem.ToString();
            string[] s1 = s.Split('/');
            objbo.Serviceno = s1[0].ToString();
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            DataSet ds = objbll.Bindpointsbasedonserviceno(objbo);
            DropDownList2.DataSource = ds;
            DropDownList2.DataValueField = "dname";
            DropDownList2.DataBind();
            DropDownList3.DataSource = ds;
            DropDownList3.DataValueField = "dname";
            DropDownList3.DataBind();
        }
        private void FillDpoints1()
        {
           Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            Businessobjects.BusinessObjectsclass objbo = new BusinessObjectsclass();
            string s = DropDownList1.SelectedItem.ToString();
            string[] s1 = s.Split('/');
            objbo.Serviceno = s1[0];
            DataSet ds = objbll.ViewDpoints(objbo);
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "dname";
            DropDownList3.DataValueField = "did";
            DropDownList3.DataBind();
            ViewState["svno"] = objbo.Serviceno;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                BindSvno();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            Businessobjects.BusinessObjectsclass objbo = new BusinessObjectsclass();

            Bindpointsbasedonsvno();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            Businessobjects.BusinessObjectsclass objbo = new BusinessObjectsclass();
            objbo.Serviceno = ViewState["svno"].ToString();
            objbo.Fdid = DropDownList2.SelectedValue.ToString();
            objbo.Fdeptime = TextBox2.Text;
            objbo.Tdid = DropDownList3.SelectedValue.ToString();
            objbo.Tdeptime = TextBox3.Text; 
            objbo.Fare = double.Parse(TextBox1.Text);
            int i = objbll.Addfaredestination(objbo);
            if (i==1)
                {
                Response.Write("Added");

            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDpoints1();
            DropDownList3.Items.Remove(DropDownList2.SelectedItem.ToString());
            
        }
    }
}