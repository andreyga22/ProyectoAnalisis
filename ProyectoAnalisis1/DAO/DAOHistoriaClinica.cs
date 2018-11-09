using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TO;

namespace DAO
{
    public class DAOHistoriaClinica
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public Boolean insertarHistoriaClinica(TOHistoriaClinica historialClinica)
        {
            try
            {
                SqlCommand insertar = new SqlCommand("Insert into HISTORIAL_CLINICO values (@idhist, @hta, @dm, " +
                    "@asma, @epilepsia, @enfCard, @displidemias, @enfPsiquiatrica, @otros_Person_Patol, @fuma," +
                    "@licor, @drogas, @alergias, @otros_pers_no_patolg, @menarca, @fur, @embaraz, @abort, @quistOvaric, @endometriosis, " +
                    "@otros_ginecoobstet, @medicam, @otros_Medic, @fracturas, @vesicula, @apendice, @cordales, @litiasis, " +
                    "@columna, @otros_quirurg, @dm_fam, @hta_fam, @asma_fam, @cancerfam, @epilepsiaFam, @demenciasFam, " +
                    "@enfPsquitrFam, @otrosFam, @grupoSanguineo)", conexion);
                insertar.Parameters.AddWithValue("@idhist", historialClinica.Id_Historial);
                insertar.Parameters.AddWithValue("@hta", historialClinica.HTA);
                insertar.Parameters.AddWithValue("@dm", historialClinica.DM);
                insertar.Parameters.AddWithValue("@asma", historialClinica.Asma);
                insertar.Parameters.AddWithValue("@epilepsia", historialClinica.Epilepsia);
                insertar.Parameters.AddWithValue("@enfCard", historialClinica.Enferm_Cardiacas);
                insertar.Parameters.AddWithValue("@displidemias", historialClinica.Displidemias);
                insertar.Parameters.AddWithValue("@enfPsiquiatrica", historialClinica.Enferm_Psiquiatricas);
                insertar.Parameters.AddWithValue("@otros_Person_Patol", historialClinica.Otros_Person_Patologic);
                insertar.Parameters.AddWithValue("@fuma", historialClinica.Fuma);
                insertar.Parameters.AddWithValue("@licor", historialClinica.Licor);
                insertar.Parameters.AddWithValue("@drogas", historialClinica.Drogas);
                insertar.Parameters.AddWithValue("@alergias", historialClinica.Alergias);
                insertar.Parameters.AddWithValue("@otros_pers_no_patolg", historialClinica.Otros_Person_No_Patologic);
                insertar.Parameters.AddWithValue("@menarca", historialClinica.Menarca);
                insertar.Parameters.AddWithValue("@fur", historialClinica.FUR);
                insertar.Parameters.AddWithValue("@embaraz", historialClinica.Embarazos);
                insertar.Parameters.AddWithValue("@abort", historialClinica.Abortos);
                insertar.Parameters.AddWithValue("@quistOvaric", historialClinica.QuistesOvaricos);
                insertar.Parameters.AddWithValue("@endometriosis", historialClinica.Endometriosis);
                insertar.Parameters.AddWithValue("@otros_ginecoobstet", historialClinica.Otros_Ginecobstetrico);
                insertar.Parameters.AddWithValue("@medicam", historialClinica.Medicamentos);
                insertar.Parameters.AddWithValue("@otros_Medic", historialClinica.IndicacionesMedicamentos);
                insertar.Parameters.AddWithValue("@fracturas", historialClinica.Fracturas);
                insertar.Parameters.AddWithValue("@vesicula", historialClinica.Vesicula);
                insertar.Parameters.AddWithValue("@apendice", historialClinica.Apendice);
                insertar.Parameters.AddWithValue("@cordales", historialClinica.Cordales);
                insertar.Parameters.AddWithValue("@litiasis", historialClinica.Litiasis);
                insertar.Parameters.AddWithValue("@columna", historialClinica.Columna);
                insertar.Parameters.AddWithValue("@otros_quirurg", historialClinica.Otros_Quirurgico);
                insertar.Parameters.AddWithValue("@dm_fam", historialClinica.DM_Fam);
                insertar.Parameters.AddWithValue("@hta_fam", historialClinica.HTA_Fam);
                insertar.Parameters.AddWithValue("@asma_fam", historialClinica.Asma_Fam);
                insertar.Parameters.AddWithValue("@cancerfam", historialClinica.Cancer_Fam);
                insertar.Parameters.AddWithValue("@epilepsiaFam", historialClinica.Epilepsia_Fam);
                insertar.Parameters.AddWithValue("@demenciasFam", historialClinica.Demencias_Fam);
                insertar.Parameters.AddWithValue("@enfPsquitrFam", historialClinica.Enferm_Psiq_Fam);
                insertar.Parameters.AddWithValue("@otrosFam", historialClinica.Otros_Fam);
                insertar.Parameters.AddWithValue("@grupoSanguineo", historialClinica.grupo_Sanguineo);

                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public TOHistoriaClinica consultarHistorialClinico(String cedula)
        {
            TOHistoriaClinica to = new TOHistoriaClinica();

            string select = "select * from HISTORIAL_CLINICO where cedula = @ced;";
            SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@ced", cedula);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    to.Id_Historial = reader.GetInt32(0);
                    to.cedula = reader.GetString(1); 
                    to.HTA = reader.GetBoolean(2); 
                    to.DM = reader.GetBoolean(3); 
                    to.Asma = reader.GetBoolean(4); 
                    to.Epilepsia = reader.GetBoolean(5); 
                    to.Enferm_Cardiacas = reader.GetString(6); 
                    to.Displidemias = reader.GetBoolean(7); 
                    to.Enferm_Psiquiatricas = reader.GetString(8);
                    to.Otros_Person_Patologic = reader.GetString(9);
                    to.Fuma = reader.GetBoolean(10);
                    to.Licor = reader.GetBoolean(11);
                    to.Drogas = reader.GetBoolean(12);
                    to.Alergias = reader.GetString(13);
                    to.Otros_Person_No_Patologic = reader.GetString(14);
                    to.Menarca = reader.GetBoolean(15);
                    to.FUR = reader.GetDateTime(16);
                    to.Embarazos = reader.GetInt32(17);
                    to.Abortos = reader.GetInt32(18);
                    to.QuistesOvaricos = reader.GetInt32(19);
                    to.Endometriosis = reader.GetBoolean(20);
                    to.Otros_Ginecobstetrico = reader.GetString(21);
                    to.Medicamentos = reader.GetString(22);
                    to.IndicacionesMedicamentos = reader.GetString(23);
                    to.Fracturas = reader.GetString(24);
                    to.Vesicula = reader.GetString(25);
                    to.Apendice = reader.GetBoolean(26);
                    to.Cordales = reader.GetBoolean(27);
                    to.Litiasis = reader.GetString(28);
                    to.Columna = reader.GetString(30);
                    to.Otros_Quirurgico = reader.GetString(31);
                    to.DM_Fam = reader.GetString(32);
                    to.HTA = reader.GetBoolean(33);
                    to.Asma_Fam = reader.GetString(34);
                    to.Cancer_Fam = reader.GetString(35);
                    to.Epilepsia_Fam = reader.GetString(36);
                    to.Demencias_Fam = reader.GetString(37);
                    to.Enferm_Psiq_Fam = reader.GetString(38);
                    to.Otros_Fam = reader.GetString(39);
                    to.grupo_Sanguineo = reader.GetString(40);
    }
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return to;
        }
    }
}
