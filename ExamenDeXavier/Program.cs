using System;

namespace ExamenDeXavier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de gestion de pacientes.");
            Console.WriteLine("Ingrese 1 si desea ingresar un paciente");

            string opcion = Console.ReadLine();

            while (opcion == "1")
            {
                Console.WriteLine("Ingrese la edad del paciente.");
                int edad = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Dia si el paciente padece de Diabetes, si no ingrese 0");

                string tieneDiabetes = Console.ReadLine();

                Console.WriteLine("Ingrese hArte si el paciente padece de Hipertencion Arterial, si no ingrese 0");
                string tieneHipertencion = Console.ReadLine();

                Console.WriteLine("Ingrese Obe si el paciente padece de Obesidad, si no ingrese 0");
                string tieneObesidad = Console.ReadLine();

                if (edad > 60 && edad < 100)
                {
                    if (tieneDiabetes == "Dia" || tieneHipertencion == "hArte" || tieneObesidad == "Obe")
                    {
                        Console.WriteLine("El paciente es apto para la vacuna");
                        Console.WriteLine("Desea registrar otro paciente?");
                        Console.WriteLine("Ingrese 1 si asi lo desea.");
                        opcion = Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("El paciente no es apto para la vacuna");
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
