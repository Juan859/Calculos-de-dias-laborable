using System;

namespace CalculadoraDiasYsueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Días Trabajados y Sueldo");

            Console.Write("Ingrese la fecha de inicio (yyyy-MM-dd): ");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha actual (yyyy-MM-dd): ");
            DateTime fechaActual = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese el sueldo por día: ");
            double sueldoPorDia = Convert.ToDouble(Console.ReadLine());

            // Cálculo de días trabajados
            TimeSpan diasTrabajados = fechaActual - fechaInicio;
            int diasLaborados = diasTrabajados.Days;

            // Cálculo del sueldo
            double sueldoTotal = sueldoPorDia * diasLaborados;

            Console.WriteLine($"Días trabajados: {diasLaborados}");
            Console.WriteLine($"Sueldo total: {sueldoTotal:C}");

            Console.ReadLine();
        }
    }
}
