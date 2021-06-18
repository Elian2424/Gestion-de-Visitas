using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ENTIDAD;
using System.Data;


namespace DATOS
{
    public class dvisitas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        

        
        public List<econsulta> listarvisita(string CONSULTA)
        {
            SqlDataReader leerfilas;

            SqlCommand cmd = new SqlCommand("SP_CONSULTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@EDIFICIO", CONSULTA);

            leerfilas = cmd.ExecuteReader();

            List<econsulta> listar = new List<econsulta>();

            while (leerfilas.Read())
            {
                listar.Add(new econsulta
                {
                    Idregistro = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Carrera = leerfilas.GetString(3),
                    Correo = leerfilas.GetString(4),
                    Edificio = leerfilas.GetString(5),
                    Area = leerfilas.GetString(6),
                    Hora_e = leerfilas.GetDateTime(7),
                    Hora_s = leerfilas.GetDateTime(8),
                    Motivo = leerfilas.GetString(9)
                }); ;


            }

            conexion.Close();
            leerfilas.Close();

            return listar;

        }
        

        public void insertarregistro(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARREGISTRO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", visita.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visita.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visita.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);
            cmd.Parameters.AddWithValue("@AREA", visita.Area);
            cmd.Parameters.AddWithValue("@HORA_E", visita.Hora_e);
            cmd.Parameters.AddWithValue("@HORA_S", visita.Hora_s);
            cmd.Parameters.AddWithValue("@MOTIVO", visita.Motivo);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        


        public void insertarusuariog(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARUSUARIOG", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", visita.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.Apellido);
            cmd.Parameters.AddWithValue("@FECHA_N", visita.Fechan);
            cmd.Parameters.AddWithValue("@USUARIO", visita.Usuario);
            cmd.Parameters.AddWithValue("@TIPO", visita.Tipo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertaredificio(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);
          

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertararea(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARAREA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@AREA", visita.Area);
            cmd.Parameters.AddWithValue("@N_EDIFICIO", visita.N_edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void editaredificio(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDEDIFICIO", visita.Idedificio);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void editararea(evisitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARAREA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDAREA", visita.Idarea);
            cmd.Parameters.AddWithValue("@AREA", visita.Area);
            cmd.Parameters.AddWithValue("@N_EDIFICIO", visita.N_edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }



    }
}
