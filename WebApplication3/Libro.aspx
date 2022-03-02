<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libro.aspx.cs" Inherits="WebApplication3.WebForm2" %>

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
            <p>
            <asp:Button ID="Button1" CssClass="btn btn-dark botonPrin" runat="server" Text="Regresar" OnClick="Button1_Click" />
            </p>
        </div>
        <div class="centro">
            
            <asp:Label CssClass="label" ID="Label1" runat="server" Text="AUTOR"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox class="input" ID="txt_nombre_autor" runat="server" ></asp:TextBox>
            <p>
            <asp:Button ID="btn_enviar_autor" CssClass="btn btn-dark boton" runat="server" Text="Enviar" OnClick="btn_enviar_autor_Click" />
            <asp:Button ID="btn_ver_autor" CssClass="btn btn-dark boton" runat="server" Text="Ver" OnClick="btn_ver_autor_Click" />
            <br />
            <asp:Label ID="Label13" CssClass="label" runat="server" Text="ID AUTOR"></asp:Label>
            <asp:TextBox class="input" ID="txt_modificar_autor" runat="server" ></asp:TextBox>
            <asp:Button ID="btn_modificar_autor" CssClass="btn btn-dark boton" runat="server" Text="Modificar" OnClick="btn_modificar_autor_Click" />

            </p>
            <p>
            <asp:GridView class="table" ID="tabla_autor" runat="server">
            </asp:GridView>
            </p>
        </div>

        <div class="centro">
            <asp:Label CssClass="label" ID="Label3" runat="server" Text="EDITORIAL"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="lbl_Descripcion" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox class="input" ID="txt_nombre_edi" runat="server"></asp:TextBox> 
            <asp:Label CssClass="label" ID="Label4" runat="server" Text="Telefono: "></asp:Label>
            <asp:TextBox class="input" ID="txt_telefono_edi" runat="server"></asp:TextBox>
            <br />
            <asp:Label CssClass="label" ID="Label6" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox class="input" ID="txt_email_edi" runat="server"></asp:TextBox>
            <asp:Label CssClass="label" ID="Label5" runat="server" Text="Direccion: "></asp:Label>
            <asp:TextBox class="input" ID="txt_direccion_edi" runat="server"></asp:TextBox>

            <p>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_edi" runat="server" Text="Enviar" OnClick="btn_enviar_edi_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_edi" runat="server" Text="Ver" OnClick="btn_ver_edi_Click" />
             <br />
            <asp:Label CssClass="label" ID="Label14" runat="server" Text="ID EDITORIAL"></asp:Label>
            <asp:TextBox class="input" ID="txt_modificar_editorial" runat="server" ></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_edi" runat="server" Text="Modificar" OnClick="btn_modificar_edi_Click" />

            </p>
            <asp:GridView class="table" ID="tabla_editorial" runat="server">
            </asp:GridView>
        </div>
        <div class="centro">
            <asp:Label CssClass="label" ID="lbl_libro" runat="server" Text="LIBRO "></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label7" runat="server" Text="ID_Libro: "></asp:Label>
            <asp:TextBox class="input" ID="txt_id_libro" runat="server"></asp:TextBox>
            <asp:Label CssClass="label" ID="Label8" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox class="input" ID="txt_nombre_libro" runat="server"></asp:TextBox>
            <asp:Label CssClass="label" ID="Label9" runat="server" Text="ID_Autor: "></asp:Label>
            <asp:DropDownList ID="cmb_ID_AUTOR" runat="server" DataSourceID="cmb_IDAUTOR" DataTextField="NOMBRE" DataValueField="ID_AUTOR">
            </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDAUTOR" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString11 %>" SelectCommand="SELECT * FROM [AUTOR]"></asp:SqlDataSource>
            <br />
            <asp:Label CssClass="label" ID="Label10" runat="server" Text="Fecha de publicación: "></asp:Label>
            <asp:Calendar ID="cal_fechaPub_libro"  runat="server"></asp:Calendar>
            
            <asp:Label CssClass="label" ID="Label11" runat="server" Text="ID_editorial: "></asp:Label>

            <asp:DropDownList ID="cmb_ID_EDITORIAL" runat="server" DataSourceID="cmb_IDEDITORIAL" DataTextField="NOMBRE" DataValueField="ID_EDITORIAL">
            </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDEDITORIAL" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString13 %>" SelectCommand="SELECT [ID_EDITORIAL], [NOMBRE] FROM [EDITORIAL]"></asp:SqlDataSource>
            <asp:Label CssClass="label" ID="Label12" runat="server" Text="Costo: "></asp:Label>
            <asp:TextBox class="input" ID="txt_costo_libro" runat="server"></asp:TextBox>
            <asp:GridView class="table" ID="tabla_libro" runat="server">
            </asp:GridView>
            <br />
             <p>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_libro" runat="server" Text="Enviar" OnClick="btn_enviar_libro_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_libro" runat="server" Text="Ver" OnClick="btn_ver_libro_Click" />
             <br />
            <asp:Label ID="Label15" CssClass="label" runat="server" Text="ID LIBRO"></asp:Label>
            <asp:TextBox class="input" ID="txt_modificarIDlibro" runat="server" ></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_libro" runat="server" Text="Modificar" OnClick="btn_modificar_libro_Click" />

            </p>
        </div>
        
        
        
        
        
        
        
    </form>
</body>
</html>
