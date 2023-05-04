using System;
//2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la 
//cantidad de litros vendidos según la siguiente escala:

//Si vende menos de 100 litros, no hay descuento.
//Si vende entre 101 y 300 litros, el descuento es del 10%.
//Si vende entre 301 y 500 litros, el descuento es del 15%.
//Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros
// vendidos y calcule y emita el importe con el descuento  aplicado..

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float Importe_Ventas,Litros_Vendidos,Importe_Final,Descuento=0;

            Console.WriteLine("Ingrese Importe de ventas: ");
            Importe_Ventas = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad de litros vendidos:");
            Litros_Vendidos = float.Parse(Console.ReadLine());

            if(Litros_Vendidos > 500){

                Descuento = Importe_Ventas*0.25f;

            }else if(Litros_Vendidos > 300 && Litros_Vendidos <= 500){

                Descuento = Importe_Ventas * 0.15f;

            }else if (Litros_Vendidos > 100 && Litros_Vendidos <= 300){

                Descuento = Importe_Ventas * 0.10f;
            }

                Importe_Final = Importe_Ventas-Descuento;

                Console.WriteLine("El importe total a abonar es de : " +Importe_Final);
        }
    }
}
