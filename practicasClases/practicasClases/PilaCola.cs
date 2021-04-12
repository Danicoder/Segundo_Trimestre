using System;
using System.Collections.Generic; //nops sirve para trabajar con pilas

namespace practicasClases
{
    class PilaCola //más reserva dinámicas de memoria
    {
        public static void PilaPiramide()
        {
            Stack<string> mipila = new Stack<string>();
            Console.WriteLine("Introduce número");
            int contador = Convert.ToInt32(Console.ReadLine());

            string micadena = "";
            for (int i = 0; i < contador; i++)
            {
                micadena = "";
                for (int j = i; j < contador; j++)
                {
                    micadena = micadena + "";
                }
                mipila.Push(micadena); //pila
            }
            Console.WriteLine(mipila.Pop());
        }
        public static void NotacionPolaca()
        {
            Stack<int> mipila = new Stack<int>();/*para los numeros*/
            Queue<char> micola = new Queue<char>(); /*para las operaciones*/

            string aux;

            do //para que cómo mínimo me pida dos valores
            {
            incrementa:
                Console.WriteLine("introduce el número (enter para acabar)");
                aux = Console.ReadLine();

                if (aux != "")
                {
                    mipila.Push(Convert.ToInt32(aux));
                }
                else if (mipila.Count <= 1 && aux == "")
                {
                    Console.WriteLine("se necesita mínimo 2 valores.");

                    goto incrementa;

                }
            }
            while (aux != "");

            for (int i = 0; i < mipila.Count - 1; i++)
            {
                Console.WriteLine("introduce el operador  (enter para acabar)");
                micola.Enqueue(Convert.ToChar(Console.ReadLine()));
            }

            string car;
            do
            {
            intenta:
                Console.WriteLine("introduce el operador  (enter para acabar)");
                car = Console.ReadLine();

                if (car == "+" || car == "-" || car == "*" || car == "/")
                {
                    micola.Enqueue(Convert.ToChar(car));
                }
                else
                {
                    Console.WriteLine("operación incorrecta");
                    goto intenta;
                }
            }
            while (micola.Count < mipila.Count - 1);


            //primero desapilamos para volver a apilar
            /* variable1 = mipila.Pop();
             variable2 = mipila.Pop();
             variable3 = micola.Enqueue(Convert.ToChar());

             if (variable3 == '+')
             {

             }
             else if (variable3 = '*')
             {
                 variable2 = variable2 * variable1;
             }
             else if (variable3 = '/')
             {

             }
             else (variable3 = '-');*/
        }
    }
    /*  Calculadora de notacion polaca =-*266  numeros cola operadores pila(-*)
     el primer signo calculo los dos primeros números
     -+*-++7312121020
    guardar datos con pop  y luego un push con el resultado para que al final el contador quede a uno que será el resultado final*/


    /*Stack<string> mi_pila = new Stack<string>;
          Tipo de dato  nombre_variable =  TD

          para los métodos:
          pusch() --> coloca en cada fila las variables
          pop() --> te saca de la pila el primer elemento
          elementos que abarca la pila: .count

    cola:el primero qeu entra es el primero que sale, al salir sale del lado contrario
    poner generic implica poner el tipo de dato que se quiere poner en la cola, si no lo ponemos podemos guardar cualquier tipo de datos(entero,cadenas...)
    al ser dinámica contamos el numero de elementos que hay dentro
    pop para sacar el primer elemento de la pila se declara con stack y la cola con queue - dequeue quita la cola

    */
}
