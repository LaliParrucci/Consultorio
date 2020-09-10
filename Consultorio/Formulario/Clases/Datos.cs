using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Consultorio.Clases
{
    class Datos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = "Data Source=DESKTOP-MHMNF7R\\SQLEXPRESS;Initial Catalog=consultorio_odontologico;Integrated Security=True";
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        
        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            
        }
        //---------------------------------CONSULTAS
        //recibe una consulta y genera una tabla datatable con los datos devueltos 
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
        //recibe una tabla y devuelve TODOS sus valores
        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = "Select * from " + nombreTabla;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }

        //-----------------------------------INSERT, UPDATE O DELETE



    }
}
