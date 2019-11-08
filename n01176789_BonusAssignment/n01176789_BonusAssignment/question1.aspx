<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question1.aspx.cs" Inherits="n01176789_BonusAssignment.question1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment: Question 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Question 1</h1>
        <section>
            <label for="x_coordinate">Please enter an X coordinate:</label>
            <asp:TextBox runat="server" ID="x_coordinate"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="x_coordinate" ErrorMessage="Please enter a number."></asp:RequiredFieldValidator>
        </section>
        <section>
            <label for="y_coordinate">Please enter a Y coordinate:</label>
            <asp:TextBox runat="server" ID="y_coordinate"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="y_coordinate" ErrorMessage="Please enter a number."></asp:RequiredFieldValidator>
        </section>
        <section>
            <div runat="server" id="result_summary"></div>
            <asp:Button runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>

                    