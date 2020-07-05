using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businessobjects;
using Businesslogiclayer;

namespace presentationlayer
{
    public partial class AddPickupPoints : System.Web.UI.Page
    {
        private void AutogeneratePid()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
          string pid =  objbll.AutogeneratePickPoint();
            txtpid.Text = pid;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {

                AutogeneratePid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.pid = txtpid.Text;
            objbo.pname = txtpname.Text;
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
           int i = objbll.Addpickuppoint(objbo);
            if(i==1)
            {
                Response.Write("ADDED");
                txtpname.Text = "";
                AutogeneratePid();
            }
            else
            {
                Response.Write("FAILED");
            }
        }
    }
}