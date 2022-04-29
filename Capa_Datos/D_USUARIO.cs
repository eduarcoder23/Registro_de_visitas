using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace Capa_Datos
{
    public class D_USUARIO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List <E_USUARIO>ListarUsuarios(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cnd = new SqlCommand("SP_BUSCARUSUARIOS", conexion);
            cnd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cnd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cnd.ExecuteReader();

            List<E_USUARIO> Listar = new List<E_USUARIO>();
            while(LeerFilas.Read())
            {
                Listar.Add(new E_USUARIO
                {
                    Idusuario = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Carrera = LeerFilas.GetString(3),
                    Correo = LeerFilas.GetString(4),
                    Edificio= LeerFilas.GetString(5),
                    Horase = LeerFilas.GetString(6),
                    Horass = LeerFilas.GetString(7),
                    Motivo = LeerFilas.GetString(8),
                    Aula = LeerFilas.GetString(9)

                })  ;
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarUsuario(E_USUARIO Usuario)
        {
            SqlCommand cnd = new SqlCommand("SP_INSERTARUSUARIOS", conexion);
            cnd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            
            cnd.Parameters.AddWithValue("@NOMBRE", Usuario.Nombre);
            cnd.Parameters.AddWithValue("@APELLIDO", Usuario.Apellido);
            cnd.Parameters.AddWithValue("CARRERA", Usuario.Carrera);
            cnd.Parameters.AddWithValue("@CORREO", Usuario.Correo);
            cnd.Parameters.AddWithValue("@EDIFICIO", Usuario.Edificio);
            cnd.Parameters.AddWithValue("@HORASE", Usuario.Horase);
            cnd.Parameters.AddWithValue("@HORASS", Usuario.Horass);
            cnd.Parameters.AddWithValue("@MOTIVO", Usuario.Motivo);
            cnd.Parameters.AddWithValue("@AULA", Usuario.Aula);

            cnd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarUsuario(E_USUARIO Usuario)
        {
            SqlCommand cnd = new SqlCommand("SP_EDITARUSUARIOS", conexion);
            cnd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cnd.Parameters.AddWithValue("@IDUSUARIO", Usuario.Idusuario);
            cnd.Parameters.AddWithValue("@NOMBRE", Usuario.Nombre);
            cnd.Parameters.AddWithValue("@APELLIDO", Usuario.Apellido);
            cnd.Parameters.AddWithValue("CARRERA", Usuario.Carrera);
            cnd.Parameters.AddWithValue("@CORREO", Usuario.Correo);
            cnd.Parameters.AddWithValue("@EDIFICIO", Usuario.Edificio);
            cnd.Parameters.AddWithValue("@HORASE", Usuario.Horase);
            cnd.Parameters.AddWithValue("@HORASS", Usuario.Horass);
            cnd.Parameters.AddWithValue("@MOTIVO", Usuario.Motivo);
            cnd.Parameters.AddWithValue("@AULA", Usuario.Aula);

            cnd.ExecuteNonQuery();
            conexion.Close();
        }
        
        public void EliminarUsuario(E_USUARIO Usuario)
        {
            SqlCommand cnd = new SqlCommand("SP_ELIMINARUSUARIOS", conexion);
            cnd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cnd.Parameters.AddWithValue("@IDUSUARIO", Usuario.Idusuario);
            cnd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
