using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Data;


namespace pruebasProyectoTasiste
{
    [TestClass]
    public class pruebaManejadorExpediente
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void pruebaInsertarModificarExpediente_ThrowsNull()
        {
            BLExpediente exped = null;
            BLManejadorExpediente manejExp = new BLManejadorExpediente();

            manejExp.insertarModificar(exped);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void pruebaInsertarModificarExpediente_ThrowsSqlException()
        {
            BLExpediente exped = new BLExpediente("123", "Maya", "María", "Sol", "Roj", Convert.ToDateTime("2016/11/28"), "89782156", "N/A", "Soltera", "Estudiante", "Femenino");
            BLManejadorExpediente manejExp = new BLManejadorExpediente();

            manejExp.insertarModificar(exped);
        }


        [TestMethod]
        public void pruebaInsertarModificarExpediente()
        {
            BLExpediente exped = new BLExpediente("123", "Maya", "María", "Sol", "Roj", Convert.ToDateTime("2016/11/28"), "89782156", "N/A", "Soltera", "Estudiante", "F");
            BLManejadorExpediente manejExp = new BLManejadorExpediente();

            manejExp.insertarModificar(exped);
        }
    }
}
