<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="WebApplication3.Inventario" %>

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
            <asp:Label ID="Label1" CssClass="label" runat="server" Text="INVENTARIO"></asp:Label>
        <br />
        <asp:Label CssClass="label" ID="Label3" runat="server" Text="ID_sucursal"></asp:Label>
        <asp:DropDownList ID="cmb_idsucursal_inven" runat="server" DataSourceID="cmb_IDSUCURSAL" DataTextField="NOMBRE" DataValueField="ID_SUCURSAL">
        </asp:DropDownList>
        <asp:SqlDataSource ID="cmb_IDSUCURSAL" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString9 %>" SelectCommand="SELECT [ID_SUCURSAL], [NOMBRE] FROM [SUCURSAL]"></asp:SqlDataSource>
        <br />
        <asp:Label CssClass="label" ID="Label2" runat="server" Text="ID_libro"></asp:Label>
        <asp:DropDownList ID="cmb_idlibro_inven" runat="server" DataSourceID="cmb_IDLIBRO" DataTextField="NOMBRE" DataValueField="ID_LIBRO">
        </asp:DropDownList>
        <asp:SqlDataSource ID="cmb_IDLIBRO" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString10 %>" SelectCommand="SELECT [ID_LIBRO], [NOMBRE] FROM [LIBRO]"></asp:SqlDataSource>
        <br />
        <asp:Label CssClass="label" ID="Label4" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox class="input" ID="txt_cantidad_inven" runat="server"></asp:TextBox>
        <p>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_inventario" runat="server" Text="Enviar" OnClick="btn_enviar_inventario_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_inventario" runat="server" Text="Ver" OnClick="btn_ver_inventario_Click" />
            
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_inventario" runat="server" Text="Modificar" OnClick="btn_modificar_inventario_Click" />

            <asp:GridView class="table" ID="tabla_inventario" runat="server">
            </asp:GridView>

        </p>
        </div>
        
        
    </form>
</body>
</html>
