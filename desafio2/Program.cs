using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ubuntu 002 - Starts...");



            string nome1 = "Ubuntu Silva";
            int idade1 = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1 = true;

            string nome2 = "Ubuntu Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;



            // T1 - Somar a idade de todos Ubuntus
            int idadeTotal = idade1 + idade2 + idade3;
            Console.WriteLine($"T1 - A soma da idade dos ubuntos é: {idadeTotal}");
            Console.WriteLine();



            // T2 - Agrupar o nome de todos Ubuntus
            Console.WriteLine($"T2 - Os ubuntus são: {nome1}, {nome2} e {nome3}");
            Console.WriteLine();



            // T3 - Calcular a média IMC de todos Ubuntus

            decimal imc1 = (decimal)peso1 / (altura1 * altura1);
            decimal imc2 = (decimal)peso2 / (altura2 * altura2);
            decimal imc3 = (decimal)peso3 / (altura3 * altura3);
            decimal MédiaTodos = (decimal)imc1 + imc2 + imc3;

            Console.WriteLine("T3 - As médias IMC dos Ubuntus são:");
            Console.WriteLine();
            Console.WriteLine($"Ubuntu Silva 1: {imc1.ToString("F")}");
            Console.WriteLine($"Ubuntu Santos: {imc2.ToString("F")}");
            Console.WriteLine($"Ubuntu Silva 2: {imc3.ToString("F")}");
            Console.WriteLine($"A soma das médias é: {MédiaTodos.ToString("F")}");
            Console.WriteLine();


            // T4 - Contar quantos Ubuntus são Devs

            Console.WriteLine("T4 - Os seguintes Ubuntus são Devs:");

            if (EhDev1 == true)
            {
                Console.WriteLine("Ubuntu Silva 1");
            }
            else
            {
                Console.WriteLine();
            }

            if (EhDev2 == true)
            {
                Console.WriteLine("Ubuntu Santos");
            }
            else
            {
                Console.WriteLine();
            }

            if (EhDev3 == true)
            {
                Console.WriteLine("Ubuntu Silva 2"); ;
            }
            else
            {
                Console.WriteLine();
            }


            // T5 - Exibir somente Ubuntus com nome Silva

            if (String.Equals(nome1, nome2))
            {
                Console.WriteLine($"T5 - {nome1} e {nome2} tem nome Silva");
            }
            else
            {
                Console.WriteLine();
            }


            if (String.Equals(nome2, nome3))
            {
                Console.WriteLine($"T5 - {nome2} e {nome3} tem nome Silva");
            }
            else
            {
                Console.WriteLine();
            }


            if (String.Equals(nome1, nome3))
            {
                Console.WriteLine($"T5 -  {nome1} e {nome3} tem nome Silva");
            }
            else
            {
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
