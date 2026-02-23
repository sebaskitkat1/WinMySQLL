using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        string cadenaConexion = "server=Localhost;user=sebas;pwd=Luna115115";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
    }
}
