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
        public void pruebaInsertarFicha_Param_ThrowsNull()
        {
            BLFichaParamedico ficha_null = null;
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            manejador_prueba.insertar(ficha_null);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarFicha_Param_ThrowsSqlException()
        {

            BLFichaParamedico ficha_prueba = new BLFichaParamedico(1, 1, "idEmpleado", "120/60", 1, 165, 65, "glicemiaaaaaa", "ddddddddddd", "obs", 1, 2, "78", "pupilas", "piel", "notasparam");
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            manejador_prueba.insertar(ficha_prueba);
        }

        [TestMethod]
        public void pruebaInsertarFicha_Param()
        { 

            BLFichaParamedico ficha_prueba = new BLFichaParamedico(1, 1, "doc01", "120/60", 1, 165, 65, "glicemia", "oxi", "obs", 1, 2, "78", "pupilas", "piel", "notasparam");
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            manejador_prueba.insertar(ficha_prueba);

            Assert.AreEqual(ficha_prueba.idConsulta, (manejador_prueba.consultar(ficha_prueba.idConsulta).idConsulta));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaConsultarFicha_Param_ThrowsNull()
        {
            BLFichaParamedico ficha_null = null;
            BLManejadorFichaParamedico manejador_prueba = new BLManejadorFichaParamedico();

            manejador_prueba.consultar(ficha_null.idConsulta);
        }
    }
}
