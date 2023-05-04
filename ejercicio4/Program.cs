using System;
//4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los
 //dos primeros es mayor al producto del segundo con el tercero.

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float Numero1,Numero2,Numero3;

            Console.WriteLine("Ingrese un Numero por favor: ");
            Numero1 = float.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese un Numero por favor: ");
            Numero2 = float.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese un Numero por favor: ");
            Numero3 = float.Parse(Console.ReadLine());

            if((Numero1+Numero2) > (Numero2*Numero3)){

                Console.WriteLine("Es mayor ");

            }else {
                Console.WriteLine("Es menor ");
            }




        }
    }
}
