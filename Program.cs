using System;

namespace ContadorDeVocales
{
    class Program
    {
        static void Main(string[] args)
        {
            contadorDeVocales();

            static void contadorDeVocales()
            {
                //realizar funciones para que sea más facil de leer
                Console.WriteLine("Introduzca una palabra");
                string palabra = Console.ReadLine().ToLower();

                int contador = 0;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                    {
                        contador++;
                    }

                }

                Console.WriteLine("Usted a utilizado " + contador + " vocales");
            }
        }
    }
}
