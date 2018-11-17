using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;
namespace BL
{
    public class BLManejadorFoto
    {

        public void insertar(BLFoto foto) {
            new DAOFichaDoctor().insertarFoto(convert(foto));
        }

        public BLFoto consultar (int idDoctor) {
            return convert(new DAOFichaDoctor().consultarFoto(idDoctor));
        }



        public BLFoto convert(TOFoto foto) {
            return new BLFoto(foto.url, foto.idDoctor);
        }

        public TOFoto convert(BLFoto foto)
        {
            return new TOFoto(foto.url, foto.idDoctor);
        }
    }
}
