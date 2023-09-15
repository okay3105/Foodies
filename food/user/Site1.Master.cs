using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace food.user
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.Url.AbsoluteUri.ToString().Contains("Defualt.aspx"))
            {
                form1.Attributes.Add("class", "sub_page");
            }
            else
            {
                form1.Attributes.Remove("class");
                //load the control
                Control sliderUserControl = (Control)Page.LoadControl("SliderUserControl1.ascx");

                //add the control to the panel
                pnlSliderUC.Controls.Add(sliderUserControl);
            }
        }
    }
}