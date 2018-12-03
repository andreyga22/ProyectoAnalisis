using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Data.SqlClient;

namespace pruebasProyectoTasiste
{
    /// <summary>
    /// Summary description for pruebaManejadorEmpleadocs
    /// </summary>
    [TestClass]
    public class pruebaManejadorEmpleado
    {
        [TestClass]
        public class pruebaManejadorDireccion
        {
            [TestMethod]
            [ExpectedException(typeof(NullReferenceException))]
            public void pruebaInsertarEmpleado_ThrowsNull()
            {

                BLEmpleado emp_null = null;
                BLManejadorEmpleado manejador = new BLManejadorEmpleado();

                manejador.crearNuevoEmpleado(emp_null);
            }

            [TestMethod]
            [ExpectedException(typeof(SqlException))]
            public void pruebaInsertarEmpleado_SqlException()
            {

                BLEmpleado emp_prueba = new BLEmpleado("Amirul", "amiru44", "Armando Fernandez", "Doctooooooooooooooooooooooooooooooooooooooor", true);
                BLManejadorEmpleado manejador_prueba = new BLManejadorEmpleado();
                manejador_prueba.crearNuevoEmpleado(emp_prueba);
            }

            [TestMethod]
            public void pruebaInsertarEmpleado()
            {
                BLEmpleado emp_prueba = new BLEmpleado("Hernan", "Feris12", "Doctor", "Fabio Lopez", true);
                BLManejadorEmpleado manejador_prueba = new BLManejadorEmpleado();
                manejador_prueba.crearActualizarEmpleado(emp_prueba);
                Assert.AreEqual(emp_prueba.id, manejador_prueba.buscarEmpleado(emp_prueba.id, emp_prueba.contrasenna).id);
       
                

            }
        }
    }
}
