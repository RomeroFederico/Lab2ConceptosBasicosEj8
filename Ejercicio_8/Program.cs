using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_8
{

    /*
    08.  Por teclado se ingresa el valor hora, el nombre, la antigüedad 
    (en años) y la cantidad de horas trabajadas en el mes de n 
    empleados de una fábrica.  
    Se pide calcular el importe a cobrar teniendo en cuenta que el 
    total (que resulta de multiplicar el valor hora por la cantidad 
    de horas trabajadas), hay que sumarle la cantidad de años 
    trabajados multiplicados por $ 150, y al total de todas esas 
    operaciones restarle el 13% en concepto de descuentos.  
    Mostrar el recibo correspondiente con el nombre, la antigüedad, 
    el valor hora, el total a cobrar en bruto, el total de descuentos 
    y el valor neto a cobrar de todos los empleados ingresados.
    
    Nota: Utilizar estructuras repetitivas y selectivas. 
    */
    class Ejercicio_8
    {
        static void Main(string[] args)
        {            
            int empleados;

            Console.Title = "Ejercicio Nro. 8";

            Console.Write("Ingrese la cantidad de empleados: ");

            int.TryParse(Console.ReadLine(), out empleados);

            string[] nombre = new string[empleados];
            double[] valorHora = new double[empleados];
            int[] antiguedad = new int[empleados];
            int[] horasTrabajadas = new int[empleados];
            double[] importe = new double[empleados];

            for (int i = 0; i < empleados; i++, Console.Clear())
            {
                Console.Clear();
                Console.Write("Ingrese el nombre del empleado Nro. {0}: ",i + 1);
                nombre[i] = Console.ReadLine();

                Console.Clear();
                Console.Write("Ingrese el valor hora de {0}: ", nombre[i]);
                double.TryParse(Console.ReadLine(), out valorHora[i]);

                Console.Clear();
                Console.Write("Ingrese la antiguedad de {0}: ", nombre[i]);
                int.TryParse(Console.ReadLine(), out antiguedad[i]);

                Console.Clear();
                Console.Write("Ingrese las horas trabajadas de {0}: ", nombre[i]);
                int.TryParse(Console.ReadLine(), out horasTrabajadas[i]);

                importe[i] = (valorHora[i] * horasTrabajadas[i] + antiguedad[i] * 150) * 0.87;

                Console.Clear();
                Console.WriteLine("Empleado registrado. ");
                Console.ReadKey();
            }

            Console.WriteLine("Mostrando empleados:\n");

            for (int i = 0; i < empleados; i++)
            {
                Console.WriteLine(". Nombre: {0}\n. Antiguedad: {1}\n. Valor hora: ${2,0:#,###.00}", nombre[i], antiguedad[i], valorHora[i]);
                Console.WriteLine(". Total bruto: ${0,0:#,###.00}", importe[i] * 100 / 87);
                Console.WriteLine(". Descuentos: ${0,0:#,###.00}", importe[i] * 13 / 87);
                Console.WriteLine(". Total neto: ${0,0:#,###.00}\n", importe[i]);
            }

            Console.ReadKey();
        }
    }
}