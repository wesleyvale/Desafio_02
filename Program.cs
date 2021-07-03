using System;

namespace Desafio_02
{
    class Program
    {
        static string[] nomes = new string[3] { "Ubuntu1 Silva", "Ubuntu2 Santos", "Ubuntu3 Silva" };
        static int[] idades = new int[3] { 33, 26, 85 };
        static double[] pesos = new double[3] { 88.50, 84.50, 66.50 };
        static decimal[] alturas = new decimal[3] { 1.65M, 2.10M, 1.40M };
        static bool[] EhDev = new bool[3] { true, true, false };

        static void Main(string[] args)
        {
            int somaIdades = 0;

            foreach(int idade in idades)
            {
                somaIdades += idade;
            }

            Console.WriteLine("T1: A soma das idades de todos os Ubuntus é: " + somaIdades + " anos");

            NomesUbuntu();

            MediaIMC();

            UbuntusDev();

            UbuntusSilva();

            Console.ReadLine();
        }
        
        static void NomesUbuntu()
        {
            Console.Write("T2: O nome de todos os Ubuntus são: ");

            foreach (string nome in nomes)
            {
                Console.Write(nome + " ");
            }
        }
        static void MediaIMC()
        {
            double somaDosIMCS = 0;

            for (int contador = 0; contador < pesos.Length; contador++)
            {
                somaDosIMCS += pesos[contador] / (decimal.ToDouble(alturas[contador]) * decimal.ToDouble(alturas[contador]));
            }

            Console.Write("\nT3: A média dos IMC'S de todos os Ubuntus é: " + Math.Round(somaDosIMCS / pesos.Length, 2));
        }
        static int UbuntusDev()
        {
            int soma = 0;

            foreach(bool EhDev in EhDev)
            {
                if (EhDev == true) soma++;
            }
            Console.Write("\nT4: A quantidade de Ubuntus Dev é: " + soma);

            return soma;
        }
        static void UbuntusSilva()
        {
            Console.Write("\nT5: Os Ubuntus com o nome 'Silva' são: ");

            foreach(string nome in nomes)
            {
                 if (nome.Contains("Silva"))
                 {
                    Console.Write(nome + " ");
                 }
            }
        }
    }
}
