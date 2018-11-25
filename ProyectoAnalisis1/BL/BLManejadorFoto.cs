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

        public List<BLFoto> consultar (int idDoctor) {
            List<TOFoto> lista = new DAOFichaDoctor().consultarFoto(idDoctor);
            List<BLFoto> lista2 = new List<BLFoto>();
            foreach (TOFoto foto in lista) {
                lista2.Add(convert(foto));
            }
            return lista2;
        }

        public void borrarFoto(BLFoto foto) {
            new DAOFichaDoctor().borrarFoto(convert(foto));
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
