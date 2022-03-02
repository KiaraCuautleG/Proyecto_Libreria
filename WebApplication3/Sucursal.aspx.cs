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
    public partial class WebForm3 : System.Web.UI.Page
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

        protected void btn_enviar_sucursal_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_SUCURSAL";

            SqlParameter insertNombre_sucursal = new SqlParameter();
            insertNombre_sucursal.ParameterName = "@NOMBRE";
            insertNombre_sucursal.SqlDbType = SqlDbType.VarChar;
            insertNombre_sucursal.Value = txt_nombre_sucursal.Text;

            SqlParameter inserDirec_sucursal = new SqlParameter();
            inserDirec_sucursal.ParameterName = "@DIRECCION";
            inserDirec_sucursal.SqlDbType = SqlDbType.VarChar;
            inserDirec_sucursal.Value = txt_direc_sucursal.Text;

            SqlParameter insertEmail_sucursal = new SqlParameter();
            insertEmail_sucursal.ParameterName = "@EMAIL";
            insertEmail_sucursal.SqlDbType = SqlDbType.VarChar;
            insertEmail_sucursal.Value = txt_email_sucursal.Text;

            SqlParameter insertTelef_sucursal = new SqlParameter();
            insertTelef_sucursal.ParameterName = "@TELEFONO";
            insertTelef_sucursal.SqlDbType = SqlDbType.VarChar;
            insertTelef_sucursal.Value = txt_telefono_sucursal.Text;

           

            comando.Parameters.Add(insertNombre_sucursal);
            comando.Parameters.Add(inserDirec_sucursal);
            comando.Parameters.Add(insertEmail_sucursal);
            comando.Parameters.Add(insertTelef_sucursal);
     

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();

        }

        protected void btn_ver_sucursal_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM SUCURSAL";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_sucursal.DataSource = tabla1;
            tabla_sucursal.DataBind();
        }

        protected void btn_modificar_sucursal_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_SUCURSAL";

            SqlParameter modificar_sucursal = new SqlParameter();
            modificar_sucursal.ParameterName = "@ID_SUCURSAL";
            modificar_sucursal.SqlDbType = SqlDbType.Int;
            modificar_sucursal.Value = txt_modificar_sucursal.Text;

            SqlParameter insertNombre_sucursal = new SqlParameter();
            insertNombre_sucursal.ParameterName = "@NOMBRE";
            insertNombre_sucursal.SqlDbType = SqlDbType.VarChar;
            insertNombre_sucursal.Value = txt_nombre_sucursal.Text;

            SqlParameter inserDirec_sucursal = new SqlParameter();
            inserDirec_sucursal.ParameterName = "@DIRECCION";
            inserDirec_sucursal.SqlDbType = SqlDbType.VarChar;
            inserDirec_sucursal.Value = txt_direc_sucursal.Text;

            SqlParameter insertEmail_sucursal = new SqlParameter();
            insertEmail_sucursal.ParameterName = "@EMAIL";
            insertEmail_sucursal.SqlDbType = SqlDbType.VarChar;
            insertEmail_sucursal.Value = txt_email_sucursal.Text;

            SqlParameter insertTelef_sucursal = new SqlParameter();
            insertTelef_sucursal.ParameterName = "@TELEFONO";
            insertTelef_sucursal.SqlDbType = SqlDbType.VarChar;
            insertTelef_sucursal.Value = txt_telefono_sucursal.Text;


            
            comando.Parameters.Add(modificar_sucursal);
            comando.Parameters.Add(insertNombre_sucursal);
            comando.Parameters.Add(inserDirec_sucursal);
            comando.Parameters.Add(insertEmail_sucursal);
            comando.Parameters.Add(insertTelef_sucursal);


            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();

        }
    }
}