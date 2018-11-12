using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Data.SqlClient;
using System.Data;

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
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarFicha_Param_ThrowsSqlException()
        {

            BLFichaParamedico ficha_prueba = new BLFichaParamedico(1, 1, "120/60", "1", 1, 1, 1, "ddddddddddd", "f", "1", 2, 3, 1, "d", "f", "g");
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            manejador_prueba.insertar(ficha_prueba);
        }

        [TestMethod]
        public void pruebaInsertarFicha_Param()
        { 

            BLFichaParamedico ficha_prueba = new BLFichaParamedico(1, 1, "120/60", "1", 1, 1, 1, "d", "f", "1", 2, 3, 1, "d", "f", "g");
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();


            //Act
            manejador_prueba.insertar(ficha_prueba);

            //Assert

            Assert.AreEqual(ficha_prueba.idConsulta, (manejador_prueba.consultar(ficha_prueba.idConsulta).idConsulta));
        }
    }
}
