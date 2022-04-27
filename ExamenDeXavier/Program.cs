using System;

namespace ExamenDeXavier
{
    class Program
    {
        public class Opciones
        {
            public static string continuar = "1";

        }

        public class Paciente
        {

            public int edad { get; set; }
            public bool tieneHipertencion { get; set; }
            public bool tieneObesidad { get; set; }
            public bool tieneDiabetes { get; set; }


        }
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al sistema de gestion de pacientes.");
            Console.WriteLine("Ingrese 1 si desea ingresar un paciente");

            string opcion = Console.ReadLine();

            while (opcion == Opciones.continuar)
            {
                Paciente paciente = new Paciente();

                Console.WriteLine("Ingrese la edad del paciente.");
                paciente.edad = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese 1 si el paciente padece de Diabetes, si no ingrese 0");

                paciente.tieneDiabetes = Console.ReadLine() == "1" ? true : false;

                Console.WriteLine("Ingrese 1 si el paciente padece de Hipertencion, si no ingrese 0");
                paciente.tieneHipertencion = Console.ReadLine() == "1" ? true : false;

                Console.WriteLine("Ingrese 1 si el paciente padece de Obesidad, si no ingrese 0");
                paciente.tieneObesidad = Console.ReadLine() == "1" ? true : false;

                if (paciente.edad > 60)
                {
                    if (paciente.tieneDiabetes == true || paciente.tieneHipertencion == true || paciente.tieneObesidad == true)
                    {
                        Console.WriteLine("El paciente es apto para la vacuna");
                        Console.WriteLine("Desea registrar otro paciente?");
                        Console.WriteLine("Ingrese 1 si asi lo desea.");
                        opcion = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("El paciente no es apto para la vacuna");
                    Console.WriteLine("Desea registrar otro paciente?");
                    Console.WriteLine("Ingrese 1 si asi lo desea.");
                    opcion = Console.ReadLine();
                }

            }

        }
    }
}
