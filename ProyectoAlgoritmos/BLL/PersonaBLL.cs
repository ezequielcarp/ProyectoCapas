using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class PersonaBLL
    {
        public static int AgregarPersona(Persona persona)
        {
            if (string.IsNullOrEmpty(persona.nombre)) return 0;
            return PersonaDAL.AgregarPersona(persona);
        }

        public static int ModificarPersona(Persona persona)
        {
            if (persona.id <= 0 || string.IsNullOrEmpty(persona.nombre)) return 0;
            return PersonaDAL.ModificarPersona(persona);
        }

        public static int EliminarPersona(int id)
        {
            if (id <= 0) return 0;
            return PersonaDAL.EliminarPersona(id);
        }
    

    public static List<Persona> PresentarRegistro()
        {
            return PersonaDAL.PresentarRegistro();
        }
    }
}

