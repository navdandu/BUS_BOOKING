using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Businessobjects;

namespace presentationlayer
{
    public partial class Addbusdestinationpoints : System.Web.UI.Page
    {
        private void BindSvno()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            SqlDataReader dr = objbll.Bindserviceno();
            if(dr.HasRows)
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
        private void FillDpoints()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            Businessobjects.BusinessObjectsclass objbo = new BusinessObjectsclass();
            DataSet ds = objbll.ViewDpoints(objbo);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
                  if(IsPostBack==false)
            {
                BindSvno();
                FillDpoints();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox c1 = (CheckBox)row.FindControl("CheckBox1");
                if(c1.Checked==true)
                {
                    Label l1 = (Label)row.FindControl("Label1");
                    Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
                    objbo.Did = l1.Text.ToString();
                    string s = DropDownList1.SelectedItem.ToString();
                    string[] s1 = s.Split('/');
                    objbo.Serviceno = s1[0].ToString();
                    Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
                    objbll.AddbusDestinationpoints(objbo);
                   

                }
            }
        }
    }
}