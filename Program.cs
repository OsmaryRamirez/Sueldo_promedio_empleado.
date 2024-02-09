using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUCLE_2

{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Sueldo promedio del empleado");
            Console.WriteLine();


            // leer el sueldo de 3 empleados, calcular el prmoedio de esos sueldos y mostrar en pantalla 


            double sueldo, total, promedio;


            // inicializar el acumulador total
            total = 0;
            


                for (int i = 1; i <= 3; i++)
                { 
                Console.WriteLine("sueldo del empleado " + i);
                sueldo = Convert.ToDouble(Console.ReadLine());
                total += sueldo;

                 } 
            // calcular el promedio 
            promedio = total / 3;

            Console.WriteLine("el sueldo promedio de un empleado es " + promedio);



        }
    }
}
