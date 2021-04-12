using System;

namespace practicasClases
{
    class Listas
    {
        //funcion que pida los datos al usuario
        public static void ComprobarDatos(string DNI)
        {
            Console.WriteLine("Escribe tú nombre");
            string Nombre = Console.ReadLine();

            pedir;
            char[] letra = { 'T', 'L', 'S', 'A', 'O' };
            char letraDNI;
            string num_DNI;

            letraDNI = char.ToUpper(DNI[8]);


            Console.WriteLine("Error DNI");
            num_DNI = DNI.Remove(8, 2);
            if (Comprobar(dni) != 9)
            {
                Console.WriteLine("Error DNI");
                goto:pedir;
            }
            else DNI = cumprueba(DNI);


            Console.WriteLine("Escribe tú DNI");
            if (DNI != letra[9])
            {
                DNI = Console.ReadLine();
            }


            Console.WriteLine("Escribe cúal fue la cantidad del prestamo");
        }

        //numero primo que de su divicion de resto o, divicion entera
        /*1º localizo primos en A (antes debo recorrer A)
         2º Para cada elemento de A ver si es primo
        3º Si es primo ver si esta en B
        4º Si esta en B, añadir a C*/

        /*public static void EsPrimo(int listaA)
        {
            int esprimo = 0;
            for (int i = 0; i < Listas.Count; i++)
            {
                if (esprimo(listaA[i]) && listaB.Countains(listaA[i]))
                    esprimo ListA[i];
            }
        }
        public static bool EsPrimo2(int num)
        {
            for(int i=0;i<num;i++)
            {
                if (num % i == 0)
                    return false;
                return true;
            }
        }*/
        /*Arraylist ListaA [] = new Arraylist();
        List<int> ListaA = new Listcints();

        int a= List[0];

        public static void suma(int a, int b)
        {
            b++
            return (a + refb);

            int c;
            c=suma()
        }
        //funcion que sume dos a una lista 
        
         * 
         * suma (listaA)
         * for(int i =1; i< sum.count;i++)
         * {
         *  scw[i]+=1
         * }
         * como es un array list no necesito pasarle el retourn
         
         */
        /*funcion que detecte si en ese arraylist esta el n x incluido
            public static bool esta32(Arraylist miAr)
            {
                if (miAr.Contains(32))
                {
                return true;
                }
                else return false;
            }
        */
    }
}
