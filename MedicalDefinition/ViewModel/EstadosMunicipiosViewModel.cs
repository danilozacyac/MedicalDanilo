using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MedicalDefinition.Dao;
using MedicalDefinition.Utilities;

namespace MedicalDefinition.ViewModel
{
    public class EstadosMunicipiosViewModel
    {

        public List<EstadosMunicipios> GetEstados()
        {
            SqlConnection connectionEpsSql = Utils.GetConnection();
            List<EstadosMunicipios> estados = new List<EstadosMunicipios>();

            try
            {
                connectionEpsSql.Open();

                string sqlCadena = "SELECT * FROM Estados";
                SqlCommand cmd = new SqlCommand(sqlCadena, connectionEpsSql);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EstadosMunicipios estado = new EstadosMunicipios(Convert.ToInt32(reader["IdEstado"]), reader["Estado"].ToString());
                        estados.Add(estado);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WriteEventLog(ex, "GetEstados Exception,MedicalDefinition");
            }
            finally
            {
                connectionEpsSql.Close();
            }
            return estados;
        }

        public List<EstadosMunicipios> GetMunicipios()
        {
            SqlConnection connectionEpsSql = Utils.GetConnection();
            List<EstadosMunicipios> municipios = new List<EstadosMunicipios>();

            try
            {
                connectionEpsSql.Open();

                string sqlCadena = "SELECT * FROM Municipios";
                SqlCommand cmd = new SqlCommand(sqlCadena, connectionEpsSql);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EstadosMunicipios municipio = new EstadosMunicipios(Convert.ToInt32(reader["IdEstado"]),Convert.ToInt32(reader["IdMunicipio"]), reader["Municipio"].ToString());
                        municipios.Add(municipio);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WriteEventLog(ex, "GetEstados Exception,MedicalDefinition");
            }
            finally
            {
                connectionEpsSql.Close();
            }
            return municipios;
        }



    }
}
