using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Data.SqlClient;
using System.Data;

namespace pruebasProyectoTasiste
{

    [TestClass]
    public class pruebaManejadorFichaDoctor
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarFicha_Doct_ThrowsNull()
        {

            BLFichaDoctor ficha_null = null;
            BLManejadorFichaDoctor manejador_prueba = new BLManejadorFichaDoctor();

            manejador_prueba.insertar(ficha_null);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarFicha_doct_ThrowsSQLException()
        {

            BLFichaDoctor ficha_prueba = new BLFichaDoctor(1, 1, "doc01", "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111" +
                "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", "prueba", "inyectar");
            BLManejadorFichaDoctor manejador_prueba = new BLManejadorFichaDoctor();

            manejador_prueba.insertar(ficha_prueba);

        }

        [TestMethod]
        public void pruebaInsertarFicha_doct()
        {

            BLFichaDoctor ficha_prueba = new BLFichaDoctor(168, 168, "doc01", "dolores estomacales", "prueba", "inyectar");
            BLManejadorFichaDoctor manejador_prueba = new BLManejadorFichaDoctor();

            manejador_prueba.insertar(ficha_prueba);


            Assert.AreEqual(ficha_prueba.idConsulta, (manejador_prueba.consultar(ficha_prueba.idConsulta).idConsulta));
        }
    }
}
