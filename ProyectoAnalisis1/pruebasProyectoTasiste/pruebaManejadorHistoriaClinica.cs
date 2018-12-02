using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Data.SqlClient;
using System.Data;

namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorHistoriaClinica
    {
        [TestMethod]
        public void MethinsertarActualizarHistorialClinico()
        {
            BLHistoriaClinica historial = new BLHistoriaClinica(0, "504060873", "O+", false, true, false, false, "Enfermedades cardiacas", false, "No tiene", "otros patologic", true,
                true, true, "alergias", "dsd", false, "14/02/2018", 0, 0, 0, false, "otros gineco", "medicamentos", "indic medicam", "no tiene", "vesicula",
                true, true, "asdas", "rer", "otros quirugic", "dm familiares", "hta familiares", "asma familiar", "cancer familiar", "epilepsia familiar", "demencias familiares",
                "enf psiquiatricas familiares", "otros famili");

            BLManejadorHistoriaClinica manejadHistorClin = new BLManejadorHistoriaClinica();
            manejadHistorClin.insertarActualizarHistorialClinico(historial);

            Assert.AreEqual(historial.cedula, (manejadHistorClin.consultarHistorialClinico(historial.cedula).cedula));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebainsertarActualizarHistorialClinico_ThrowsNull()
        {
            BLHistoriaClinica histClin = null;
            BLManejadorHistoriaClinica manejHist = new BLManejadorHistoriaClinica();

            manejHist.insertarActualizarHistorialClinico(histClin);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarModificarHistorial_ThrowsSqlException()
        {
            BLHistoriaClinica hist = new BLHistoriaClinica(0, "123", "ABCDEF", false, true, false, false, "Enfermedades cardiacas", false, "No tiene", "otros patologic", true,
                true, true, "alergias", "dsd", false, "14/02/2018", 0, 0, 0, false, "otros gineco", "medicamentos", "indic medicam", "no tiene", "vesicula",
                true, true, "asdas", "rer", "otros quirugic", "dm familiares", "hta familiares", "asma familiar", "cancer familiar", "epilepsia familiar", "demencias familiares",
                "enf psiquiatricas familiares", "otros famili");
            BLManejadorHistoriaClinica manejHistClin = new BLManejadorHistoriaClinica();

            manejHistClin.insertarActualizarHistorialClinico(hist);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarHistorial_ThrowsSqlException()
        {
            BLHistoriaClinica hist = new BLHistoriaClinica(0, "123", "ABCDEF", false, true, false, false, "Enfermedades cardiacas", false, "No tiene", "otros patologic", true,
                true, true, "alergias", "dsd", false, "14/02/2018", 0, 0, 0, false, "otros gineco", "medicamentos", "indic medicam", "no tiene", "vesicula",
                true, true, "asdas", "rer", "otros quirugic", "dm familiares", "hta familiares", "asma familiar", "cancer familiar", "epilepsia familiar", "demencias familiares",
                "enf psiquiatricas familiares", "otros famili");
            BLManejadorHistoriaClinica manejHistClin = new BLManejadorHistoriaClinica();

            manejHistClin.insertarHistorialClinico(hist);
        }

        [TestMethod]
        public void MetInsertarHistorialClinico()
        {
            BLHistoriaClinica historial = new BLHistoriaClinica(0, "101230546", "O+", false, true, false, false, "Enfermedades cardiacas", false, "No tiene", "otros patologic", true,
                true, true, "alergias", "dsd", false, "14/02/2018", 0, 0, 0, false, "otros gineco", "medicamentos", "indic medicam", "no tiene", "vesicula",
                true, true, "asdas", "rer", "otros quirugic", "dm familiares", "hta familiares", "asma familiar", "cancer familiar", "epilepsia familiar", "demencias familiares",
                "enf psiquiatricas familiares", "otros famili");

            BLManejadorHistoriaClinica manejadHistorClin = new BLManejadorHistoriaClinica();
            manejadHistorClin.insertarHistorialClinico(historial);

        }
    }
}
