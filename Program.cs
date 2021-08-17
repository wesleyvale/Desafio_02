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
            int idade4 = idade1 + idade2 + idade3;

            //T2 - Agrupar os nomes de todos Ubuntus
            string nome4 = $"seus nomes são {nome1}, {nome2} e {nome3}";
            //T3 - Calcular Média dos IMC de todos Ubuntus
            decimal sAltura = altura1+altura2+altura3;
            decimal qAltura = sAltura*sAltura;
            decimal dPeso1 = Convert.ToDecimal(peso1);
            decimal dPeso2 = Convert.ToDecimal(peso2);
            decimal dPeso3 = Convert.ToDecimal(peso3);
            decimal sPeso = dPeso1+dPeso2+dPeso3;
            decimal IMC = sPeso/qAltura;
            //T4 - Contar quantos Ubuntus sao Devs
            int EhDev4 = 0;
            if(EhDev1)
            {
                EhDev4 += 1;
            } else
            {
                EhDev4 += 0;
            }

            if (EhDev2)
            {
                EhDev4 += 1;
            }
            else
            {
                EhDev4 += 0;
            }

            if (EhDev3)
            {
                EhDev4 += 1;
            }
            else
            {
                EhDev4 += 0;
            }
            //T5 - Exibir somente Ubuntu com nome Silva
            string nomeSilva4 = "e ";
            bool nomeSilva1 = nome1.Contains("Silva");
            bool nomeSilva2 = nome2.Contains("Silva");
            bool nomeSilva3 = nome3.Contains("Silva");

            if (nomeSilva1)
            {
                nomeSilva4 = nome1 + " e ";
            }
            if (nomeSilva2)
            {
                nomeSilva4 += nome2 + " e ";
            }
            if (nomeSilva3)
            {
                nomeSilva4 += nome3;
            }

            //Imprime na tela
            Console.WriteLine($"Os Ubuntus aqui tem a idade total de {idade4}, {nome4}, o IMC médio deles é {IMC}, {EhDev4} são devs {nomeSilva4} chamam Silva");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
