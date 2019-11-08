<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question3.aspx.cs" Inherits="n01176789_BonusAssignment3.question3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment: Question 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Question 3</h1>
            <p>Please enter the amount of tickets you would like to purchase:</p>
                <asp:TextBox runat="server" ID="ticket_amount"></asp:TextBox>
                <asp:CustomValidator runat="server" 
                    ControlToValidate="ticket_amount" 
                    ErrorMessage="This is not a valid number!" OnServerValidate="Ticket_Validate">
                </asp:CustomValidator>
                <div id="ticket_summary" runat="server"></div>
            </section>
            <asp:Button runat="server" Text="Submit" />
    </form>
</body>
</html>
