using System;

namespace practicasClases
{
    class Program
    {
        public static void Array()
        {
            string[] unarray = new string[5];
            for(int i=0; i < 5;i++)
                Console.WriteLine(unarray[i]);
            Console.WriteLine("aquí las 6 filas");
        }
        public static void InicialisarArray()
        {
            int[] miarray = new int[7];
            miarray[0] = 1;
            miarray[3] = 4;
            Console.WriteLine(miarray);
        }
        public static void DiasSemana() 
        {
            string[] diaSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            //string[] diaSemana = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            Console.WriteLine("aquí los días de la semana: "+ diaSemana.Length);
        } 
        
        /*Array de enteros que indique el tamaño del array, indicado por el usuario
         Si hay un array de cinco que aparesca n los arrays hasta ese nº
        quiero que imprima el array al contrario(contadores) y que se guarde invertido*/
        public static void ArrayInteger()
        {
                Console.WriteLine("Introduce el tamaño del array");
                int tamaño = Convert.ToInt32(Console.ReadLine());
                int[] valorArray = new int[tamaño];

            for (int i = 0; i < valorArray.Length; i++)
            {
                try
                {
                    Console.WriteLine("  introduzca el valor para la celda {0}: \n", i);
                    valorArray[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("El array introducido es: ");

                    for (int j = 0; j < valorArray[j]; j++)
                    {
                        Console.WriteLine("{0} \n\n", valorArray[j]);

                        for (int h = valorArray[tamaño - 1]; h >= 0; h--)
                        {
                            Console.Write("\n\nEl array es: " + valorArray[h]);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Introduce un valor correcto");
                }
            }
        }
        static void Main()
        {
            //Array();
            //InicialisarArray();
            //DiasSemana();
            ArrayInteger();
        }
    }
}
