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
            int somaIdade = idade1 + idade2 + idade3;

            //T2 - Agrupar os nomes de todos Ubuntus
            string groupNames = nome1 + ", " + nome2 + " e " + nome3;

            //T3 - Calcular Média dos IMC de todos Ubuntus
            decimal pesoUbunto1 = Convert.ToDecimal(peso1);
            decimal pesoUbunto2 = Convert.ToDecimal(peso2);
            decimal pesoUbunto3 = Convert.ToDecimal(peso3);
            decimal imcUbunto1 = pesoUbunto1 / (altura1 * altura1);
            decimal imcUbunto2 = pesoUbunto2 / (altura2 * altura2);
            decimal imcUbunto3 = pesoUbunto3 / (altura3 * altura3);

            decimal media = (imcUbunto1 + imcUbunto2 + imcUbunto3) / 3;

            //T4 - Contar quantos Ubuntus sao Devs
            int countDev = 0;

            if (EhDev1 == true)
                countDev += 1;
            if (EhDev2 == true)
                countDev += 1;
            if (EhDev3 == true)
                countDev += 1;

            //T5 - Exibir somente Ubuntu com nome Silva
            string ubuntoSilva = null;
            string word = "Silva";

            if (nome1.Contains(word))
                ubuntoSilva += nome1 + " e ";
            if (nome2.Contains(word))
                ubuntoSilva += nome2 + " e ";
            if (nome3.Contains(word))
                ubuntoSilva += nome3;

            //Imprime na tela
            Console.WriteLine("Idade de todos os Ubuntos somadas: " + somaIdade + ";" + "\nNome de todos os Ubuntos: " + groupNames + ";" + "\nMédia do IMC de todos os Ubuntos: " + media + ";" + "\nQuantidade de Ubuntos que são Devs: " + countDev + ";" + "\nUbuntos que possuem o nome Silva: " + ubuntoSilva + ".");
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
