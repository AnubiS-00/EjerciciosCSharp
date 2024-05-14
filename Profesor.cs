using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Seccion_9___Clases
{
    internal class Profesor : Persona
    {
        private string asignatura {  get; set; }
        public Profesor() { }

        public void setMateria(string materia)
        {
            asignatura = materia;
        }
        public string getMateria()
        {
            return this.asignatura;
        }

        public void añadirProfesor(string nombre, List<Profesor> lstProfesor, List<Persona> lstPersona)
        {
            añadirNombre(nombre);
            Console.WriteLine("Introduce la materia :");
            setMateria(Console.ReadLine());
            Profesor cProfesor = new Profesor()
            {
                nombre = nombre,
                edad = edad,
                asignatura = asignatura
            };
            lstProfesor.Add(cProfesor);
            lstPersona.Add(cProfesor);
        }
    }
}
