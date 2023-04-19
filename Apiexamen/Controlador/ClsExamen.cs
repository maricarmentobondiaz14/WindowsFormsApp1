using Apiexamen.Controlador;
using Apiexamen.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apiexamen.Modelo;

namespace Apiexamen
{
    public class ClsExamen
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader leerfilas;
        Examen exa = new Examen();

        public DataTable ListarExamenes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Select * from tblExamen ";
            leerfilas = Comando.ExecuteReader();
            Tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;


        }
        public Examen ConsultarExamen(int idExamen, string nombre)
        {
            Examen exa = new Examen();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "spConsultar";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", idExamen);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            leerfilas = Comando.ExecuteReader();
            while (leerfilas.Read())
            {
                exa.Identificador = leerfilas.GetInt32(0);
                exa.Nombre = leerfilas.GetString(1);
                exa.Descripcion = leerfilas.GetString(2);

            }
            leerfilas.Close();

            Conexion.CerrarConexion();
            return exa;


        }
        public int AgregarExamen(
            string nombre,
            string descripcion
            )
        {
            int valorRegresado;
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "spAgregar";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            valorRegresado = Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

            Conexion.CerrarConexion();

            return valorRegresado;

        }
        public int ActualizarExamen(
            int idExamen,
            string nombre,
            string descripcion
            )
        {
            int valorRegresado;
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "spAgregar";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", idExamen);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            valorRegresado = Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

            Conexion.CerrarConexion();
            return valorRegresado;
        }

        public int EliminarExamen(int idExamen)
        {
            int valorRegresado;
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "spEliminar";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", idExamen);

            valorRegresado = Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

            Conexion.CerrarConexion();
            return valorRegresado;
        }
    }
}
