using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01176789_BonusAssignment3
{
    public partial class question3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    ticket_summary.InnerHtml = "";
                    int TicketAmount = Convert.ToInt32(ticket_amount.Text);  
                }
            }
        }

        //the custom validator function is OUTSIDE Page_Load
        protected void Ticket_Validate(object sender, ServerValidateEventArgs e)
        {
            int TicketAmount = Convert.ToInt32(ticket_amount.Text);
            double TicketPrice = 0.25;
            if (TicketAmount <= 50)
            {
                for (var i = 1; i <= (TicketAmount); i = i + 1)
                {
                    ticket_summary.InnerHtml += "You have recieved a bundle of 1! That's " + i.ToString() + " ticket(s)!<br>";
                }
                ticket_summary.InnerHtml += "Your total ticket(s) is " + TicketAmount.ToString() + " and your cost is $" + TicketAmount * TicketPrice;
            } else if (TicketAmount <= 150)
            {
                int remainder = TicketAmount % 2;
                for(var i=2; i <= (TicketAmount - remainder); i = i + 2)
                {
                    ticket_summary.InnerHtml += "You have recieved a bundle of 2! That's " + i.ToString() + " ticket(s)!<br>";
                }
                if(remainder > 0)
                {
                    ticket_summary.InnerHtml += "Your leftover is " + remainder.ToString() + " ticket(s). That's " + TicketAmount.ToString() + " ticket(s)!<br>";
                }
                ticket_summary.InnerHtml += "Your total ticket(s) is " + TicketAmount.ToString() + " and your cost is $" + TicketAmount * TicketPrice;
            }
            else if (TicketAmount <= 300)
            {
                int remainder = TicketAmount % 3;
                for (var i = 3; i <= (TicketAmount - remainder); i = i + 3)
                {
                    ticket_summary.InnerHtml += "You have recieved a bundle of 3! That's " + i.ToString() + " ticket(s)!<br>";
                }
                if (remainder>0)
                {
                    ticket_summary.InnerHtml += "Your leftover is " + remainder.ToString() + " ticket(s). That's " + TicketAmount.ToString() + " ticket(s)!<br>";
                }
                ticket_summary.InnerHtml += "Your total ticket(s) is " + TicketAmount.ToString() + " and your cost is $" + TicketAmount * TicketPrice;
            }
            else if (TicketAmount > 300)
            {
                int remainder = TicketAmount % 5;
                for (var i=5; i <=(TicketAmount - remainder); i = i + 5)
                {
                    ticket_summary.InnerHtml += "You have recieved a bundle of 5! That's " + i.ToString() + " ticket(s)!<br>";
                }
                if (remainder > 0)
                {
                    ticket_summary.InnerHtml += "Your leftover is " + remainder.ToString() + " ticket(s). That's " + TicketAmount.ToString() + " ticket(s)!<br>";
                }
                ticket_summary.InnerHtml += "Your total ticket(s) is " + TicketAmount.ToString() + " and your cost is $" + TicketAmount * TicketPrice;
            }
            else
            {
                ticket_summary.InnerHtml = "";
                e.IsValid = false;
            }

        }
    }
}