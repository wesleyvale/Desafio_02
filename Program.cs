using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus
            int IDADE = idade1 + idade2 + idade3;
            Console.WriteLine($"Os Ubuntus possuem uma idade total de: {IDADE}.");


            //T2 - Agrupar os nomes de todos Ubuntus
            Console.WriteLine($"Os Ubuntus presentes são: {nome1}, {nome2} e {nome3}");


            //T3 - Calcular Média dos IMC de todos Ubuntus
            decimal IMC1 = (decimal)peso1 / (altura1 * altura1);
            decimal IMC2 = (decimal)peso2 / (altura2 * altura2);
            decimal IMC3 = (decimal)peso3 / (altura3 * altura3);
            decimal media = (IMC1 + IMC2 + IMC3) / 3;
            Console.WriteLine($"A média de IMC dos Ubuntus resulta em: {media.ToString("f")}.");


            //T4 - Contar quantos Ubuntus sao Devs
            int EhDev = 0;

            if (EhDev1 == true)
            {
                EhDev = EhDev+1;
            }
            else
            {
                EhDev = EhDev;
            };
            if (EhDev2 == true)
            {
                EhDev = EhDev + 1;
            }
            else
            {
                EhDev = EhDev;
            };
            if (EhDev3 == true)
            {
                EhDev = EhDev + 1;
            }
            else
            {
                EhDev = EhDev;
            };
            Console.WriteLine($"Dentre os Ubuntos,{EhDev} são Devs!");


            //T5 - Exibir somente Ubuntu com nome Silva
            bool Silva1 = nome1.Contains("Silva");
            bool Silva2 = nome2.Contains("Silva");
            bool Silva3 = nome3.Contains("Silva");
            string Silva = "";

            if (Silva1 == true)
            {
                Silva = Silva + $" {nome1},";
            }
            else
            {
                Silva = Silva;
            };
            if (Silva2 == true)
            {
                Silva = Silva + $" {nome2},";
            }
            else
            {
                Silva = Silva;
            };
            if (Silva3 == true)
            {
                Silva = Silva + $" {nome3},";
            }
            else
            {
                Silva = Silva;
            };


            Console.WriteLine($"Dentre os Ubuntos:{Silva} possuem Silva no nome.");

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
