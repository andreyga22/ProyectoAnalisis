using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOHistoriaClinica
    {
        public int Id_Historial { get; set; }
        public string grupo_Sanguineo { get; set; }
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

        public TOHistoriaClinica()
        {

        }

        public TOHistoriaClinica(int id_Historial, string grupo_Sanguineo, bool hTA, bool dM, bool asma, bool epilepsia,
            string enferm_Cardiacas, bool displidemias, string enferm_Psiquiatricas, string otros_Person_Patologic,
            bool fuma, bool licor, bool drogas, string alergias, string otros_Person_No_Patologic, bool menarca,
            DateTime fUR, int embarazos, int abortos, int quistesOvaricos, bool endometriosis,
            string otros_Ginecobstetrico, string medicamentos, string indicacionesMedicamentos, string fracturas,
            string vesicula, bool apendice, bool cordales, string litiasis, string columna, string otros_Quirurgico,
            string dM_Fam, string hTA_Fam, string asma_Fam, string cancer_Fam, string epilepsia_Fam,
            string demencias_Fam, string enferm_Psiq_Fam, string otros_Fam)
        {
            this.Id_Historial = id_Historial;
            this.grupo_Sanguineo = grupo_Sanguineo;
            this.HTA = hTA;
            this.DM = dM;
            this.Asma = asma;
            this.Epilepsia = epilepsia;
            this.Enferm_Cardiacas = enferm_Cardiacas;
            this.Displidemias = displidemias;
            this.Enferm_Psiquiatricas = enferm_Psiquiatricas;
            this.Otros_Person_Patologic = otros_Person_Patologic;
            this.Fuma = fuma;
            this.Licor = licor;
            this.Drogas = drogas;
            this.Alergias = alergias;
            this.Otros_Person_No_Patologic = otros_Person_No_Patologic;
            this.Menarca = menarca;
            this.FUR = fUR;
            this.Embarazos = embarazos;
            this.Abortos = abortos;
            this.QuistesOvaricos = quistesOvaricos;
            this.Endometriosis = endometriosis;
            this.Otros_Ginecobstetrico = otros_Ginecobstetrico;
            this.Medicamentos = medicamentos;
            this.IndicacionesMedicamentos = indicacionesMedicamentos;
            this.Fracturas = fracturas;
            this.Vesicula = vesicula;
            this.Apendice = apendice;
            this.Cordales = cordales;
            this.Litiasis = litiasis;
            this.Columna = columna;
            this.Otros_Quirurgico = otros_Quirurgico;
            this.DM_Fam = dM_Fam;
            this.HTA_Fam = hTA_Fam;
            this.Asma_Fam = asma_Fam;
            this.Cancer_Fam = cancer_Fam;
            this.Epilepsia_Fam = epilepsia_Fam;
            this.Demencias_Fam = demencias_Fam;
            this.Enferm_Psiq_Fam = enferm_Psiq_Fam;
            this.Otros_Fam = otros_Fam;
        }
    }
}
