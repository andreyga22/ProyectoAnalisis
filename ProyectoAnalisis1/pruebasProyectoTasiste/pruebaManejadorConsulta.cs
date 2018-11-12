using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Data;

namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorConsulta
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarConsulta_ThrowsNull()
        {
            //Arrange

            BLConsulta cons_null = null;
            BLManejadorConsulta manejador_prueba = new BLManejadorConsulta();

            //Act
            manejador_prueba.insertar(cons_null);
        }

        [TestMethod]
        public void pruebaInsertarConsulta()
        {
            //Arrange

            BLConsulta cons_prueba = new BLConsulta(33, new DateTime(2018, 02, 03), "32165", 7);
            BLManejadorConsulta manejador_prueba = new BLManejadorConsulta();


            //Act
            manejador_prueba.insertar(cons_prueba);

            //Assert

            Assert.AreEqual(cons_prueba.idConsulta, (manejador_prueba.consultar(cons_prueba.idConsulta).idConsulta));
        }


        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarConsulta_ThrowsSQLExc()
        {
            

            BLConsulta cons_err = new BLConsulta(10, new DateTime(2006, 04, 03), "3216511111111111111111111111111111111111111111111111111111111111111111111", 7);
            BLManejadorConsulta manejador_prueba = new BLManejadorConsulta();

            
            manejador_prueba.insertar(cons_err);
        }

    }
}
