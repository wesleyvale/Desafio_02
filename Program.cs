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

            int idades = idade1 + idade2 + idade3;

            Console.WriteLine($"Idades dos Ubuntus somadas : {idades} ");

            Console.WriteLine($"Nomes dos Ubuntus : {nome1}, {nome2}, {nome3}");

            double vIn = 88.50;
            decimal peso1novo = Convert.ToDecimal(vIn);

            int ImcUbuntu1 = (int)(peso1novo / (altura1 * altura1));

            double VIn2 = 84.50;
            decimal peso2novo = Convert.ToDecimal(VIn2);

            int ImcUbuntu2 = (int)(peso2novo / (altura2 * altura2));

            double VIn3 = 66.50;
            decimal peso3novo = Convert.ToDecimal(VIn3);

            int ImcUbuntu3 = (int)(peso3novo / (altura3 * altura3));

            int MediaImc = (ImcUbuntu1 + ImcUbuntu2 + ImcUbuntu3) / 3;

            Console.WriteLine($"Media dos Imc Ubuntus: {MediaImc}");

            if (EhDev1 == true)
            {
                Console.WriteLine("Um Dev foi confirmado");
            }


            if (EhDev2 == true)
            {
                Console.WriteLine("Um Dev foi confirmado");
            }



            if (EhDev3 == true)
            {
                Console.WriteLine("Um Dev foi confirmado");
            }



            Console.WriteLine("Total de Devs : 2");

            var UbuntusSilva = nome1.Contains("Silva");
            var UbuntusSilva2 = nome2.Contains("Silva");
            var UbuntusSilva3 = nome3.Contains("Silva");

            if (UbuntusSilva == true)
            {
                Console.WriteLine("Ubuntu de nome Silva encontrado : Ubuntu1 Silva");
            }

            if (UbuntusSilva2 == true)
            {
                Console.WriteLine("Ubuntu de nome Silva encontrado : ");
            }



            if (UbuntusSilva3 == true)
            {
                Console.WriteLine("Ubuntu de nome Silva encontrado : Ubuntu3 Silva");
            }

            
            string Silva = "";

            if (UbuntusSilva == true)
            {
                Silva = Silva + $" {nome1}";
            }

            if (UbuntusSilva2 == true)
            {
                Silva = Silva + nome2;
            }

            if (UbuntusSilva3 == true)
            {
                Silva = Silva + $" {nome3}";
            }

            Console.WriteLine(Silva);

            //T2-Somar a idade de todos Ubuntus      

            //T2 - Agrupar os nomes de todos Ubuntus

            //T3 - Calcular Média dos IMC de todos Ubuntus

            //T4 - Contar quantos Ubuntus sao Devs

            //T5 - Exibir somente Ubuntu com nome Silva



            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }
        

    }
}
