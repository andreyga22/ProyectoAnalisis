﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class BLManejadorDireccion
    {
        public void insertar(BLDireccion bl) {
            DAODireccion dao = new DAODireccion();
            dao.insertarDireccion(convert(bl));

            
        }

        public BLDireccion consultar(String ced) {
            DAODireccion dao = new DAODireccion();
            return convert(dao.consultar(ced));
        }

        public BLDireccion convert(TODireccion to)
        {
            return new BLDireccion(to.idDireccion, to.cedula ,to.provincia, to.canton, to.distrito, to.otrasSenas);
        }

        public TODireccion convert(BLDireccion bl)
        {
            return new TODireccion(bl.idDireccion, bl.cedula ,bl.provincia, bl.canton, bl.distrito, bl.otrasSenas);
        }
    }
}
