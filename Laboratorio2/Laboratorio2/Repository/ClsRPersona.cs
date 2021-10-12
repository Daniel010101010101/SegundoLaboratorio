using Laboratorio2.Data;
using Laboratorio2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Repository
{
    class ClsRPersona : IPersona
    {
        public void Crear(persona persona)
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                try
                {
                    persona persona1 = new persona();
                    persona1.idpersona = persona.idpersona;
                    persona1.nombrePersona = persona.nombrePersona;
                    persona1.edadPersona = persona.edadPersona;
                    persona1.descripcionPersona = persona.descripcionPersona;

                    conexionBd.persona.Add(persona);
                    conexionBd.SaveChanges();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);

                }
            }
        }

        public List<persona> LisDatatable()
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                List<persona> ListOfData = conexionBd.persona.ToList();

                return ListOfData;
            }
        }

       
           
    }
}
