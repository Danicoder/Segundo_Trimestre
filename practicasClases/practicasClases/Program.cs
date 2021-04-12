using System;

namespace practicasClases
{
    class Program
    {
        public static void Array()
        {
            string[] unarray = new string[5];
            for (int i = 0; i < 5; i++)
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

            Console.WriteLine("aquí los días de la semana: " + diaSemana.Length);
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

                    //para cada array muestra el valor almacenado en cada espacio de cero en adelante (ascendente)
                    for (int j = 0; j < valorArray[j]; j++)
                    {
                        Console.WriteLine("{0} \n\n", valorArray[j]);

                        //muestra el array[] de forma descendente
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
        /*funcion que calcule mínimo, máx y la media que hay dentro del array*/
        public static int CalculateMin(int[] number)
        {
            int contador = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (contador > number[i])
                {
                    contador = number[i];
                }
            }
            return contador;
        }
        public static int CalculateMax(int[] number)
        {
            int contador = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (contador < number[i])
                {
                    contador = number[i];
                }
            }
            return contador;
        }
        public static int CalculateMedia(int[] number)
        {
            int contador = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (contador < number[i])
                {
                    contador = number[i];
                }
            }
            return contador;
        }
        /*funcion que ordene los valores*/
        public static int OrderNumbers(int[] vect, int a)
        {
            int contador = vect[0];
            for (int i = a + 1; i < vect.Length; i++)
            {
                if (contador > vect[i])
                {
                    contador = i;
                }
            }
            return contador;
        }
        public static void PruebaBusqueda()
        {
            //buscar el array que pda el usuario, luego se le informa donde se ha encontrado (BUSQUEDA ARRAY)
            Console.WriteLine("Introduce el valor a buscar");
            int lugarArray = Convert.ToInt32(Console.ReadLine());
            int[] miArray = { 2, 3, 7, 8 };

            for (int k = 0; k < miArray.Length; k++)
            {
                if (miArray[k] == lugarArray)
                {
                    Console.WriteLine("El número {0} ha sido encontrado en la posición {0}" + lugarArray, k);
                    //la primera variable después de la coma se asigna a cada {}
                    goto mi_etiqueta;
                }
                //si el n esta repetido y cuantas veces esta repetido

                /*int contador = 0;
                else if (miArray[k] == lugarArray)
                {
                    contador++;
                }*/
            }
            Console.WriteLine("El número no ha sido encontrado");
        mi_etiqueta: Console.WriteLine("El número introducido no esta en el array");

        }
        /*for detro de otro que no se ejecuta*/

        static void Main()
        {
            /*
             - si no inicializo el array empieza desde cero.
             - A diferencia de las listas, el array tiene un límmite*/

            //Array();
            //InicialisarArray();
            //DiasSemana();
            //ArrayInteger();
            //PruebaBusqueda();
            int[] num = { 3, 9, 8, 7, 60 };
            int valor = CalculateMin(num);
            /*Console.WriteLine("El valor mínimo es {0}: "+valor);
            int valor2 = CalculateMax(num);
            Console.WriteLine("El valor máximo es {0}: " + valor2);
            int valor3 = CalculateMedia(num);
            Console.WriteLine("El valor máximo es {0}: " + valor3);*/

            /*int valor4 = 0;
            int aux = 0;
            for(int i=0;i<num.Length;i++)
            {
                //podría ser con un if
                valor4 = OrderNumbers(num, i);
                aux = num[i];
                num[i] = num[valor4];
                num[valor4] = aux;
            }*/
            //PilaCola.PilaPiramide();
            PilaCola.NotacionPolaca();

            Console.WriteLine("Escribe tú DNI");
            string DNI = Listas.ComprobarDatos(Console.ReadLine());
        }
    }
}
