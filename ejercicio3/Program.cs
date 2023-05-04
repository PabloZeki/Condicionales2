using System;
//3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
//Para ello existe la siguiente escala de precios:

//        i5 (1)  i7 (2)	    i9 (3)
//8 RAM (1)	USD 800	USD 900	USD 1200
//16 RAM (2)USD 900	USD 1000	USD 1400
//32 RAM (3)USD 1000	USD 1400	USD 2000
//Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede 
//ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que 
//solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
//(ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de
 //la máquina seleccionada.

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float Procesador,Memoria_Ram,Extension_Disco,Monto_Total,Monto_Parcial=0;

            Console.WriteLine("Ingrese el tipo de procesador eleguido (opcion,1,2,3):");
            Procesador = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de memoria ram eleguido (opcion,1,2,3):");
            Memoria_Ram = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese si desea extender la capacidad del disco duro (opcion 1,0):");
            Extension_Disco = float.Parse(Console.ReadLine());

           if(Procesador == 1 && Memoria_Ram == 1){
            Monto_Parcial = 800f;

           }else if (Procesador== 1 && Memoria_Ram == 2) {
            Monto_Parcial = 900f;

           }else if ( Procesador == 1 && Memoria_Ram == 3){

            Monto_Parcial = 1000f;
           }else if( Procesador == 2 && Memoria_Ram == 1){

            Monto_Parcial = 900f;
           }
           else if( Procesador == 2 && Memoria_Ram == 2){
            Monto_Parcial = 1000f;
           }else if( Procesador == 2 && Memoria_Ram == 3){

            Monto_Parcial = 1400f;
           }else if ( Procesador == 3 && Memoria_Ram == 1){

            Monto_Parcial = 1200f;

           }else if ( Procesador == 3 && Memoria_Ram == 2){
            Monto_Parcial = 1400f;
           }
           else if( Procesador == 3 && Memoria_Ram == 3){

            Monto_Parcial = 2000f;
           }
                
            
            if (Extension_Disco == 1){

                Monto_Total= Monto_Parcial+ 300f;
            }else
            {
                Monto_Total=Monto_Parcial;
            }

            Console.WriteLine("El monto total a abonar es de: " +Monto_Total);



        }
    }
}
