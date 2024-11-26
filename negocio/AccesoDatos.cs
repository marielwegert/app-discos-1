using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace negocio
{
    public class AccesoDatos
    {
        //ATRIBUTOS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        
        //PROPIEDAD
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //CONSTRUCTOR
        public AccesoDatos()
        {
            conexion = new SqlConnection(ConfigurationManager.AppSettings["conexion-db"]);
            //conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB_Original; integrated security=true");
            comando = new SqlCommand();
        }

        //METODO
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //METODO
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }

        //METODO
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //METODO
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        //METODO
        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
