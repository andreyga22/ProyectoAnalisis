using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;

namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorDireccion
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarDireccion_ThrowsNull()
        {
            //Arrange

            BLDireccion dir_null = null;
            BLManejadorDireccion manejador_prueba = new BLManejadorDireccion();

            //Act
            manejador_prueba.guardarModificar(dir_null);
        }

        [TestMethod]
        public void pruebaInsertarDireccion()
        {
            BLDireccion dir_prueba = new BLDireccion(19, "32165", "Alajuela", "naranjo", "cirri", "100 m suer de la plaza de deportes");
            BLManejadorDireccion manejador_prueba = new BLManejadorDireccion();
            manejador_prueba.guardarModificar(dir_prueba);

        }
    }
}
