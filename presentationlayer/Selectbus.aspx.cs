using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentationlayer
{
    public partial class Selectbus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = int.Parse(e.CommandArgument.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[index];
            Label l1 = (Label)row.FindControl("Label9");
            TextBox10.Text = l1.Text;
            Session["svno"] = l1.Text;
            l1 = (Label)row.FindControl("Label8");
            TextBox11.Text = l1.Text;
            Session["fromplace"] = TextBox11.Text;
            l1 = (Label)row.FindControl("Label7");
            TextBox12.Text = l1.Text;
            Session["toplace"] = TextBox12.Text;
           
            
            l1 = (Label)row.FindControl("Label6");
            TextBox13.Text = l1.Text;
            Session["bustype"] = TextBox13.Text;
           
            l1 = (Label)row.FindControl("Label5");
            TextBox14.Text = l1.Text;
            Session["tname"] = TextBox14.Text;
           
            l1 = (Label)row.FindControl("Label4");
            TextBox15.Text = l1.Text;
            Session["fare"] = TextBox15.Text;
           
            l1 = (Label)row.FindControl("Label3");
            TextBox16.Text = l1.Text;
            Session["departuretime"] = TextBox16.Text;
           

            l1 = (Label)row.FindControl("Label2");
            TextBox17.Text = l1.Text;
            Session["arrivaltime"] = TextBox17.Text;



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bookseat.aspx");
        }
    }
}