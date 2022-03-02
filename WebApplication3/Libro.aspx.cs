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
    public partial class WebForm2 : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btn_enviar_autor_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_AUTOR";

            SqlParameter insertNomAutor = new SqlParameter();
            insertNomAutor.ParameterName = "@NOMBRE";
            insertNomAutor.SqlDbType = SqlDbType.VarChar;
            insertNomAutor.Value = txt_nombre_autor.Text;

            comando.Parameters.Add(insertNomAutor);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_autor_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM AUTOR";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_autor.DataSource = tabla1;
            tabla_autor.DataBind();
        }

        protected void btn_enviar_edi_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_EDITORIAL";

            SqlParameter insertNom_Edi = new SqlParameter();
            insertNom_Edi.ParameterName = "@NOMBRE";
            insertNom_Edi.SqlDbType = SqlDbType.VarChar;
            insertNom_Edi.Value = txt_nombre_edi.Text;

            SqlParameter insertTel_Edi = new SqlParameter();
            insertTel_Edi.ParameterName = "@TELEFONO";
            insertTel_Edi.SqlDbType = SqlDbType.VarChar;
            insertTel_Edi.Value = txt_telefono_edi.Text;

            SqlParameter insertEmail_Edi = new SqlParameter();
            insertEmail_Edi.ParameterName = "@EMAIL";
            insertEmail_Edi.SqlDbType = SqlDbType.VarChar;
            insertEmail_Edi.Value = txt_email_edi.Text;

            SqlParameter insertDireccion_Edi = new SqlParameter();
            insertDireccion_Edi.ParameterName = "@DIRECCION";
            insertDireccion_Edi.SqlDbType = SqlDbType.VarChar;
            insertDireccion_Edi.Value = txt_direccion_edi.Text;


            comando.Parameters.Add(insertNom_Edi);
            comando.Parameters.Add(insertTel_Edi);
            comando.Parameters.Add(insertEmail_Edi);
            comando.Parameters.Add(insertDireccion_Edi);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_edi_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM EDITORIAL";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_editorial.DataSource = tabla1;
            tabla_editorial.DataBind();
        }

        protected void btn_enviar_libro_Click(object sender, EventArgs e)
        {
            
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_LIBRO";

            SqlParameter insertIDLibro_libro = new SqlParameter();
            insertIDLibro_libro.ParameterName = "@ID_LIBRO";
            insertIDLibro_libro.SqlDbType = SqlDbType.VarChar;
            insertIDLibro_libro.Value = txt_id_libro.Text;

            SqlParameter insertNombre_libro = new SqlParameter();
            insertNombre_libro.ParameterName = "@NOMBRE";
            insertNombre_libro.SqlDbType = SqlDbType.VarChar;
            insertNombre_libro.Value = txt_nombre_libro.Text;

            SqlParameter insertIDAutor_libro = new SqlParameter();
            insertIDAutor_libro.ParameterName = "@ID_AUTOR";
            insertIDAutor_libro.SqlDbType = SqlDbType.Int;
            insertIDAutor_libro.Value = cmb_ID_AUTOR.SelectedValue;

            SqlParameter insertFechaPu_libro = new SqlParameter();
            insertFechaPu_libro.ParameterName = "@FECHA_PUBLICACION";
            insertFechaPu_libro.SqlDbType = SqlDbType.Date;
            insertFechaPu_libro.Value = cal_fechaPub_libro.SelectedDate;

            SqlParameter insertIDEdito_libro = new SqlParameter();
            insertIDEdito_libro.ParameterName = "@ID_EDITORIAL";
            insertIDEdito_libro.SqlDbType = SqlDbType.Int;
            insertIDEdito_libro.Value = cmb_ID_EDITORIAL.SelectedValue;

            SqlParameter insertCosto_libro = new SqlParameter();
            insertCosto_libro.ParameterName = "@COSTO";
            insertCosto_libro.SqlDbType = SqlDbType.Int;
            insertCosto_libro.Value = txt_costo_libro.Text;

            comando.Parameters.Add(insertIDLibro_libro);
            comando.Parameters.Add(insertNombre_libro);
            comando.Parameters.Add(insertIDAutor_libro);
            comando.Parameters.Add(insertFechaPu_libro);
            comando.Parameters.Add(insertIDEdito_libro);
            comando.Parameters.Add(insertCosto_libro);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_libro_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM LIBRO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_libro.DataSource = tabla1;
            tabla_libro.DataBind();
        }

        protected void btn_modificar_autor_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_AUTOR";

            SqlParameter modificar_autor = new SqlParameter();
            modificar_autor.ParameterName = "@ID_AUTOR";
            modificar_autor.SqlDbType = SqlDbType.Int;
            modificar_autor.Value = txt_modificar_autor.Text;

            SqlParameter insertNomAutor = new SqlParameter();
            insertNomAutor.ParameterName = "@NOMBRE";
            insertNomAutor.SqlDbType = SqlDbType.VarChar;
            insertNomAutor.Value = txt_nombre_autor.Text;
            
            comando.Parameters.Add(modificar_autor);
            comando.Parameters.Add(insertNomAutor);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_edi_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_EDITORIAL";

            SqlParameter modifiID_Edi = new SqlParameter();
            modifiID_Edi.ParameterName = "@ID_EDITORIAL";
            modifiID_Edi.SqlDbType = SqlDbType.Int;
            modifiID_Edi.Value = txt_modificar_editorial.Text;

            SqlParameter insertNom_Edi = new SqlParameter();
            insertNom_Edi.ParameterName = "@NOMBRE";
            insertNom_Edi.SqlDbType = SqlDbType.VarChar;
            insertNom_Edi.Value = txt_nombre_edi.Text;

            SqlParameter insertTel_Edi = new SqlParameter();
            insertTel_Edi.ParameterName = "@TELEFONO";
            insertTel_Edi.SqlDbType = SqlDbType.VarChar;
            insertTel_Edi.Value = txt_telefono_edi.Text;

            SqlParameter insertEmail_Edi = new SqlParameter();
            insertEmail_Edi.ParameterName = "@EMAIL";
            insertEmail_Edi.SqlDbType = SqlDbType.VarChar;
            insertEmail_Edi.Value = txt_email_edi.Text;

            SqlParameter insertDireccion_Edi = new SqlParameter();
            insertDireccion_Edi.ParameterName = "@DIRECCION";
            insertDireccion_Edi.SqlDbType = SqlDbType.VarChar;
            insertDireccion_Edi.Value = txt_direccion_edi.Text;



            comando.Parameters.Add(modifiID_Edi);
            comando.Parameters.Add(insertNom_Edi);
            comando.Parameters.Add(insertTel_Edi);
            comando.Parameters.Add(insertEmail_Edi);
            comando.Parameters.Add(insertDireccion_Edi);
            

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_libro_Click(object sender, EventArgs e)
        {
            
                comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_LIBRO";

            SqlParameter insertIDLibro_libro = new SqlParameter();
            insertIDLibro_libro.ParameterName = "@ID_LIBRO";
            insertIDLibro_libro.SqlDbType = SqlDbType.Int;
            insertIDLibro_libro.Value = txt_modificarIDlibro.Text;

            SqlParameter insertNombre_libro = new SqlParameter();
            insertNombre_libro.ParameterName = "@NOMBRE";
            insertNombre_libro.SqlDbType = SqlDbType.VarChar;
            insertNombre_libro.Value = txt_nombre_libro.Text;

            SqlParameter insertIDAutor_libro = new SqlParameter();
            insertIDAutor_libro.ParameterName = "@ID_AUTOR";
            insertIDAutor_libro.SqlDbType = SqlDbType.Int;
            insertIDAutor_libro.Value = cmb_ID_AUTOR.SelectedValue;

            SqlParameter insertFechaPu_libro = new SqlParameter();
            insertFechaPu_libro.ParameterName = "@FECHA_PUBLICACION";
            insertFechaPu_libro.SqlDbType = SqlDbType.Date;
            insertFechaPu_libro.Value = cal_fechaPub_libro.SelectedDate;

            SqlParameter insertIDEdito_libro = new SqlParameter();
            insertIDEdito_libro.ParameterName = "@ID_EDITORIAL";
            insertIDEdito_libro.SqlDbType = SqlDbType.Int;
            insertIDEdito_libro.Value = cmb_ID_EDITORIAL.SelectedValue;

            SqlParameter insertCosto_libro = new SqlParameter();
            insertCosto_libro.ParameterName = "@COSTO";
            insertCosto_libro.SqlDbType = SqlDbType.Int;
            insertCosto_libro.Value = txt_costo_libro.Text;

            comando.Parameters.Add(insertIDLibro_libro);
            comando.Parameters.Add(insertNombre_libro);
            comando.Parameters.Add(insertIDAutor_libro);
            comando.Parameters.Add(insertFechaPu_libro);
            comando.Parameters.Add(insertIDEdito_libro);
            comando.Parameters.Add(insertCosto_libro);
            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }
    }
}