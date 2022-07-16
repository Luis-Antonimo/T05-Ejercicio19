using System;

namespace T05Ejercicio19
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué tamañao tendrá el array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[longitud];

            ValoresRandom(array);
            Console.WriteLine();
            MuestraMayor(array);
        }

        static void ValoresRandom(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                bool primo = false;
                int numero = 0;
                while (!primo)
                {
                    numero = GenerarRandom();
                    primo = EsPrimo(numero);
                }
                array[i] = numero;
            }

        }

        static void MuestraMayor(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El {0}º valor-primo del array es: {1}", i + 1, array[i]);
            }
            Console.WriteLine("El valor mayor del array es: " + array.Max());
        }

        private static int GenerarRandom()
        {
            Random rnd = new Random();
            //No me queda claro si se le pide al usuario el rango de números,
            //por lo que opto porque vayan de 0 a 100 y evitar cálculos largos.
            int aleatorio = rnd.Next(0, 100);
            return aleatorio;
        }

        static Boolean EsPrimo(int numero)
        {
            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            //Si se ha podido dividir solo dos veces es primo (por 1 y por sí mismo)
            //en caso de que el contador sea mayor de 2 no es primo.
            if (contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}