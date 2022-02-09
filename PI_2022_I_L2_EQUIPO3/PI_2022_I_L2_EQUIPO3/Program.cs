using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/* 2 - Desarrolle una aplicación que determine si alguno de los clientes de una
                   tienda de departamentos se ha excedido del límite de crédito en una
                   cuenta.Para cada cliente se tienen los siguientes
                   datos:
                   a) Número de cuenta(un entero)
                   b) Saldo al inicio del mes
                   c) Total de todos los artículos cargados por el cliente en el mes
                   d) Total de todos los créditos aplicados a la cuenta del cliente en el mes
                   e) Límite de crédito permitido.
                   El programa debe usar una instrucción while para recibir como entrada
                   cada uno de estos datos, debe calcular
                   el nuevo saldo(= saldo inicial + cargos – créditos) y determinar si éste
                   excede el límite de crédito del cliente.Para
                   los clientes cuyo límite de crédito se ha excedido, el programa debe
                   mostrar el número de cuenta del cliente, su límite
                   de crédito, el nuevo saldo y el mensaje “Se excedio el limite de su credito”.*/


			int cuenta;
			float saldoInicial, totalCargos, totalCreditos, limiteCreditos, saldo;
			bool continuar = true;
			string evaluar;
			do
			{
				try
				{
					Console.WriteLine("Este programa le ayudara a evaluar los creditos de un cliente");
					Console.WriteLine("En caso de que quiera iniciar ya escriba si en caso contrario escriba no");
					evaluar = Console.ReadLine();

					while (evaluar != "no")
					{
						Console.WriteLine("Introduzca el numero de cuenta del cliente");
						cuenta = int.Parse(Console.ReadLine());

						Console.WriteLine("Ingrese el saldo inicial");
						saldoInicial = float.Parse(Console.ReadLine());

						Console.WriteLine("Ingrese el Total de cargos realizados en el mes");
						totalCargos = float.Parse(Console.ReadLine());

						Console.WriteLine("Ingrese el Total de creditos disponibles en el mes");
						totalCreditos = float.Parse(Console.ReadLine());

						Console.WriteLine("Ingrese el limite de creditos en el mes");
						limiteCreditos = float.Parse(Console.ReadLine());

						saldo = (saldoInicial + totalCargos - totalCreditos);

						if (saldo > limiteCreditos)
						{
							Console.WriteLine($"numero de Cuenta: {cuenta}");
							Console.WriteLine($"limite de Credito: {limiteCreditos}");
							Console.WriteLine($"nuevo saldo: {saldo}");
							Console.WriteLine($"lamentablemente el limite de credito a exedido el maximo");

						}
						Console.WriteLine("si desea evaluar otra tarjeta escriba si de lo contrario escriba no");
						cuenta = int.Parse(Console.ReadLine());
						continuar = false;
					}

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
