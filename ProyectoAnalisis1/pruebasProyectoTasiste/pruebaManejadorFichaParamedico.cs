using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorFichaParamedico
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarFicha_Doct_ThrowsNull()
        {
            //Arrange

            BLFichaParamedico ficha_null = null;
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            //Act
            manejador_prueba.insertar(ficha_null);
        }

        [TestMethod]
        public void pruebaInsertarFicha_Param()
        {
            //Arrange

            BLFichaParamedico ficha_prueba = new BLFichaParamedico(1, 1, "120/60", "1", 1, 1, 1, "d", "f", "1", 2, 3, 1, "d", "f", "g");
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();


            //Act
            manejador_prueba.insertar(ficha_prueba);

            //Assert

            Assert.AreEqual(ficha_prueba.idConsulta, (manejador_prueba.consultar(ficha_prueba.idConsulta).idConsulta));
        }
    }
}
