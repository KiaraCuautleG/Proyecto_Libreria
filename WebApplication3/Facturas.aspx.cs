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
    public partial class WebForm5 : System.Web.UI.Page
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

        protected void btn_enviar_factura_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_FACTURA";

            SqlParameter insertFecha_Fact = new SqlParameter();
            insertFecha_Fact.ParameterName = "@FECHA_FAC";
            insertFecha_Fact.SqlDbType = SqlDbType.Date;
            insertFecha_Fact.Value = calendar_fecha_fac.SelectedDate;

            SqlParameter insertIDSucursal_Fact = new SqlParameter();
            insertIDSucursal_Fact.ParameterName = "@ID_SUCURSAL";
            insertIDSucursal_Fact.SqlDbType = SqlDbType.Int;
            insertIDSucursal_Fact.Value = cmb_ID_sucursal_fac.SelectedValue;
            
            
            comando.Parameters.Add(insertFecha_Fact);
            comando.Parameters.Add(insertIDSucursal_Fact);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_factura_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.StoredProcedure;
            //se trae el nombre del procedimiento 
            comando.CommandText = "CONSULTAR_FACTURAS";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tablas_facturas.DataSource = tabla1;
            tablas_facturas.DataBind();
        }

        protected void btn_enviar_detFact_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_DETALLES_FACTURA";

            SqlParameter insertIDFactura_DetFact = new SqlParameter();
            insertIDFactura_DetFact.ParameterName = "@ID_FACTURA";
            insertIDFactura_DetFact.SqlDbType = SqlDbType.Int;
            insertIDFactura_DetFact.Value = cmb_IDFact_DetFac.SelectedValue;

            SqlParameter insertIDLibro_DetFact = new SqlParameter();
            insertIDLibro_DetFact.ParameterName = "@ID_LIBRO";
            insertIDLibro_DetFact.SqlDbType = SqlDbType.Int;
            insertIDLibro_DetFact.Value = cmb_IDLibro_DetFac.SelectedValue;

            SqlParameter insertCantidad_DetFact = new SqlParameter();
            insertCantidad_DetFact.ParameterName = "@CANTIDAD";
            insertCantidad_DetFact.SqlDbType = SqlDbType.Int;
            insertCantidad_DetFact.Value = txt_cantidad_detFac.Text;

            comando.Parameters.Add(insertIDFactura_DetFact);
            comando.Parameters.Add(insertIDLibro_DetFact);
            comando.Parameters.Add(insertCantidad_DetFact);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_detFact_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.StoredProcedure;
            //se trae el nombre del procedimiento 
            comando.CommandText = "CONSULTAR_FACT_DET";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_detalles_factura.DataSource = tabla1;
            tabla_detalles_factura.DataBind();
        }

        protected void btn_modificar_factura_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_FACTURA";

            SqlParameter modificar_Fact = new SqlParameter();
            modificar_Fact.ParameterName = "@ID_FACTURA";
            modificar_Fact.SqlDbType = SqlDbType.Int;
            modificar_Fact.Value = txt_modificar_factura.Text;

            SqlParameter insertFecha_Fact = new SqlParameter();
            insertFecha_Fact.ParameterName = "@FECHA_FAC";
            insertFecha_Fact.SqlDbType = SqlDbType.Date;
            insertFecha_Fact.Value = calendar_fecha_fac.SelectedDate;

            SqlParameter insertIDSucursal_Fact = new SqlParameter();
            insertIDSucursal_Fact.ParameterName = "@ID_SUCURSAL";
            insertIDSucursal_Fact.SqlDbType = SqlDbType.Int;
            insertIDSucursal_Fact.Value = cmb_ID_sucursal_fac.SelectedValue;

            comando.Parameters.Add(modificar_Fact);
            comando.Parameters.Add(insertFecha_Fact);
            comando.Parameters.Add(insertIDSucursal_Fact);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_detFact_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_DETALLES_FACTURA";

            SqlParameter insertIDFactura_DetFact = new SqlParameter();
            insertIDFactura_DetFact.ParameterName = "@ID_FACTURA";
            insertIDFactura_DetFact.SqlDbType = SqlDbType.Int;
            insertIDFactura_DetFact.Value = cmb_IDFact_DetFac.SelectedValue;

            SqlParameter insertIDLibro_DetFact = new SqlParameter();
            insertIDLibro_DetFact.ParameterName = "@ID_LIBRO";
            insertIDLibro_DetFact.SqlDbType = SqlDbType.Int;
            insertIDLibro_DetFact.Value = cmb_IDLibro_DetFac.SelectedValue;

            SqlParameter insertCantidad_DetFact = new SqlParameter();
            insertCantidad_DetFact.ParameterName = "@CANTIDAD";
            insertCantidad_DetFact.SqlDbType = SqlDbType.Int;
            insertCantidad_DetFact.Value = txt_cantidad_detFac.Text;

            comando.Parameters.Add(insertIDFactura_DetFact);
            comando.Parameters.Add(insertIDLibro_DetFact);
            comando.Parameters.Add(insertCantidad_DetFact);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }
    }
}