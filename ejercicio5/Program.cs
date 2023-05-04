using System;
//5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si 
//los mismos se encuentran ordenados de forma decreciente .

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float Numero1,Numero2,Numero3,Numero4;

            Console.WriteLine("Ingrese un numero por favor:");
            Numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero por favor:");
              Numero2 = float.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese un tercer numero por favor:");
                Numero3 = float.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese un cuarto numero por favor:"); 
               Numero4 = float.Parse(Console.ReadLine());

                if(Numero1 > Numero2 && Numero2 > Numero3 && Numero3 > Numero4){

                    Console.WriteLine ("Los numeros estan ordenados de forma decreciente ");


                } else 
                {
                     Console.WriteLine("Los numeros estan Desordenados ");
          
                }

        }
    }
}
