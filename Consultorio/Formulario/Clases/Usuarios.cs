using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Consultorio.Clases
{
    class Usuarios
    {
        private int id_usuario;
        private string n_usuario;
        private string password;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string N_usuario { get => n_usuario; set => n_usuario = value; }
        public string Password { get => password; set => password = value; }


        public int validarUsuario(string nombre, string clave)
        {
            string consutaSQL = "SELECT * FROM usuario WHERE nombre_usuario='" + nombre + "' AND contraseña='" + clave + "'";
            DataTable tabla = new DataTable();
            Datos oDato = new Datos();
            tabla = oDato.consultar(consutaSQL);

            if (tabla.Rows.Count > 0)
                return Convert.ToInt32(tabla.Rows[0][0]);
            else
                return 0;
        }

    }
}
