﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Businessobjects;
using Businesslogiclayer;

namespace presentationlayer
{
    public partial class Adddestinationpoints : System.Web.UI.Page
    {
        private void AutogenerateDid()
        {
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            string s =objbll.AutogenerateDid();
            TextBox1.Text = s;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                AutogenerateDid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Businessobjects.BusinessObjectsclass objbo = new Businessobjects.BusinessObjectsclass();
            objbo.Did = TextBox1.Text;
            objbo.Dname = TextBox1.Text;
            Businesslogiclayer.Businesslogiclayerclass objbll = new Businesslogiclayer.Businesslogiclayerclass();
            int i = objbll.Adddestinationpoint(objbo);
            if(i==1)
            {
                TextBox2.Text = "";
              string s =  objbll.AutogenerateDid();
                TextBox1.Text = s;  
                Response.Write("Record inserted");
            }
            else
            {
                Response.Write("failed");
            }











        }
    }
}