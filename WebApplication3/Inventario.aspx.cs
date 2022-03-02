using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class Inventario : System.Web.UI.Page
    {
        SqlConnection conectar;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        SqlParameter parametro;
        DataTable tabla1;
        protected void Page_Load(object sender, EventArgs e)
        {
            conectar = new SqlConnection("Data Source=LAPTOP-7P9OO2OA\\SQLEXPRESS;Initial Catalog=PROYECTO_LIBRERIAS; Integrated Security=True");
        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btn_enviar_inventario_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_INVENTARIO";


            SqlParameter insertIDFACTURA_inven = new SqlParameter();
            insertIDFACTURA_inven.ParameterName = "@ID_SUCURSAL";
            insertIDFACTURA_inven.SqlDbType = SqlDbType.Int;
            insertIDFACTURA_inven.Value = cmb_idsucursal_inven.SelectedValue;

            SqlParameter insertIDLIBRO_inven = new SqlParameter();
            insertIDLIBRO_inven.ParameterName = "@ID_LIBRO";
            insertIDLIBRO_inven.SqlDbType = SqlDbType.Int;
            insertIDLIBRO_inven.Value = cmb_idlibro_inven.SelectedValue;

            SqlParameter insertCantidad_inven = new SqlParameter();
            insertCantidad_inven.ParameterName = "@CANTIDAD";
            insertCantidad_inven.SqlDbType = SqlDbType.Int;
            insertCantidad_inven.Value = txt_cantidad_inven.Text;

            comando.Parameters.Add(insertIDFACTURA_inven);
            comando.Parameters.Add(insertIDLIBRO_inven);
            comando.Parameters.Add(insertCantidad_inven);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();


        }

        protected void btn_ver_inventario_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.StoredProcedure;
            //se trae el nombre del procedimiento 
            comando.CommandText = "CONSULTAR_INVENTARIO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_inventario.DataSource = tabla1;
            tabla_inventario.DataBind();

        }

        protected void btn_modificar_inventario_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_INVENTARIO";


            SqlParameter insertIDFACTURA_inven = new SqlParameter();
            insertIDFACTURA_inven.ParameterName = "@ID_SUCURSAL";
            insertIDFACTURA_inven.SqlDbType = SqlDbType.Int;
            insertIDFACTURA_inven.Value = cmb_idsucursal_inven.SelectedValue;

            SqlParameter insertIDLIBRO_inven = new SqlParameter();
            insertIDLIBRO_inven.ParameterName = "@ID_LIBRO";
            insertIDLIBRO_inven.SqlDbType = SqlDbType.Int;
            insertIDLIBRO_inven.Value = cmb_idlibro_inven.SelectedValue;

            SqlParameter insertCantidad_inven = new SqlParameter();
            insertCantidad_inven.ParameterName = "@CANTIDAD";
            insertCantidad_inven.SqlDbType = SqlDbType.Int;
            insertCantidad_inven.Value = txt_cantidad_inven.Text;

            comando.Parameters.Add(insertIDFACTURA_inven);
            comando.Parameters.Add(insertIDLIBRO_inven);
            comando.Parameters.Add(insertCantidad_inven);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }
    }
}