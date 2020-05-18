<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ECS_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ECS Web</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" id="ScriptManager1" />
        <asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
            <contenttemplate>
                <asp:Timer id="Timer1" runat="server"
                    Interval="5000" 
                    OnTick="Timer1_Tick">
                </asp:Timer>
                <label >Environmental Control System (ECS Web)</label> <br />
                <label >ENGR 102 - Class Project</label> <br />
                <asp:Label id="label1" runat="server"></asp:Label> <br />
                <asp:Label id="message" runat="server"></asp:Label> <br /><br />
                <asp:ListBox runat="server" ID="dataList" /> <br />
            </contenttemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
