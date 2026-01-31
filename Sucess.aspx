<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sucess.aspx.cs" Inherits="BillionBank_Tshidiso_.Sucess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 365px;
            width: 855px;
        }
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body style="height: 359px; width: 885px">
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;
        <div style="height: 270px; width: 841px; background-color: #006666">
            <asp:Panel ID="Panel2" runat="server" Height="51px" style="font-size: xx-large; background-color: #999999">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style1">Sucess, Welcome to Billion Banks</span> !</asp:Panel>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please click the button below to enter your new login&#39;s
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Click here to login
            <asp:Button ID="btn_Success" runat="server" OnClick="btn_Success_Click" style="margin-left: 31px" Text="Login " Width="285px" />
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="68px" style="background-color: #999999" Width="845px">
        </asp:Panel>
    </form>
</body>
</html>
