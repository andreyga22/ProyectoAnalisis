using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLHistoriaClinica
    {
        public int Id_Historial { get; set; }
        public bool HTA { get; set; }
        public bool DM { get; set; }
        public bool Asma { get; set; }
        public bool Epilepsia { get; set; }
        public string Enferm_Cardiacas { get; set; }
        public bool Displidemias { get; set; }
        public string Enferm_Psiquiatricas { get; set; }
        public string Otros_Person_Patologic { get; set; }
        public bool Fuma { get; set; }
        public bool Licor { get; set; }
        public bool Drogas { get; set; }
        public string Alergias { get; set; }
        public string Otros_Person_No_Patologic { get; set; }
        public bool Menarca { get; set; }
        public DateTime FUR { get; set; }
        public int Embarazos { get; set; }
        public int Abortos { get; set; }
        public int QuistesOvaricos { get; set; }
        public bool Endometriosis { get; set; }
        public string Otros_Ginecobstetrico { get; set; }
        public string Medicamentos { get; set; }
        public string IndicacionesMedicamentos { get; set; }
        public string Fracturas { get; set; }
        public string Vesicula { get; set; }
        public bool Apendice { get; set; }
        public bool Cordales { get; set; }
        public string Litiasis { get; set; }
        public string Columna { get; set; }
        public string Otros_Quirurgico { get; set; }
        public string DM_Fam { get; set; }
        public string HTA_Fam { get; set; }
        public string Asma_Fam { get; set; }
        public string Cancer_Fam { get; set; }
        public string Epilepsia_Fam { get; set; }
        public string Demencias_Fam { get; set; }
        public string Enferm_Psiq_Fam { get; set; }
        public string Otros_Fam { get; set; }

        public BLHistoriaClinica()
        {

        }

        public BLHistoriaClinica(int id_Historial, bool hTA, bool dM, bool asma, bool epilepsia, 
            string enferm_Cardiacas, bool displidemias, string enferm_Psiquiatricas, string otros_Person_Patologic,
            bool fuma, bool licor, bool drogas, string alergias, string otros_Person_No_Patologic, bool menarca, 
            DateTime fUR, int embarazos, int abortos, int quistesOvaricos, bool endometriosis, 
            string otros_Ginecobstetrico, string medicamentos, string indicacionesMedicamentos, string fracturas, 
            
            string vesicula, bool apendice, bool cordales, string litiasis, string columna, string otros_Quirurgico,
            string dM_Fam, string hTA_Fam, string asma_Fam, string cancer_Fam, string epilepsia_Fam,
            string demencias_Fam, string enferm_Psiq_Fam, string otros_Fam)
        {
            Id_Historial = id_Historial;
            HTA = hTA;
            DM = dM;
            Asma = asma;
            Epilepsia = epilepsia;
            Enferm_Cardiacas = enferm_Cardiacas;
            Displidemias = displidemias;
            Enferm_Psiquiatricas = enferm_Psiquiatricas;
            Otros_Person_Patologic = otros_Person_Patologic;
            Fuma = fuma;
            Licor = licor;
            Drogas = drogas;
            Alergias = alergias;
            Otros_Person_No_Patologic = otros_Person_No_Patologic;
            Menarca = menarca;
            FUR = fUR;
            Embarazos = embarazos;
            Abortos = abortos;
            QuistesOvaricos = quistesOvaricos;
            Endometriosis = endometriosis;
            Otros_Ginecobstetrico = otros_Ginecobstetrico;
            Medicamentos = medicamentos;
            IndicacionesMedicamentos = indicacionesMedicamentos;
            Fracturas = fracturas;
            Vesicula = vesicula;
            Apendice = apendice;
            Cordales = cordales;
            Litiasis = litiasis;
            Columna = columna;
            Otros_Quirurgico = otros_Quirurgico;
            DM_Fam = dM_Fam;
            HTA_Fam = hTA_Fam;
            Asma_Fam = asma_Fam;
            Cancer_Fam = cancer_Fam;
            Epilepsia_Fam = epilepsia_Fam;
            Demencias_Fam = demencias_Fam;
            Enferm_Psiq_Fam = enferm_Psiq_Fam;
            Otros_Fam = otros_Fam;
        }

    }
}
