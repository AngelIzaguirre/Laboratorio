using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L1_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 - Haga un programa para la venta de camisas que tiene una promoción,
                  esta dependerá del número de camisas que se compren Si son más de
                  diez, se les dará un 10 % de descuento sobre el total de la compra; si es
                  más de veinte, se les dará un 20 % de descuento; si son más de treinta
                  se les dará un 40 % de descuento.El precio de cada camisa es de 100.*/
    
                int numeroCamisas, montoCompra;
                double total;
                bool continuar = true;

                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese numero de camisas");
                        numeroCamisas = int.Parse(Console.ReadLine());
                        montoCompra = numeroCamisas * 100;
                        if (numeroCamisas <= 10)
                        {
                            Console.WriteLine($"El monto a pagar es: {montoCompra} ");
                        }
                        else if ((numeroCamisas > 10) && (numeroCamisas <= 20))
                        {
                            total = montoCompra - (montoCompra * 0.10);
                            Console.WriteLine($"El monto a pagar es: { total}");
                        }
                        else if ((numeroCamisas > 20) && (numeroCamisas <= 30))
                        {
                            total = montoCompra - (montoCompra * 0.20);
                            Console.WriteLine($"El monto a pagar es: {total} ");
                        }
                        else
                        {
                            total = montoCompra - (montoCompra * 0.40);
                            Console.WriteLine($"El monto a pagar es: {total} ");
                        }
                        continuar = false;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Deberias de ingresar un valor numerico");
                    }

                } while (continuar);
                Console.ReadLine();
            }
        }
    }


        
    

