using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float consumo;
            double descuento;
            double impuesto;
            double subtotal;
            double importe;

            Console.WriteLine("Ingrese el consumo:");
            consumo = Convert.ToSingle(Console.ReadLine());

            if (consumo < 100)
            {
                descuento = consumo * 0.1;
            }
            else
            {
                descuento = consumo * 0.2;
            }

            impuesto = consumo * 0.18;

            subtotal = consumo - descuento;

            importe = subtotal + impuesto;

            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Impuesto: " + impuesto);
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Importe: " + importe);
            Console.ReadKey();
        }
    }
}
