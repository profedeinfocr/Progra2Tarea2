using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] empleado = { "Mariam", "Sofiaaaaaaaaaaa", "Alberto", "Guillermo", "Elias" };//Recibe los nombres de los empleados
            float[] salario = { 1000, 2000, 3000, 4000, 5000 };//Recibe los salarios de los empleados

            planilla(empleado, salario);//invoca al metodo planilla y le envía los nombres y salarios de los empleados

        }

        public static void planilla (string[] empleado, float[] salario)//Metodo que recibe nombre y salario de los empleados
        {
            string nombreLargo = "";//Para guardar el nombre mas largo

            //Genera una secuencia de tuplas con elementos a partir de las dos secuencias especificadas.
            //https://learn.microsoft.com/es-es/dotnet/api/system.linq.enumerable.zip?view=net-6.0
            var empleadoSalario = empleado.Zip(salario, (empl, sala) => empl + "  " + sala + "  " + (sala*12));
            foreach (var item in empleadoSalario)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < empleado.Length; i++)//para recorrer los nombres ingresados en el array
            {

                for (int u = 0; u < empleado[i].Length; u++) //para contar las letras de cada nombre
                {

                    if (u > nombreLargo.Length) //Para definir el nombre mas largo
                    {
                        nombreLargo = empleado[i];

                    }

                }

            }
                
            Console.WriteLine("El nombre mas largo es " + nombreLargo);
            Console.WriteLine("Gracias");
            Console.Read();
        }

    }
}
