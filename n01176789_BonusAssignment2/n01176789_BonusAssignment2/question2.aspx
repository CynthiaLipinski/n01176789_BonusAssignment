<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question2.aspx.cs" Inherits="n01176789_BonusAssignment2.question2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment: Question 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Question 2</h1>
        <section>
            <label for="days">Please check off which days during the week you have class or work.</label>
            <asp:CheckBoxList runat ="server" ID="days">
                <asp:ListItem Value="monday">Monday</asp:ListItem>
                <asp:ListItem Value="tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="friday">Friday</asp:ListItem>
                <asp:ListItem Value="saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
        </section>
        <section>
            <div runat="server" id="calendar_summary"></div>
            <asp:Button runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>
