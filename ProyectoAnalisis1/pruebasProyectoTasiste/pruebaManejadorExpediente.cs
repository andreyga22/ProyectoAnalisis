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
            BLExpediente exped = new BLExpediente("12643", "Miriam", "Maria", "Sol", "Roj", Convert.ToDateTime("2016/11/28"), "89782156", "N/A", "Solteraaaaaaaaaaaaaaa", "Estudiante", "Femenino", "89788156", "80782156", "telefono de mi madre", "telefono de mi padre");
            BLManejadorExpediente manejExp = new BLManejadorExpediente();

            manejExp.insertarModificar(exped);

        }


        [TestMethod]
        public void pruebaInsertarModificarExpediente()
        {
            BLExpediente exped = new BLExpediente("45789", "Fabiola", "Maria", "Sol", "Roj", Convert.ToDateTime("2016/11/28"), "89782056", "N/A", "Soltera", "Estudiante", "F", "89788156", "80782156", "telefono de mi madre", "telefono de mi padre");
            BLManejadorExpediente manejExp = new BLManejadorExpediente();

            manejExp.insertarModificar(exped);

           Assert.AreEqual(exped.cedula, (manejExp.consultarExpediente(exped.cedula).cedula));
        }
    }
}
