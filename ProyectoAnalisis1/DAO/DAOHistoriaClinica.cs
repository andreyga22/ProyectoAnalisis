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

        //public Boolean insertarHistoriaClinica(TOHistoriaClinica historialClinica)
        //{
        //    try
        //    {
        //        SqlCommand insertar = new SqlCommand("Insert into HISTORIAL_CLINICO values (@idhist, @ced, @hta, @dm, " +
        //            "@asma, @epilepsia, @enfCard, @displidemias, @enfPsiquiatrica, @otros_Person_Patol, @fuma," +
        //            "@licor, @drogas, @alergias, @otros_pers_no_patolg, @menarca, @fur, @embaraz, @abort, @quistOvaric, @endometriosis, " +
        //            "@otros_ginecoobstet, @medicam, @otros_Medic, @fracturas, @vesicula, @apendice, @cordales, @litiasis, " +
        //            "@columna, @otros_quirurg, @dm_fam, @hta_fam, @asma_fam, @cancerfam, @epilepsiaFam, @demenciasFam, " +
        //            "@enfPsquitrFam, @otrosFam, @grupoSanguineo)", conexion);
        //        insertar.Parameters.AddWithValue("@idhist", historialClinica.Id_Historial);
        //        insertar.Parameters.AddWithValue("@ced", historialClinica.cedula);
        //        insertar.Parameters.AddWithValue("@hta", historialClinica.HTA);
        //        insertar.Parameters.AddWithValue("@dm", historialClinica.DM);
        //        insertar.Parameters.AddWithValue("@asma", historialClinica.Asma);
        //        insertar.Parameters.AddWithValue("@epilepsia", historialClinica.Epilepsia);
        //        insertar.Parameters.AddWithValue("@enfCard", historialClinica.Enferm_Cardiacas);
        //        insertar.Parameters.AddWithValue("@displidemias", historialClinica.Displidemias);
        //        insertar.Parameters.AddWithValue("@enfPsiquiatrica", historialClinica.Enferm_Psiquiatricas);
        //        insertar.Parameters.AddWithValue("@otros_Person_Patol", historialClinica.Otros_Person_Patologic);
        //        insertar.Parameters.AddWithValue("@fuma", historialClinica.Fuma);
        //        insertar.Parameters.AddWithValue("@licor", historialClinica.Licor);
        //        insertar.Parameters.AddWithValue("@drogas", historialClinica.Drogas);
        //        insertar.Parameters.AddWithValue("@alergias", historialClinica.Alergias);
        //        insertar.Parameters.AddWithValue("@otros_pers_no_patolg", historialClinica.Otros_Person_No_Patologic);
        //        insertar.Parameters.AddWithValue("@menarca", historialClinica.Menarca);
        //        insertar.Parameters.AddWithValue("@fur", historialClinica.FUR);
        //        insertar.Parameters.AddWithValue("@embaraz", historialClinica.Embarazos);
        //        insertar.Parameters.AddWithValue("@abort", historialClinica.Abortos);
        //        insertar.Parameters.AddWithValue("@quistOvaric", historialClinica.QuistesOvaricos);
        //        insertar.Parameters.AddWithValue("@endometriosis", historialClinica.Endometriosis);
        //        insertar.Parameters.AddWithValue("@otros_ginecoobstet", historialClinica.Otros_Ginecobstetrico);
        //        insertar.Parameters.AddWithValue("@medicam", historialClinica.Medicamentos);
        //        insertar.Parameters.AddWithValue("@otros_Medic", historialClinica.IndicacionesMedicamentos);
        //        insertar.Parameters.AddWithValue("@fracturas", historialClinica.Fracturas);
        //        insertar.Parameters.AddWithValue("@vesicula", historialClinica.Vesicula);
        //        insertar.Parameters.AddWithValue("@apendice", historialClinica.Apendice);
        //        insertar.Parameters.AddWithValue("@cordales", historialClinica.Cordales);
        //        insertar.Parameters.AddWithValue("@litiasis", historialClinica.Litiasis);
        //        insertar.Parameters.AddWithValue("@columna", historialClinica.Columna);
        //        insertar.Parameters.AddWithValue("@otros_quirurg", historialClinica.Otros_Quirurgico);
        //        insertar.Parameters.AddWithValue("@dm_fam", historialClinica.DM_Fam);
        //        insertar.Parameters.AddWithValue("@hta_fam", historialClinica.HTA_Fam);
        //        insertar.Parameters.AddWithValue("@asma_fam", historialClinica.Asma_Fam);
        //        insertar.Parameters.AddWithValue("@cancerfam", historialClinica.Cancer_Fam);
        //        insertar.Parameters.AddWithValue("@epilepsiaFam", historialClinica.Epilepsia_Fam);
        //        insertar.Parameters.AddWithValue("@demenciasFam", historialClinica.Demencias_Fam);
        //        insertar.Parameters.AddWithValue("@enfPsquitrFam", historialClinica.Enferm_Psiq_Fam);
        //        insertar.Parameters.AddWithValue("@otrosFam", historialClinica.Otros_Fam);
        //        insertar.Parameters.AddWithValue("@grupoSanguineo", historialClinica.grupo_Sanguineo);

        //        conexion.Open();
        //        insertar.ExecuteNonQuery();
        //        conexion.Close();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public TOHistoriaClinica consultarHistorialClinico(String cedula)
        {
            try
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
                        to.Columna = reader.GetString(29);
                        to.Otros_Quirurgico = reader.GetString(30);
                        to.DM_Fam = reader.GetString(31);
                        to.HTA_Fam = reader.GetString(32);
                        to.Asma_Fam = reader.GetString(33);
                        to.Cancer_Fam = reader.GetString(34);
                        to.Epilepsia_Fam = reader.GetString(35);
                        to.Demencias_Fam = reader.GetString(36);
                        to.Enferm_Psiq_Fam = reader.GetString(37);
                        to.Otros_Fam = reader.GetString(38);
                        to.grupo_Sanguineo = reader.GetString(39);
                    }
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                return to;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }


        public void insertarActualizar(TOHistoriaClinica historialClinica)
        {
            try
            {
                string update = "begin tran if exists(select * from HISTORIAL_CLINICO with (updlock, serializable) where cedula = @ced) begin update HISTORIAL_CLINICO set HTA = @hta, dm = @dm, asma = @asma, epilepsia = @epilepsia, enferm_cardiaca = @enfCard, displidemias = @displidemias, ENFERM_PSQUIATRIC = @enfPsiquiatrica, OTROS_PERSON_PATOLOG = @otros_Person_Patol, fuma = @fuma, licor= @licor, drogas = @drogas, alergias = @alergias, OTROS_PERS_NO_PATOLOG = @otros_pers_no_patolog, menarca = @menarca, fur = @fur, embarazos = @embaraz, abortos = @abort, quistes_ovaricos = @quistOvaric, endometriosis = @endometriosis, OTROS_GINECOBSTETRICO = @otros_ginecoobstet, medicamentos = @medicam, otros_medicamentos = @otros_Medic, fracturas = @fracturas, vesicula = @vesicula, apendice = @apendice, cordales = @cordales, litiasis = @litiasis, columna = @columna, otros_quirug = @otros_quirurg, dm_fam = @dm_fam, hta_fam = @hta_fam, asma_fam = @asma_fam, cancer_fam = @cancerfam, epilepsia_fam = @epilepsiaFam, demencias_fam = @demenciasFam, enferm_psiqfam = @enfPsquitrFam, otros_fam = @otrosFam, grupo_sanguineo = @grupoSanguineo where cedula = @ced; " +
                "end else begin insert into historial_clinico(CEDULA, HTA, DM, ASMA, EPILEPSIA, ENFERM_CARDIACA, DISPLIDEMIAS, ENFERM_PSQUIATRIC, OTROS_PERSON_PATOLOG, FUMA, LICOR, DROGAS, ALERGIAS, OTROS_PERS_NO_PATOLOG, MENARCA, FUR, EMBARAZOS, ABORTOS, QUISTES_OVARICOS, ENDOMETRIOSIS, OTROS_GINECOBSTETRICO, MEDICAMENTOS, OTROS_MEDICAMENTOS, FRACTURAS, VESICULA, APENDICE, CORDALES, LITIASIS, COLUMNA, OTROS_QUIRUG, DM_FAM, HTA_FAM, ASMA_FAM, CANCER_FAM, EPILEPSIA_FAM, DEMENCIAS_FAM, ENFERM_PSIQFAM, OTROS_FAM, GRUPO_SANGUINEO) values(@ced, @hta, @dm, @asma, @epilepsia, @enfCard, @displidemias, @enfPsiquiatrica, @otros_Person_Patol, @fuma, @licor, @drogas, @alergias, @otros_pers_no_patolog, @menarca, @fur, @embaraz, @abort, @quistOvaric, @endometriosis, @otros_ginecoobstet, @medicam, @otros_Medic, @fracturas, @vesicula, @apendice, @cordales, @litiasis, @columna, @otros_quirurg, @dm_fam, @hta_fam, @asma_fam, @cancerfam, @epilepsiaFam, @demenciasFam, @enfPsquitrFam, @otrosFam, @grupoSanguineo); end commit tran";

                SqlCommand insertar = new SqlCommand(update, conexion);
                //insertar.Parameters.AddWithValue("@idhist", historialClinica.Id_Historial);
                insertar.Parameters.AddWithValue("@ced", historialClinica.cedula);
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
                insertar.Parameters.AddWithValue("@otros_pers_no_patolog", historialClinica.Otros_Person_No_Patologic);
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

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                insertar.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
