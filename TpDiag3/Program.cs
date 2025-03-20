using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDiag3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            string[] nombre = new string[5];
            int[] edad = new int[5];
            int[] numero1 = new int[5];
            int[] numero2 = new int[5];
            int[] resultado = new int[5];
            Console.WriteLine("Ingrese que ejercicio quiere ver 1-5");
            Char op = Char.Parse(Console.ReadLine());
            switch(op)
            {
                case '1':
                    int cont = 0;
                    while (cont != 5)
                    {

                        Console.WriteLine("Ingrese el nombre de una cancion");
                        nombre[i] = Console.ReadLine();
                        i++;
                    }
                    while (i != 5)
                    {
                        Console.WriteLine($"cancion{i}: {nombre[i]}");
                        i++;
                    }
                    break;
                case '2':

                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de una cancion");
                        nombre[i] = Console.ReadLine();
                        
                    }
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"cancion{i}: {nombre[i]}");
                        
                    }
                    break;
                case '3':
                    while (i != 5)
                    {

                        Console.WriteLine("Ingrese su nombre");
                        nombre[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese su edad");
                        edad[i] = int.Parse(Console.ReadLine());
                        i++;
                    }
                    i = 0;
                    while (i != 5)
                    {
                        Console.WriteLine($"nombre: {nombre[i]}, edad: {edad[i]}");
                        i++;
                    }
                    break;
                case '4':
                    for (i = 0; i< 5; i++)
                    {
                        Console.WriteLine("Ingrese su nombre");
                        nombre[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese su edad");
                        edad[i] = int.Parse(Console.ReadLine());
                        
                    }
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"nombre: {nombre[i]}, edad: {edad[i]}");
                        
                    }
                    break;
                case '5':
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        numero1[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero");
                        numero2[i] = int.Parse(Console.ReadLine());


                        resultado[i] = numero1[i] + numero2[i];
                    }
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"suma 1: {numero1[i]} + {numero1[i]} = {resultado[i]}");

                    }
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
