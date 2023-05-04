using System;
//1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

//La resta si el primero es mayor que el segundo.
//La suma si son iguales.
//El producto si el primero es menor.

namespace ejercicio1
{
    class Program
    {
        

        static void Main(string[] args)

        {
            float Numero1,Numero2,Sumar,Restar,Productor;

            Console.WriteLine("Ingrese un numero por favor: ");
            Numero1 = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese un segundo numero por favor: ");
            Numero2 = float.Parse(Console.ReadLine());

            if(Numero1==Numero2){
              Sumar = Numero1 + Numero2;
              Console.WriteLine("El resultado de la suma  es: " +Sumar);


            } else if(Numero1 > Numero2){

                Restar = Numero1 - Numero2;
                Console.WriteLine("La resta es: " +Restar);
            }else{
                Productor = Numero1*Numero2; 
                 Console.WriteLine("El resultado del producto es: " +Productor);

            }

        }
    }
}
