using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspx4_19795360
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String[] strCategoryArray = new String[5];
            strCategoryArray[0] = "Footwear - Men's ";
            strCategoryArray[1] = "Clothing - Men's ";
            strCategoryArray[2] = "Racquets";
            strCategoryArray[3] = "Footwear - Women's ";
            strCategoryArray[4] = "Clothing - Women's ";

            Session["strCategoryArray"] = strCategoryArray;

            Response.Redirect("WebForm2.aspx");
        
    }
}