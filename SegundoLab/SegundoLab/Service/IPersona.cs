using SegundoLab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoLab.Service
{
    interface IPersona
    {
        void Guardar(persona persona );
        List<persona> listardatos();
    
    }
}
