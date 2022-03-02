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
    public partial class WebForm4 : System.Web.UI.Page
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

        protected void btn_enviar_TiEmpleado_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_TIPO_EMPLEADO";

            SqlParameter inserDescripcion_TiEmpleado = new SqlParameter();
            inserDescripcion_TiEmpleado.ParameterName = "@DESCRIPCION";
            inserDescripcion_TiEmpleado.SqlDbType = SqlDbType.VarChar;
            inserDescripcion_TiEmpleado.Value = txt_descripcion_TiEmpleado.Text;
            
            comando.Parameters.Add(inserDescripcion_TiEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_ver_TiEmpleado_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM TIPO_EMPLEADO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_tipo_empleado.DataSource = tabla1;
            tabla_tipo_empleado.DataBind();
        }

        protected void btn_enviar_emple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_EMPLEADO";

           

            SqlParameter insertNomE = new SqlParameter();
            insertNomE.ParameterName = "@NOMBRE";
            insertNomE.SqlDbType = SqlDbType.VarChar;
            insertNomE.Value = txt_nombre_emple.Text;

            SqlParameter insertAppa = new SqlParameter();
            insertAppa.ParameterName = "@APPATERNO";
            insertAppa.SqlDbType = SqlDbType.VarChar;
            insertAppa.Value = txt_appaterno_emple.Text;

            SqlParameter insertApma = new SqlParameter();
            insertApma.ParameterName = "@APMATERNO";
            insertApma.SqlDbType = SqlDbType.VarChar;
            insertApma.Value = txt_apmaterno_emple.Text;

            SqlParameter insertDirec = new SqlParameter();
            insertDirec.ParameterName = "@DIRECCION";
            insertDirec.SqlDbType = SqlDbType.VarChar;
            insertDirec.Value = txt_direccion_emple.Text;

            SqlParameter inserSexo = new SqlParameter();
            inserSexo.ParameterName = "@SEXO";
            inserSexo.SqlDbType = SqlDbType.VarChar;
            inserSexo.Value = cmb_sexo_emple.SelectedValue;

            SqlParameter insertFechaNa = new SqlParameter();
            insertFechaNa.ParameterName = "@FECHA_NAC";
            insertFechaNa.SqlDbType = SqlDbType.Date;
            insertFechaNa.Value = calendar_fechaNac.SelectedDate;

            SqlParameter inserTiEmpleado = new SqlParameter();
            inserTiEmpleado.ParameterName = "@ID_TIPO_EMPLEADO";
            inserTiEmpleado.SqlDbType = SqlDbType.VarChar;
            inserTiEmpleado.Value = cmb_IDTiEmp_emple.SelectedValue;

            SqlParameter insertIdSuc = new SqlParameter();
            insertIdSuc.ParameterName = "@ID_SUCURSAL";
            insertIdSuc.SqlDbType = SqlDbType.VarChar;
            insertIdSuc.Value = cmb_IDSucur_emple.SelectedValue;

            
            comando.Parameters.Add(insertNomE);
            comando.Parameters.Add(insertAppa);
            comando.Parameters.Add(insertApma);
            comando.Parameters.Add(insertDirec);
            comando.Parameters.Add(inserSexo);
            comando.Parameters.Add(insertFechaNa);
            comando.Parameters.Add(inserTiEmpleado);
            comando.Parameters.Add(insertIdSuc);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();

        }

        protected void btn_ver_emple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.StoredProcedure;
            //se trae el nombre del procedimiento 
            comando.CommandText = "CONSULTAR_EMPLEADO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_empleado.DataSource = tabla1;
            tabla_empleado.DataBind();
        }

        protected void btn_enviar_teleEmple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_TELEFONO";

            SqlParameter insertEmailE = new SqlParameter();
            insertEmailE.ParameterName = "@TELEFONO";
            insertEmailE.SqlDbType = SqlDbType.VarChar;
            insertEmailE.Value = txt_descripcion_telefono.Text;

            SqlParameter insertIDEmpleado = new SqlParameter();
            insertIDEmpleado.ParameterName = "@ID_EMPLEADO";
            insertIDEmpleado.SqlDbType = SqlDbType.VarChar;
            insertIDEmpleado.Value = cmb_empleado_telefono.SelectedValue;

            comando.Parameters.Add(insertEmailE);
            comando.Parameters.Add(insertIDEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();

        }

        protected void btn_ver_teleEmple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM TELEFONO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_telefono_em.DataSource = tabla1;
            tabla_telefono_em.DataBind();
        }

        protected void btn_enviar_emailEmple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_EMAIL";

            SqlParameter insertEmailE = new SqlParameter();
            insertEmailE.ParameterName = "@DESCRIPCION";
            insertEmailE.SqlDbType = SqlDbType.VarChar;
            insertEmailE.Value = txt_descripcion_email.Text;

            SqlParameter insertIDEmpleado = new SqlParameter();
            insertIDEmpleado.ParameterName = "@ID_EMPLEADO";
            insertIDEmpleado.SqlDbType = SqlDbType.VarChar;
            insertIDEmpleado.Value = cmb_empleado_email.SelectedValue;

            comando.Parameters.Add(insertEmailE);
            comando.Parameters.Add(insertIDEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();

        }

        protected void btn_ver_emailEmple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            //se llama a la propia cadena de coneccion 
            comando.Connection = conectar;
            //se especifica el tipo de comando que se usa
            comando.CommandType = CommandType.Text;
            //se trae el nombre del procedimiento 
            comando.CommandText = "SELECT *  FROM EMAIL_EMPLEADO";
            adaptador = new SqlDataAdapter(comando);
            tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            tabla_email_em.DataSource = tabla1;
            tabla_email_em.DataBind();
        }

        protected void btn_modificar_TiEmpleado_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_ID_TIPO_EMPLEADO";

            SqlParameter cambiar_TiEmple = new SqlParameter();
            cambiar_TiEmple.ParameterName = "@ID_TIPO_EMPLEADO";
            cambiar_TiEmple.SqlDbType = SqlDbType.Int;
            cambiar_TiEmple.Value =txt_modificar_TiEm.Text;

            SqlParameter inserDescripcion_TiEmpleado = new SqlParameter();
            inserDescripcion_TiEmpleado.ParameterName = "@DESCRIPCION";
            inserDescripcion_TiEmpleado.SqlDbType = SqlDbType.VarChar;
            inserDescripcion_TiEmpleado.Value = txt_descripcion_TiEmpleado.Text;

            comando.Parameters.Add(cambiar_TiEmple);
            comando.Parameters.Add(inserDescripcion_TiEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_emple_Click(object sender, EventArgs e)
        {
            
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_EMPLEADO";

            SqlParameter modificar_empleado = new SqlParameter();
            modificar_empleado.ParameterName = "@ID_EMPLEADO";
            modificar_empleado.SqlDbType = SqlDbType.VarChar;
            modificar_empleado.Value = txt_idEmpleado_emple.Text;

            SqlParameter insertNomE = new SqlParameter();
            insertNomE.ParameterName = "@NOMBRE";
            insertNomE.SqlDbType = SqlDbType.VarChar;
            insertNomE.Value = txt_nombre_emple.Text;

            SqlParameter insertAppa = new SqlParameter();
            insertAppa.ParameterName = "@APPATERNO";
            insertAppa.SqlDbType = SqlDbType.VarChar;
            insertAppa.Value = txt_appaterno_emple.Text;

            SqlParameter insertApma = new SqlParameter();
            insertApma.ParameterName = "@APMATERNO";
            insertApma.SqlDbType = SqlDbType.VarChar;
            insertApma.Value = txt_apmaterno_emple.Text;

            SqlParameter insertDirec = new SqlParameter();
            insertDirec.ParameterName = "@DIRECCION";
            insertDirec.SqlDbType = SqlDbType.VarChar;
            insertDirec.Value = txt_direccion_emple.Text;

            SqlParameter inserSexo = new SqlParameter();
            inserSexo.ParameterName = "@SEXO";
            inserSexo.SqlDbType = SqlDbType.VarChar;
            inserSexo.Value = cmb_sexo_emple.SelectedValue;

            SqlParameter insertFechaNa = new SqlParameter();
            insertFechaNa.ParameterName = "@FECHA_NAC";
            insertFechaNa.SqlDbType = SqlDbType.Date;
            insertFechaNa.Value = calendar_fechaNac.SelectedDate;

            SqlParameter inserTiEmpleado = new SqlParameter();
            inserTiEmpleado.ParameterName = "@ID_TIPO_EMPLEADO";
            inserTiEmpleado.SqlDbType = SqlDbType.VarChar;
            inserTiEmpleado.Value = cmb_IDTiEmp_emple.SelectedValue;

            SqlParameter insertIdSuc = new SqlParameter();
            insertIdSuc.ParameterName = "@ID_SUCURSAL";
            insertIdSuc.SqlDbType = SqlDbType.VarChar;
            insertIdSuc.Value = cmb_IDSucur_emple.SelectedValue;

            
            comando.Parameters.Add(modificar_empleado);
            comando.Parameters.Add(insertNomE);
            comando.Parameters.Add(insertAppa);
            comando.Parameters.Add(insertApma);
            comando.Parameters.Add(insertDirec);
            comando.Parameters.Add(inserSexo);
            comando.Parameters.Add(insertFechaNa);
            comando.Parameters.Add(inserTiEmpleado);
            comando.Parameters.Add(insertIdSuc);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_emailEmple_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_EMAIL_EMPLEADO";

            SqlParameter cambiar_email = new SqlParameter();
            cambiar_email.ParameterName = "@ID_EMAIL";
            cambiar_email.SqlDbType = SqlDbType.Int;
            cambiar_email.Value = txt_modificar_email.Text;

            SqlParameter insertEmailE = new SqlParameter();
            insertEmailE.ParameterName = "@DESCRIPCION";
            insertEmailE.SqlDbType = SqlDbType.VarChar;
            insertEmailE.Value = txt_descripcion_email.Text;

            SqlParameter insertIDEmpleado = new SqlParameter();
            insertIDEmpleado.ParameterName = "@ID_EMPLEADO";
            insertIDEmpleado.SqlDbType = SqlDbType.VarChar;
            insertIDEmpleado.Value = cmb_empleado_email.SelectedValue;
            
            comando.Parameters.Add(cambiar_email);
            comando.Parameters.Add(insertEmailE);
            comando.Parameters.Add(insertIDEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }

        protected void btn_modificar_teleEmple_Click(object sender, EventArgs e)
        {
            
                comando = new SqlCommand();
            comando.Connection = conectar;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CAMBIAR_TELEFONO_EMPLEADO";

            SqlParameter cambiar_telefono = new SqlParameter();
            cambiar_telefono.ParameterName = "@ID_TELEFONO";
            cambiar_telefono.SqlDbType = SqlDbType.Int;
            cambiar_telefono.Value = txt_modificar_telefono.Text;

            SqlParameter insertEmailE = new SqlParameter();
            insertEmailE.ParameterName = "@DESCRIPCION";
            insertEmailE.SqlDbType = SqlDbType.VarChar;
            insertEmailE.Value = txt_descripcion_telefono.Text;

            SqlParameter insertIDEmpleado = new SqlParameter();
            insertIDEmpleado.ParameterName = "@ID_EMPLEADO";
            insertIDEmpleado.SqlDbType = SqlDbType.VarChar;
            insertIDEmpleado.Value = cmb_empleado_telefono.SelectedValue;
            
            comando.Parameters.Add(cambiar_telefono);
            comando.Parameters.Add(insertEmailE);
            comando.Parameters.Add(insertIDEmpleado);

            conectar.Open();
            comando.ExecuteScalar();
            Page_Load(sender, e);
            conectar.Close();
        }
    }
}