<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturas.aspx.cs" Inherits="WebApplication3.WebForm5" %>

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
            
        <asp:Label ID="Label1" CssClass="label" runat="server" Text="FACTURA"></asp:Label> 
            <br />
         
        <br />
        <asp:Label ID="Label2" CssClass="label" runat="server" Text="Fecha Factura: "></asp:Label>
        <asp:Calendar ID="calendar_fecha_fac" runat="server"></asp:Calendar>
        <asp:Label CssClass="label" ID="Label3" runat="server" Text="Sucursal: "></asp:Label>
            <br />
        <asp:DropDownList ID="cmb_ID_sucursal_fac" runat="server" DataSourceID="cmb_IDSUCURSAL" DataTextField="NOMBRE" DataValueField="ID_SUCURSAL">
        </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDSUCURSAL" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString14 %>" SelectCommand="SELECT [ID_SUCURSAL], [NOMBRE] FROM [SUCURSAL]"></asp:SqlDataSource>
            
        <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_factura" runat="server" Text="Enviar" OnClick="btn_enviar_factura_Click" />
        <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_factura" runat="server" Text="Ver" OnClick="btn_ver_factura_Click" />
         <br />
        <asp:Label CssClass="label" ID="Label8" runat="server" Text="MODIFICAR "></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label9" runat="server" Text="ID Factura "></asp:Label>
        <asp:TextBox class="input" ID="txt_modificar_factura" runat="server"></asp:TextBox>
        <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_factura" runat="server" Text="Modificar" OnClick="btn_modificar_factura_Click" />
        <asp:GridView class="table" ID="tablas_facturas" runat="server">
            </asp:GridView>
        </div>
        <br />

        <div class="centro">
        <asp:Label CssClass="label" ID="Label7" runat="server" Text="DETALLES FACTURA "></asp:Label>
        <br />
        <asp:Label CssClass="label" ID="Label4" runat="server" Text="ID_factura: "></asp:Label>
        <asp:DropDownList ID="cmb_IDFact_DetFac" runat="server" DataSourceID="cmb_IDFactura" DataTextField="ID_FACTURA" DataValueField="ID_FACTURA">
        </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDFactura" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString15 %>" SelectCommand="SELECT [ID_FACTURA] FROM [FACTURA]"></asp:SqlDataSource>
        <asp:Label CssClass="label" ID="Label5" runat="server" Text="ID_libro: "></asp:Label>
        <asp:DropDownList ID="cmb_IDLibro_DetFac" runat="server" DataSourceID="cmb_IDLibro" DataTextField="NOMBRE" DataValueField="ID_LIBRO">
        </asp:DropDownList>   
            <asp:SqlDataSource ID="cmb_IDLibro" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString16 %>" SelectCommand="SELECT [ID_LIBRO], [NOMBRE] FROM [LIBRO]"></asp:SqlDataSource>
        <asp:Label CssClass="label" ID="Label6" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox class="input" ID="txt_cantidad_detFac" runat="server"></asp:TextBox>
         <br />    
        <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_detFact" runat="server" Text="Enviar" OnClick="btn_enviar_detFact_Click" />
        <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_detFact" runat="server" Text="Ver" OnClick="btn_ver_detFact_Click" />
        <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_detFact" runat="server" Text="Modificar" OnClick="btn_modificar_detFact_Click" /> 
            <asp:GridView class="table" ID="tabla_detalles_factura" runat="server">
            </asp:GridView>
        </div>
        
    </form>
</body>
</html>
