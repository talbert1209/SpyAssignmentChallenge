<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpyAssignmentChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: Arial, Helvetica, sans-serif">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <h1>Spy Assignment Form</h1>
            <p>
                Spy Code Name:
                <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
                <br />
                <br />
                New Assignment Name:
                <asp:TextBox ID="assignmnetNameTextBox" runat="server"></asp:TextBox>
                <br />
                <br />
                End Date of Previous Assignment:<br />
                <asp:Calendar ID="previousEndDateCalendar" runat="server"></asp:Calendar>
                <br />
                Start Date of New Assignment:<br />
                <asp:Calendar ID="newStartDateCalendar" runat="server"></asp:Calendar>
                <br />
                Projected End Date of New Assignment:<br />
                <asp:Calendar ID="newEndDateCalendar" runat="server"></asp:Calendar>
                <br />
                <br />
                <asp:Button ID="assignSpyButton" runat="server" Text="Assign Spy" />
                <br />
                <br />
                <asp:Label ID="resultsLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
