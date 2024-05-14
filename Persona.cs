using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Seccion_9___Clases
{
    internal class Persona
    {
        protected string nombre {  get; set; }
        protected int edad { get; set; }

        public Persona()
        {           
        }

        public Persona(string s_nombre, int i_edad)
        {
            nombre = s_nombre;
            edad = i_edad;
        }

        public void añadirEdad(string edad)
        {
            this.edad = Int32.Parse(edad) >= 0 ? Int32.Parse(edad) : throw new ArgumentException("La edad no puede ser inferior a 0");
        }

        public void añadirNombre(string nombre)
        {
            this.nombre = !nombre.Equals("") || !nombre.Equals(" ") ? nombre : throw new ArgumentException("El nombre no puede estar vacío.");
        }

        public bool mayorDeEdad ()
        {
            return this.edad > 17 ? true : false ;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getEdad()
        {
            return this.edad;
        }
    }
}
