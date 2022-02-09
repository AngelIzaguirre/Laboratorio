using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L3_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 - Haga un programa para facturar en una panadería, da un descuento por
                   comprar a sus clientes con membresía dependiendo el tipo, si es tipo A
                   da 10 % de descuento, si es tipo B da 15 % de descuento y 20 % de
                   descuento.*/

            char tipo;
            double compra, totalCompra;
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el monto de la compra");
                    compra = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tipo de mebresia");
                    tipo = char.Parse(Console.ReadLine());
                    if (tipo == 'a')
                    {
                        totalCompra = compra - (compra * 0.10);
                        Console.WriteLine($"El tota a Pagar es={totalCompra} tipo de membresia= {tipo}");
                    }
                    else if (tipo == 'b')
                    {
                        totalCompra = compra - (compra * 0.15);
                        Console.WriteLine($"El tota a Pagar es={totalCompra} tipo de membresia= {tipo}");
                    }
                    else
                    {
                        totalCompra = compra - (compra * 0.20);
                        Console.WriteLine($"El tota a Pagar es={totalCompra} tipo de membresia= Otro");
                    }
                    continuar = false;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deberias ingresar un valor numerico");
                }
            } while (continuar);
            Console.ReadLine();
        }

    }
}

