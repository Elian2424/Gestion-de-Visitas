using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;
namespace NEGOCIO
{
    public class nvisita
    {

        dvisitas objDATO = new dvisitas();

        public List<econsulta>listandovisita(string consulta)
        {
            return objDATO.listarvisita(consulta);

        }

        public void insertandoregitro(evisitas visita)
        {
            objDATO.insertarregistro(visita);
        }

        public void insertandoedificio(evisitas visita)
        {
            objDATO.insertaredificio(visita);
        }

        public void insertandoarea(evisitas visita)
        {
            objDATO.insertararea(visita);
        }

        

        public void insertandousuariog(evisitas visita)
        {
            objDATO.insertarusuariog(visita);

        }

        public void editandoedificio(evisitas visita)
        {
            objDATO.editaredificio(visita);
        }
        public void editandoarea(evisitas visita)
        {
            objDATO.editararea(visita);
        }
        
    }
}
