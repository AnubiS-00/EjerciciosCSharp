using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Seccion_9___Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzando...");

            //Primera parte del ejercicio

            //List <Persona> lPersona = new List<Persona>();
            //for(int n = 1; n < 3; n++)
            //{
            //    Console.WriteLine("Persona numero " + n);
            //    Persona cPersona = new Persona();

            //    Console.WriteLine("Introduza el nombre : ");
            //    cPersona.añadirNombre(Console.ReadLine());
            //    Console.WriteLine("Introduza la edad : ");
            //    cPersona.añadirEdad(Console.ReadLine());

            //    lPersona.Add(cPersona);
            //    Console.WriteLine("-------------------");
            //}

            //esMayorDeEdad(lPersona);

            //Segunda Parte del ejecicio

            //List<Persona> lstPersona = new List<Persona>();
            //List<Alumno> lstAlumno = new List<Alumno>();
            //List<Profesor> lstProfesor = new List<Profesor>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Persona numero " + i);
            //    Console.WriteLine("Introduza el nombre : ");
            //    String nombre = Console.ReadLine();
            //    Console.WriteLine("Eres Alumno(1) o Profesor(2) ?");
            //    string tipo = Console.ReadLine();
            //    tipoDePersona(tipo, nombre, lstPersona, lstAlumno, lstProfesor);
            //}

            Console.WriteLine("Fin :)");
        }

        static void esMayorDeEdad (List<Persona> lPersona)
        {
            foreach (Persona persona in lPersona)
            {
                if (persona.mayorDeEdad())
                {
                    Console.WriteLine("Nombre : " + persona.getNombre() + " - Edad : " + persona.getEdad());
                }
                else
                {
                    Console.WriteLine("Nombre : " + persona.getNombre() + " - No es mayor de edad.");
                }
            }
        }
        static void tipoDePersona(string tipo, string nombre, List<Persona> lstPersona, List<Alumno> lstAlumno, List<Profesor> lstProfesor)
        {
            switch (tipo)
            {
                case "1":
                        Alumno cAlumno = new Alumno();
                        cAlumno.añadirAlumno(nombre, lstAlumno, lstPersona);
                    break;
                case "2":
                    Profesor cProfesor = new Profesor();
                    cProfesor.añadirProfesor(nombre, lstProfesor, lstPersona);
                    break;
            }
        }
    }
}
