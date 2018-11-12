using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;

namespace pruebasProyectoTasiste
{

    [TestClass]
    public class pruebaManejadorFichaDoctor
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarFicha_Doct_ThrowsNull()
        {
            //Arrange

            BLFichaDoctor ficha_null = null;
            BLManejadorFichaDoctor manejador_prueba = new BLManejadorFichaDoctor();

            //Act
            manejador_prueba.insertar(ficha_null);
        }

        [TestMethod]
        public void pruebaInsertarFicha_doct()
        {
            //Arrange

            BLFichaDoctor ficha_prueba = new BLFichaDoctor(1, 1, "IDE", "dolores estomacales", "prueba", "inyectar");
            BLManejadorFichaDoctor manejador_prueba = new BLManejadorFichaDoctor();


            //Act
            manejador_prueba.insertar(ficha_prueba);

            //Assert

            Assert.AreEqual(ficha_prueba.idConsulta, (manejador_prueba.consultar(ficha_prueba.idConsulta).idConsulta));
        }
    }
}
