using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string celular { get; set; }


        public Persona(int id, string nombre, int edad, string celular)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.celular = celular;
        }

        public Persona()
        {
        }
    }
}
