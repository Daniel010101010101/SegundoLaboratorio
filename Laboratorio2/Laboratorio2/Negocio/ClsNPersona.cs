using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio2.Data;
using Laboratorio2.Repository;

namespace Laboratorio2.Negocio
{
    class ClsNPersona : ClsRPersona
    {
       public int Acceso(persona persona)
        {
            if (persona.edadPersona >= 18)
            {

                return 0;
            }
            else
                return 1;


        }

        public void Guardar(persona per)
        {
            Crear(per);
        }
        public List<persona> ListFinal()
        {

            List<persona> Lista = LisDatatable();


            return Lista;
        }


    }


}
