using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class BLManejadorHistoriaClinica
    {

        public void insertarActualizarHistorialClinico(BLHistoriaClinica bl)
        {
            try
            {
                DAOHistoriaClinica dao = new DAOHistoriaClinica();
                dao.insertarActualizar(convert(bl));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BLHistoriaClinica consultarHistorialClinico(String cedula)
        {
            try { 
            DAOHistoriaClinica dao = new DAOHistoriaClinica();
            return convert(dao.consultarHistorialClinico(cedula));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private BLHistoriaClinica convert(TOHistoriaClinica histClinica)
        {
            return new BLHistoriaClinica(histClinica.Id_Historial, histClinica.cedula, histClinica.grupo_Sanguineo, histClinica.HTA, histClinica.DM, histClinica.Asma, histClinica.Epilepsia,
           histClinica.Enferm_Cardiacas, histClinica.Displidemias, histClinica.Enferm_Psiquiatricas, histClinica.Otros_Person_Patologic,
                histClinica.Fuma, histClinica.Licor, histClinica.Drogas, histClinica.Alergias, histClinica.Otros_Person_No_Patologic, histClinica.Menarca,
            histClinica.FUR, histClinica.Embarazos, histClinica.Abortos, histClinica.QuistesOvaricos, histClinica.Endometriosis,
            histClinica.Otros_Ginecobstetrico, histClinica.Medicamentos, histClinica.IndicacionesMedicamentos, histClinica.Fracturas,
            histClinica.Vesicula, histClinica.Apendice, histClinica.Cordales, histClinica.Litiasis, histClinica.Columna, histClinica.Otros_Quirurgico,
            histClinica.DM_Fam, histClinica.HTA_Fam, histClinica.Asma_Fam, histClinica.Cancer_Fam, histClinica.Epilepsia_Fam,
            histClinica.Demencias_Fam, histClinica.Enferm_Psiq_Fam, histClinica.Otros_Fam);
        }

        private TOHistoriaClinica convert(BLHistoriaClinica histClinica)
        {
            return new TOHistoriaClinica(histClinica.Id_Historial, histClinica.cedula, histClinica.grupo_Sanguineo, histClinica.HTA, histClinica.DM, histClinica.Asma, histClinica.Epilepsia,
           histClinica.Enferm_Cardiacas, histClinica.Displidemias, histClinica.Enferm_Psiquiatricas, histClinica.Otros_Person_Patologic,
                histClinica.Fuma, histClinica.Licor, histClinica.Drogas, histClinica.Alergias, histClinica.Otros_Person_No_Patologic, histClinica.Menarca,
            histClinica.FUR, histClinica.Embarazos, histClinica.Abortos, histClinica.QuistesOvaricos, histClinica.Endometriosis,
            histClinica.Otros_Ginecobstetrico, histClinica.Medicamentos, histClinica.IndicacionesMedicamentos, histClinica.Fracturas,
            histClinica.Vesicula, histClinica.Apendice, histClinica.Cordales, histClinica.Litiasis, histClinica.Columna, histClinica.Otros_Quirurgico,
            histClinica.DM_Fam, histClinica.HTA_Fam, histClinica.Asma_Fam, histClinica.Cancer_Fam, histClinica.Epilepsia_Fam,
            histClinica.Demencias_Fam, histClinica.Enferm_Psiq_Fam, histClinica.Otros_Fam);
        }


        public void insertarHistorialClinico(BLHistoriaClinica bl)
        {
            try
            {
                DAOHistoriaClinica dao = new DAOHistoriaClinica();
                dao.insertarActualizar(convert(bl));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
