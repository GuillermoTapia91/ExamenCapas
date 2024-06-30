using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Datos
{
    public class DRegion
    {
        public void Insertar(string Nombre)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("RSP_InsertRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                command.Parameters.Add(parameter);

                /*
                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = Activo;
                command.Parameters.Add(parameter2);
                */

                command.ExecuteNonQuery();

            }
        }

        public void Actualizar(int RegionId,string RegionName) 
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("RSP_UpdateRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros

                SqlParameter parameter1 = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter1.Value = RegionId;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                parameter2.Value = RegionName;
                command.Parameters.Add(parameter2);

                /*
                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = Activo;
                command.Parameters.Add(parameter2);
                */

                command.ExecuteNonQuery();

            }


        }
        public List<Region> Listar(string Nombre)
        {
            List<Region> regions = new List<Region>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

                    regions.Add(new Region { RegionId = RegionId, RegionName = RegionName });


                }
                reader.Close();
            }
            return regions;

        }

        public void Eliminar(int RegionId)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("RSP_DeleteRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros

                SqlParameter parameter1 = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter1.Value = RegionId;
                command.Parameters.Add(parameter1);
                               
                command.ExecuteNonQuery();

            }


        }

    }
}
