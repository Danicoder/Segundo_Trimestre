using System;
using System.Collections.Generic; //nops sirve para trabajar con pilas
using System.Text;

namespace practicasClases
{
    class PilaCola //más reserva dinámicas de memoria
    {
         public static void PilaPiramide()
         {
            Stack<string> mipila = new Stack<string>();
            Console.WriteLine("Introduce número");
            int contador =Convert.ToInt32(Console.ReadLine());

            string micadena = "";
            for (int i = 0; i < contador ;i++)
            {
                micadena = "";
                for(int j=i; j<contador;j++)
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
           
            do
            {
                incrementa:
                Console.WriteLine("introduce el número (enter para acabar)");
                aux = Console.ReadLine();
                
                if (aux != "")
                {
                    mipila.Push(Convert.ToInt32(aux));
                }
                else if (mipila.Count == 1 && aux=="")
                {
                    Console.WriteLine("se necesita mínimo otro valor. Pulse enter para continuar");
                    aux = Console.ReadLine();
                    goto incrementa;
                    
                }
            }
            while (aux != ""); //para que cómo mínimo me pida dos valores

            for (int i = 0; i < mipila.Count - 1; i++)
            {
                Console.WriteLine("introduce el operador  (enter para acabar)");
                micola.Enqueue(Convert.ToChar(Console.ReadLine()));
            }
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
