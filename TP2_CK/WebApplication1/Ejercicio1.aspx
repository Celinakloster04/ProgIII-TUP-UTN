<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="WebApplication1.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 58px;
        }
        .auto-style3 {
            width: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 5px">
            Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProd1" runat="server" Width="207px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCant1" runat="server"></asp:TextBox>
        </div>

        <div style="padding: 5px">
            Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProd2" runat="server" Width="207px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCant2" runat="server"></asp:TextBox>
        </div>
        <div style="padding: 5px">
            <asp:Button ID="btnAgregar" runat="server" Text="Generar tabla" Width="180px" OnClick="btnAgregar_Click" />
        </div>
        <div style="padding: 5px">
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
