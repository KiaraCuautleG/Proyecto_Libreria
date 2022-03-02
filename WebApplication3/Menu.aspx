<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<style>
    .encabezado{
        position:relative;
        background-color: #CF9262;
         text-align:center;
        width:100%;
        height:130px;
    }
    .centro{
        background-color: #ffffff;
        position:relative;
        text-align:center;
        left:20%;
        width:800px;
        height:900px;
        
    }
    .boton{
        margin-top:30px;
        height:50px;
        width:160px;
    }

</style>
<body style="background:#F2A970">
    
   
    <div class="encabezado" >
        <form id="form1" runat="server">
        
            <asp:Button ID="Button1" CssClass="btn btn-dark boton"  runat="server" Text="LIBROS" OnClick="Button1_Click" />
            <asp:Button ID="Button2" CssClass="btn btn-dark boton" runat="server" Text="SUCURSAL" OnClick="Button2_Click" />
            <asp:Button ID="Button3" CssClass="btn btn-dark boton" runat="server" Text="INVENTARIO" OnClick="Button3_Click" />
            <asp:Button ID="Button4" CssClass="btn btn-dark boton"  runat="server" Text="FACTURAS" OnClick="Button4_Click" />
            <asp:Button ID="Button5" CssClass="btn btn-dark boton" runat="server" Text="EMPLEADO" OnClick="Button5_Click" />
         </form>
    </div>
    <div class="centro">
        <img src="img/ima1.jpg" style="margin-top:50px;" class="rounded" width="700px" height="700px">
    </div>
    
</body>
</html>
