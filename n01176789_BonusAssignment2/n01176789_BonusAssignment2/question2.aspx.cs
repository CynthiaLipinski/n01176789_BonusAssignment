using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01176789_BonusAssignment2
{
    public partial class question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> Days = new List<string>();
            Days.Add("Monday");
            Days.Add("Tuesday");
            Days.Add("Wednesday");
            Days.Add("Thursday");
            Days.Add("Friday");
            Days.Add("Saturday");
            Days.Add("Sunday");

            calendar_summary.InnerHtml = " ";
            for (var i = 1; i <= 31; i++)
            {
                if (days.Items[i % 7].Selected == true)
                {
                    calendar_summary.InnerHtml += " October " + i + " is a " + Days[i % 7] + " is a work day <br>";
                }
                else
                {
                    calendar_summary.InnerHtml += " October " + i + " is a " + Days[i % 7] + " is a rest day <br>";
                }
            }

        }
     
    }

}


