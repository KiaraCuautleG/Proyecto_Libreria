<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sucursal.aspx.cs" Inherits="WebApplication3.WebForm3" %>

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
         text-align:right;
        width:100%;
        height:130px;
    }
    .centro{
        background-color: #ffffff;
        position:relative;
        
        left:15%;
        width:900px;
    }
    .botonPrin{
        margin-top:30px;
        height:50px;
        width:160px;
    }
     .boton{
        
        margin:15px;
        height:40px;
        width:140px;
    }
    .input{
        width:250px;
        margin:15px;
    }
    .label{
        margin:30px;
        font-family: cursive;
    }
    
</style>
<body style="background:#F2A970">
    <form id="form1" runat="server">
        <div class="encabezado">
            <asp:Button CssClass="btn btn-dark botonPrin" ID="btn_regresar" runat="server" Text="Regresar" OnClick="btn_regresar_Click" />
        </div>
        <div class="centro">
            <asp:Label CssClass="label" ID="Label1" runat="server" Text="SUCURSAL"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label2" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox class="input" ID="txt_nombre_sucursal" runat="server"></asp:TextBox>
            
            <asp:Label CssClass="label" ID="Label" runat="server" Text="Dirección: "></asp:Label>
            <asp:TextBox class="input" ID="txt_direc_sucursal" runat="server"></asp:TextBox>
            <br />
            <asp:Label CssClass="label" ID="Label4" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox class="input" ID="txt_email_sucursal" runat="server"></asp:TextBox>
            
            <asp:Label CssClass="label" ID="Label5" runat="server" Text="Telefono: "></asp:Label>
            <asp:TextBox class="input" ID="txt_telefono_sucursal" runat="server"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_sucursal" runat="server" Text="Enviar" OnClick="btn_enviar_sucursal_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_sucursal" runat="server" Text="Ver" OnClick="btn_ver_sucursal_Click" />
            <br />
            <asp:Label CssClass="label" ID="Label3" runat="server" Text="MODIFICAR: "></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label6" runat="server" Text="ID Sucursal: "></asp:Label>
            <asp:TextBox class="input" ID="txt_modificar_sucursal" runat="server"></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_sucursal" runat="server" Text="Modificar" OnClick="btn_modificar_sucursal_Click" />
            <br />
        
        
            <asp:GridView class="table" ID="tabla_sucursal" runat="server">
            </asp:GridView>
        </div>
        
        
    </form>
</body>
</html>
