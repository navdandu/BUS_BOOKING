using System;
namespace presentationlayer
{
    public partial class Addbus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            txtsvno.Text = objbll.AutogenerateSvno();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.Serviceno = txtsvno.Text;
            objbo.Fromplace = txtfplace.Text;
            objbo.Toplace = txttoplace.Text;
            objbo.Capacity = txtcapacity.Text;
            objbo.Depaturetime = txtdeptime.Text;
            objbo.Arrivaltime = txtarrivaltime.Text;
            objbo.Travelagencyname = txtagencyname.Text;
            objbo.bustype =ddlbustype.SelectedItem.Text;
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.Addbus(objbo);
            if(i==1)
            {
                Response.Write("BUS IS ADDED");
                txtfplace.Text = "";
                txttoplace.Text = "";
                txtcapacity.Text = "";
               txtdeptime.Text = "";
                txtarrivaltime.Text = "";
                txtagencyname.Text = "";
                txtsvno.Text = objbll.AutogenerateSvno();
                txtsvno.Text = objbll.AutogenerateSvno();
            }
            else
            {
                Response.Write("FAILED");
            }

            


        }
    }
}