using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L8_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8 - Un estacionamiento cobra una cuota mínima de $2.00 por estacionarse
                  hasta tres horas.El estacionamiento cobra $0.50 adicionales por cada
                  hora o fracción que se pase de tres horas. El cargo máximo para cualquier
                  periodo dado de 24 horas es de $10.00.Suponga que ningún automóvil
                  se estaciona durante más de 24 horas a la vez. Escriba un programa que
                  calcule e imprima los cargos por estacionamiento para cada uno de tres 
                  clientes que estacionaron su automóvil ayer en este estacionamiento.
                  Debe introducir las horas de estacionamiento para cada cliente.El
                  programa debe imprimir los resultados en un formato tabular ordenado,
                  debe calcular e imprimir el total de los recibos de ayer.El programa debe
                  utilizar la función calcularCargos para determinar el cargo para cada
                  cliente*/
            double hora1, hora2, hora3, cargo1, cargo2, cargo3, totalHoras, totalCargo;
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("Horas del automovil 1: ");
                    hora1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Horas del automovil 2: ");
                    hora2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Horas del automovil 3: ");
                    hora3 = double.Parse(Console.ReadLine());
                    cargo1 = calcularCargos(hora1);
                    cargo2 = calcularCargos(hora2);
                    cargo3 = calcularCargos(hora3);

                    totalHoras = hora1 + hora2 + hora3;
                    totalCargo = cargo1 + cargo2 + cargo3;

                    Console.WriteLine($"\n cliente     horas       cargos");
                    Console.WriteLine($"\n cliente1     {hora1}           {cargo1}");
                    Console.WriteLine($"\n cliente2     {hora2}           {cargo2}");
                    Console.WriteLine($"\n cliente3     {hora3}           {cargo3}");
                    Console.WriteLine($"\n Total        {totalHoras}          {totalCargo}");
                }



                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deberias de ingresar un valor numerico");
                }

            } while (continuar);
            Console.ReadLine();
        }
            static double calcularCargos(double parametroCargo)
            {
                double cargo = 0;

                if (parametroCargo == 24)
                {
                    cargo = 10;
                }
                else
                {
                    cargo = (parametroCargo - 3) * 0.5 + 2;
                }

                return cargo;

            }
        }
    }



    


  

