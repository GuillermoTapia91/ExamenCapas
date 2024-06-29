﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public List<Region> Listar(string Nombre)
        {
            List<Region> regions = new List<Region>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                /*
                SqlParameter parameter = new SqlParameter("RegionName", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                cmd.Parameters.Add(parameter);
                */

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
    }
}
