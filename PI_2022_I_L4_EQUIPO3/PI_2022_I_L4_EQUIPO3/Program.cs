using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L4_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 - Desarrolle un programa que utilice una instrucción while para determinar
                  el sueldo bruto para cada uno de varios empleados. La empresa paga la
                  “cuota normal” en las primeras 40 horas de trabajo de cada empleado, y
                  paga “cuota y media” en todas las horas trabajadas que excedan de 40.
                  Usted recibe una lista de los empleados de la empresa, el número de
                  horas que trabajó cada empleado la semana pasada y la tarifa
                  por horas de cada empleado. Su programa debe recibir como entrada esta
                  información para cada empleado, debe determinar y mostrar el sueldo
                  bruto de cada empleado.*/
            string nombreEmpleado;
            int horasTrabajadas, pagoHora, horasDemas;
            decimal total, pagoDemas;
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("este programa le ayudara a calcular el sueldo una persona");
                    Console.WriteLine("Si desea comezar escriba si de lo contrario escriba no");
                    string respuesta = Console.ReadLine();

                    while (respuesta != "no")
                    {
                        Console.WriteLine("Ingrese el nomnbre del empleado");
                        nombreEmpleado = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de las horas trabajasdas por el empleado en la semana");
                        horasTrabajadas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto que se paga por cada hora a este empleado");
                        pagoHora = int.Parse(Console.ReadLine());
                        if (horasTrabajadas > 40)
                        {
                            horasDemas = (horasTrabajadas - 40);
                            pagoDemas = (pagoHora / 2) + pagoHora;
                            total = ((horasTrabajadas - horasDemas) * pagoHora) + (horasDemas * pagoDemas);
                        }
                        else
                        {
                            total = (horasTrabajadas * pagoHora);
                        }
                        Console.WriteLine($"Nombre del empleado: {nombreEmpleado}");
                        Console.WriteLine($"El total a pagarle a este empleado es de: {total} lempiras");
                        Console.WriteLine("si desea acabar con el programa escriba NO si desea seguir escriba SI");
                        Console.WriteLine("Desea evaluar el pago de otro empleado?");
                        respuesta = Console.ReadLine();
                    }
                    Console.WriteLine("Tenga un buen dia");
                    continuar = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deberias ingresa un valor numerico");
                }
            } while (continuar);
            Console.ReadLine();
        }

    }
}

