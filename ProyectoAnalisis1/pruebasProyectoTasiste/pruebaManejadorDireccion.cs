using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Data.SqlClient;

namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorDireccion
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarDireccion_ThrowsNull()
        {

            BLDireccion dir_null = null;
            BLManejadorDireccion manejador_prueba = new BLManejadorDireccion();

            manejador_prueba.guardarModificar(dir_null);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarDireccion_SqlException()
        {

            BLDireccion dir_prueba = new BLDireccion(19, "504060873", "Alajuelaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Naranjo", "Cirri", "100 m suer de la plaza de deportes");
            BLManejadorDireccion manejador_prueba = new BLManejadorDireccion();
            manejador_prueba.guardarModificar(dir_prueba);
        }

        [TestMethod]
        public void pruebaInsertarDireccion()
        {
            BLDireccion dir_prueba = new BLDireccion(19, "504060873", "Alajuela", "Naranjo", "Cirri", "100 m suer de la plaza de deportes");
            BLManejadorDireccion manejador_prueba = new BLManejadorDireccion();
            manejador_prueba.guardarModificar(dir_prueba);

        }
    }
}
