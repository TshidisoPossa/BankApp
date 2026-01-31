<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBalance.aspx.cs" Inherits="BillionBank_Tshidiso_.CheckBalance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
<body style="height: 415px; width: 708px">
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" ForeColor="Black" Height="415px" Width="703px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2">Welcome to Online Banking&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <br class="auto-style2" />
                <br />
                <asp:Panel ID="Panel2" runat="server" BackColor="#336699" Height="263px" Width="698px" style="background-color: #006666">
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please enter your Id Number below?<br />
                    <br />
                    <br />
                    <asp:Label ID="LblBalance" runat="server" style="font-size: x-large" Text="Current Balance"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtAccount" runat="server" Height="38px" Width="217px" style="background-color: #999999"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_Reset" runat="server" Height="38px" OnClick="btn_Reset_Click" style="margin-left: 0px; background-color: #999999;" Text="Reset" Width="110px" />
                    <asp:Button ID="btn_Check" runat="server" Height="37px" OnClick="btn_Check_Click" style="margin-left: 1px; background-color: #999999;" Text="Check " Width="112px" />
                    <asp:Button ID="btn_Back" runat="server" Height="37px" OnClick="btn_Back_Click" Text="Back " Width="112px" style="background-color: #999999" />
                </asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
