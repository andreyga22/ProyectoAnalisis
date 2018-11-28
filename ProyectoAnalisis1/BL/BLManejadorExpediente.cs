using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;
namespace BL
{
    public class BLManejadorExpediente
    {

        public void insertarExpediente(BLExpediente bl) {
            try {
                DAOExpediente dao = new DAOExpediente();
                dao.insertar(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public void insertarModificar(BLExpediente bl) {
            DAOExpediente dao = new DAOExpediente();
            try
            {
                dao.guardarActualizar(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> consultarListaExpedNombre(string nombre)
        {
            try
            {
                DAOExpediente dao = new DAOExpediente();
                List<TOExpediente> listaTO = dao.consultarListaExpedNombre(nombre);
                List<BLExpediente> listaBL = new List<BLExpediente>();
                foreach (TOExpediente consulta in listaTO)
                {
                    listaBL.Add(convert(consulta));
                }
                return listaBL;
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> consultarListaCedula(string cedula) {
            try {
                DAOExpediente dao = new DAOExpediente();
                List<TOExpediente> listaTO = dao.consultarListaCedula(cedula);
                List<BLExpediente> listaBL = new List<BLExpediente>();
                foreach (TOExpediente consulta in listaTO) {
                    listaBL.Add(convert(consulta));
                }
                return listaBL;
            } catch (Exception) {
                throw;
            }
        }

        public BLExpediente consultarExpediente(string cedula) {
            try {
                DAOExpediente dao = new DAOExpediente();
                return convert(dao.consultar(cedula));
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> consultarListaDia() {
            try {
                DAOExpediente dao = new DAOExpediente();
                List<TOExpediente> listaTO = dao.consultarDia();
                List<BLExpediente> listaBL = new List<BLExpediente>();
                foreach (TOExpediente consulta in listaTO) {
                    listaBL.Add(convertAlergia(consulta));
                }
                return listaBL;
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> consultarListaExpedientes()
        {
            try
            {
                DAOExpediente dao = new DAOExpediente();
                List<TOExpediente> listaTO = dao.consultarExpedientes();
                List<BLExpediente> listaBL = new List<BLExpediente>();
                foreach (TOExpediente consulta in listaTO)
                {
                    listaBL.Add(convertAlergia(consulta));
                }
                return listaBL;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void insertarDia(string cedula) {
            try {
                DAOExpediente dao = new DAOExpediente();
                dao.insertarDia(cedula);
            } catch (Exception) {
                throw;
            }
        }

        public void borrarDia(string ced) {
            try {
                new DAOExpediente().borrarDia(ced);
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> filtrarFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DAOConsulta consult = new DAOConsulta();
            List<TOConsulta> listConsultFiltradTO = new List<TOConsulta>();
            List<TOConsulta> listConsultas = consult.listaConsultas();
            if (listConsultas.Count > 0)
            {
                foreach (TOConsulta consultaTO in listConsultas)
                {
                    consultaTO.fecha = new DateTime(consultaTO.fecha.Year, consultaTO.fecha.Month, consultaTO.fecha.Day);
                    int resultado1 = DateTime.Compare(fechaInicio, consultaTO.fecha);
                    int resultado2 = DateTime.Compare(fechaFin, consultaTO.fecha);
                    if (resultado1 <= 0 && resultado2 >= 0)
                    {
                        listConsultFiltradTO.Add(new TOConsulta(consultaTO.idConsulta, consultaTO.fecha, consultaTO.cedula, consultaTO.precio_Consulta));
                    }
                }
            }

            DAOExpediente daoExp = new DAOExpediente();
            List<TOExpediente> todosExped = daoExp.consultarExpedientes();
            List<TOExpediente> expedFiltrad = new List<TOExpediente>();
            if (todosExped.Count > 0)
            {
                foreach (TOExpediente ex in todosExped)
                {
                    foreach (TOConsulta con in listConsultFiltradTO)
                    {
                        if (ex.cedula.Equals(con.cedula))
                        {
                             expedFiltrad.Add(ex);
                        }
                    }
                }
            }
            List<TOExpediente> listaFinalExped = new List<TOExpediente>();
            for (int i = 0; i < expedFiltrad.Count; i++)
            {
                if (listaFinalExped.Count <= 0 && expedFiltrad.Count > 0)
                {
                    listaFinalExped.Add(expedFiltrad[i]);
                }
                else
                {
                    Boolean esta = false;
                    for (int j = 0; j < listaFinalExped.Count; j++)
                    {
                        if (listaFinalExped[j].cedula.Equals(expedFiltrad[i].cedula))
                        {
                            esta = true;
                        }
                    }
                    if(esta == false)
                    {
                        listaFinalExped.Add(expedFiltrad[i]);
                    }
                }
            }
            List<BLExpediente> blExped = new List<BLExpediente>();
            foreach(TOExpediente exp in listaFinalExped)
            {
                blExped.Add(convert(exp));
            }
            return blExped;
        }


        private TOExpediente convert(BLExpediente exp) {
            return new TOExpediente(exp.cedula, 
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido, 
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil, 
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
        }

        private BLExpediente convert(TOExpediente exp)
        {
            return new BLExpediente(exp.cedula,
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido,
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil,
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
        }

        private TOExpediente convertAlergia(BLExpediente exp) {
            TOExpediente e = new TOExpediente(exp.cedula,
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido,
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil,
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
            e.alergias = exp.alergias;
            return e;
        }

        private BLExpediente convertAlergia(TOExpediente exp) {
            BLExpediente e = new BLExpediente(exp.cedula,
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido,
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil,
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
            e.alergias = exp.alergias;
            return e;
        }


        public void prueba() {
            DAOExpediente dao = new DAOExpediente();
            dao.pruebaConexion();
        }

        public void actualizarExpediente(BLExpediente bl)
        {
            DAOExpediente dao = new DAOExpediente();
            dao.actualizar(convert(bl));
        }

        
    }
}
