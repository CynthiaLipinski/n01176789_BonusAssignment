using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01176789_BonusAssignment
{
    public partial class question1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    result_summary.InnerHtml = "";
                    int X_Coordinate = Convert.ToInt32(x_coordinate.Text);
                    int Y_Coordinate = Convert.ToInt32(y_coordinate.Text);

                    if (X_Coordinate > 0 && Y_Coordinate > 0)
                    {
                        result_summary.InnerHtml = "Qudrant 1";
                    }
                    else if (X_Coordinate < 0 && Y_Coordinate > 0)
                    {
                        result_summary.InnerHtml = "Qudrant 2";
                    }
                    else if (X_Coordinate < 0 && Y_Coordinate < 0)
                    {
                        result_summary.InnerHtml = "Qudrant 3";
                    }
                    else if (X_Coordinate > 0 && Y_Coordinate < 0)
                    {
                        result_summary.InnerHtml = "Qudrant 4";
                    }

                }
            }
        }

    }
}