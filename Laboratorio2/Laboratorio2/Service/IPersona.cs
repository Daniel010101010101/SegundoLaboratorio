using Laboratorio2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Service
{
    interface IPersona
    {

        void Crear(persona persona);


        List<persona> LisDatatable();
    }
}
