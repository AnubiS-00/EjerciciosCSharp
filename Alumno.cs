using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Seccion_9___Clases
{
    internal class Alumno : Persona
    {
        private string _id;

        public Alumno() { }

        public Alumno(string id)
        {
            _id = id;
        }

        //public void setId(string id)
        //{
        //    _id = id;
        //}
        public string getId() {
            return this._id;
        }

        public bool existeNumeroAlumno(List<Alumno> lstAlumno, string numeroAlumno)
        {
            bool existe = false;

            foreach (Alumno alumno in lstAlumno)
            {
                existe = alumno.getId() == numeroAlumno;
            }

            return existe;
        }

        public void añadirAlumno(string nombre, List<Alumno> lstAlumno, List<Persona> lstPersona)
        {
            añadirNombre(nombre);
            Console.WriteLine("Introduce tu numero de alumno :");
            string numAlumno = Console.ReadLine();
            if (existeNumeroAlumno(lstAlumno, numAlumno))
            {
                Console.WriteLine("Ya existe ese alumno.");
            }
            else
            {
                Alumno cAlumno = new Alumno()
                {
                    nombre = nombre,
                    edad = edad,
                    _id = numAlumno
                };

                lstAlumno.Add(cAlumno);
                lstPersona.Add(cAlumno);
            }
        }
    }
}
