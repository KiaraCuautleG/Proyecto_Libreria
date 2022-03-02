<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="WebApplication3.WebForm4" %>

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
         border-top:30px;
        
        left:15%;
        width:950px;
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
            <asp:Label CssClass="label" ID="Label1" runat="server" Text="TIPO DE EMPLEADO"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label2" runat="server" Text="Descripción: "></asp:Label>
            <asp:TextBox class="input" ID="txt_descripcion_TiEmpleado" runat="server"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_TiEmpleado" runat="server" Text="Enviar" OnClick="btn_enviar_TiEmpleado_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_TiEmpleado" runat="server" Text="Ver" OnClick="btn_ver_TiEmpleado_Click" />
             <br />
            <asp:Label CssClass="label" ID="Label18" runat="server" Text="ID TIPO DE EMPLEADO"></asp:Label>
            <asp:TextBox class="input" ID="txt_modificar_TiEm" runat="server" ></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_TiEmpleado" runat="server" Text="Modificar" OnClick="btn_modificar_TiEmpleado_Click" />
            <asp:GridView class="table" ID="tabla_tipo_empleado" runat="server">
            </asp:GridView>
        </div>
         
        <div class="centro">
            <asp:Label CssClass="label" ID="Label3" runat="server" Text="EMPLEADO"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label4" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox class="input" ID="txt_nombre_emple" runat="server"></asp:TextBox>

            <asp:Label CssClass="label" ID="Label5" runat="server" Text="Apellido Paterno: "></asp:Label>
            <asp:TextBox class="input" ID="txt_appaterno_emple" runat="server"></asp:TextBox>

            <asp:Label CssClass="label" ID="Label6" runat="server" Text="Apellido Materno: "></asp:Label>
            <asp:TextBox class="input" ID="txt_apmaterno_emple" runat="server"></asp:TextBox>
            <br />
            <asp:Label CssClass="label" ID="Label7" runat="server" Text="Dirección: "></asp:Label>
            <asp:TextBox class="input" ID="txt_direccion_emple" runat="server"></asp:TextBox>

            <asp:Label CssClass="label" ID="Label8" runat="server" Text="Sexo: "></asp:Label>
            <asp:DropDownList ID="cmb_sexo_emple" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femenino</asp:ListItem>
            </asp:DropDownList>

            <asp:Label CssClass="label" ID="Label9" runat="server" Text="Fecha de nacimiento: "></asp:Label>
            <asp:Calendar ID="calendar_fechaNac" runat="server"></asp:Calendar>

            <asp:Label CssClass="label" ID="Label10" runat="server" Text="ID_tipo_empleado"></asp:Label>
            <asp:DropDownList ID="cmb_IDTiEmp_emple" runat="server" DataSourceID="cmb_IDTIEmpleado" DataTextField="DESCRIPCION" DataValueField="ID_TIPO_EMPLEADO">
           </asp:DropDownList>

            <asp:SqlDataSource ID="cmb_IDTIEmpleado" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString17 %>" SelectCommand="SELECT [ID_TIPO_EMPLEADO], [DESCRIPCION] FROM [TIPO_EMPLEADO]"></asp:SqlDataSource>

            <asp:Label CssClass="label" ID="Label11" runat="server" Text="ID_sucursal"></asp:Label>
            <asp:DropDownList ID="cmb_IDSucur_emple" runat="server" DataSourceID="cmb_IDSucursal" DataTextField="NOMBRE" DataValueField="ID_SUCURSAL">
            </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDSucursal" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString3 %>" SelectCommand="SELECT [ID_SUCURSAL], [NOMBRE] FROM [SUCURSAL]"></asp:SqlDataSource>
            <br />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_emple" runat="server" Text="Enviar" OnClick="btn_enviar_emple_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_emple" runat="server" Text="Ver" OnClick="btn_ver_emple_Click" />
            <br />
            <asp:Label CssClass="label" ID="Label19" runat="server" Text="ID EMPLEADO"></asp:Label>
            <asp:TextBox class="input" ID="txt_idEmpleado_emple" runat="server" ></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_emple" runat="server" Text="Modificar" OnClick="btn_modificar_emple_Click" />

            <asp:GridView  ID="tabla_empleado" runat="server">
            </asp:GridView>

        </div>

        <div class="centro">
            <asp:Label CssClass="label" ID="Label12" runat="server" Text="EMAIL DEL EMPLEADO"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label13" runat="server" Text="Descripción: "></asp:Label>
            <asp:TextBox class="input" ID="txt_descripcion_email" runat="server"></asp:TextBox>
            <asp:Label CssClass="label" ID="Label14" runat="server" Text="ID Empleado: "></asp:Label>
            <asp:DropDownList ID="cmb_empleado_email" runat="server" DataSourceID="cmb_IDEmpleado" DataTextField="ID_EMPLEADO" DataValueField="ID_EMPLEADO">
            </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDEmpleado" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString4 %>" SelectCommand="SELECT [ID_EMPLEADO], [NOMBRE] FROM [EMPLEADO]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
           

            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_emailEmple" runat="server" Text="Enviar" OnClick="btn_enviar_emailEmple_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_emailEmple" runat="server" Text="Ver" OnClick="btn_ver_emailEmple_Click" />
            <br />
            <asp:Label CssClass="label" ID="Label20" runat="server" Text="ID Email: "></asp:Label>
             <asp:TextBox class="input" ID="txt_modificar_email" runat="server"></asp:TextBox>
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_emailEmple" runat="server" Text="Modificar" OnClick="btn_modificar_emailEmple_Click" />
             <asp:GridView class="table" ID="tabla_email_em" runat="server">
            </asp:GridView>
        </div>

        <div class="centro">
            <asp:Label CssClass="label" ID="Label15" runat="server" Text="TELEFONO DEL EMPLEADO"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="Label16" runat="server" Text="Descripción: "></asp:Label>
            <asp:TextBox class="input" ID="txt_descripcion_telefono" runat="server"></asp:TextBox>
            <asp:Label CssClass="label" ID="Label17" runat="server" Text="ID Empleado: "></asp:Label>
            <asp:DropDownList ID="cmb_empleado_telefono" runat="server" DataSourceID="cmb_IDEmpleadoTe" DataTextField="ID_EMPLEADO" DataValueField="ID_EMPLEADO">
            </asp:DropDownList>
            <asp:SqlDataSource ID="cmb_IDEmpleadoTe" runat="server" ConnectionString="<%$ ConnectionStrings:PROYECTO_LIBRERIASConnectionString5 %>" SelectCommand="SELECT [ID_EMPLEADO], [NOMBRE] FROM [EMPLEADO]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
            

            <asp:Button CssClass="btn btn-dark boton" ID="btn_enviar_teleEmple" runat="server" Text="Enviar" OnClick="btn_enviar_teleEmple_Click" />
            <asp:Button CssClass="btn btn-dark boton" ID="btn_ver_teleEmple" runat="server" Text="Ver" OnClick="btn_ver_teleEmple_Click" />
            <br />
            <asp:Label CssClass="label" ID="Label21" runat="server" Text="ID Telefono: "></asp:Label>
             <asp:TextBox class="input" ID="txt_modificar_telefono" runat="server"></asp:TextBox>
            
            <asp:Button CssClass="btn btn-dark boton" ID="btn_modificar_teleEmple" runat="server" Text="Modificar" OnClick="btn_modificar_teleEmple_Click" />
            <asp:GridView class="table" ID="tabla_telefono_em" runat="server">
            </asp:GridView>
        </div>
        
    </form>
</body>
</html>
