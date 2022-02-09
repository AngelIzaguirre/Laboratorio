using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L6_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Un almacén de pedidos por correo vende cinco productos distintos, cuyos
               precios de venta son los siguientes: producto 1, $2.98; producto 2, $4.50;
               producto 3, $9.98; producto 4, $4.49 y producto 5, $6.87.Escriba un
               programa que lea una serie de pares de números, como se muestra a
               continuación:
               a) número del producto
               b) cantidad vendida
               Su programa debe utilizar una instrucción switch para determinar el precio
               de venta de cada producto. Debe calcular y mostrar el valor total de venta
               de todos los productos vendidos. Use un ciclo controlado por centinel a
               para determinar cuándo debe el programa dejar de iterar para mostrar los
               resultados finales.*/





            int producto, cantidadProducto;
            double montoTotal = 0, subTotal = 0;
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("hay 5 productos:  producto 1, $2.98; producto 2, $4.50; producto 3, $9.98; producto 4, $4.49 y producto 5, $6.87");
                    Console.WriteLine("Ingrese el numero del primer producto");
                    Console.WriteLine("Si desea terminar ingrese -1");
                    producto = int.Parse(Console.ReadLine());

                    while (-1 != producto)
                    {
                        switch (producto)
                        {
                            case 1:
                                Console.WriteLine("ingrese la cantidad de este produto que dese comprar");
                                cantidadProducto = int.Parse(Console.ReadLine());
                                subTotal = (2.98 * cantidadProducto);
                                montoTotal = montoTotal + subTotal;
                                Console.WriteLine($"Producto 1: {subTotal}");
                                break;

                            case 2:
                                Console.WriteLine("ingrese la cantidad de este produto que dese comprar");
                                cantidadProducto = int.Parse(Console.ReadLine());
                                subTotal = (4.50 * cantidadProducto);
                                montoTotal = montoTotal + subTotal;
                                Console.WriteLine($"Producto 2: {subTotal}");
                                break;

                            case 3:
                                Console.WriteLine("ingrese la cantidad de este produto que dese comprar");
                                cantidadProducto = int.Parse(Console.ReadLine());
                                subTotal = (9.98 * cantidadProducto);
                                montoTotal = montoTotal + subTotal;
                                Console.WriteLine($"Producto 3: {subTotal}");
                                break;

                            case 4:
                                Console.WriteLine("ingrese la cantidad de este produto que dese comprar");
                                cantidadProducto = int.Parse(Console.ReadLine());
                                subTotal = (4.49 * cantidadProducto);
                                montoTotal = subTotal + montoTotal;
                                Console.WriteLine($"Producto 4: {subTotal}");
                                break;

                            case 5:
                                Console.WriteLine("ingrese la cantidad de este produto que dese comprar");
                                cantidadProducto = int.Parse(Console.ReadLine());
                                subTotal = (6.87 * cantidadProducto);
                                montoTotal = subTotal + montoTotal;
                                Console.WriteLine($"Producto 5: {subTotal}");
                                break;

                            default:
                                Console.WriteLine("Error introdusca numero de producto valido");
                                break;
                        }

                        Console.WriteLine("Por favor introdusca el numero del siguiente producto");
                        Console.WriteLine("De lo contrario ingrese -1 para finalizar");
                        producto = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Las ventas totales son: ${montoTotal} ");
                    Console.WriteLine("Tenga un buen dia");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deverias ingrresar un valor numerico");
                }
            } while (continuar);
            Console.ReadLine();
        }

    }

}
    
