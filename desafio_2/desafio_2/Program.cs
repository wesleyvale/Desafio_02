using System;

namespace desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ubuntu;

            string nome1 = "ubuntu1 Silva";
            int idade1 = 33;
            double peso1 = 88.50;
            double altura1 = 1.65;
            //bool EhDev1 = true;

            string nome2 = "ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            double altura2 = 2.10;
            //bool EhDev2 = true;

            string nome3 = "ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            double altura3 = 1.40;
            //bool EhDev3 = false;

            Console.WriteLine("UBUNTU 002 - STARTS... \n");
            Console.WriteLine("Tudo o que você sempre quis saber sobre alguns de nossos ubuntus\n");
            Console.WriteLine("1- A soma da idade deles");
            Console.WriteLine("2- Quem são esses Ubuntus?");
            Console.WriteLine("3- O IMC de cada um deles");
            Console.WriteLine("4- São todos devs?");
            Console.WriteLine("5- Apenas os Silva\n");

            {
                Console.Write("Digite a opção que deseja\n");
                ubuntu = (Console.ReadLine());
                while (ubuntu != "0")
                {
                    switch (ubuntu)
                    {
                        case "1":
                            Console.WriteLine("\nTodos juntos tem " + (idade1 + idade2 + idade3) + " anos de idade.\n");
                            break;
                        case "2":
                            Console.WriteLine("\nNossos ubuntus são: \n" + nome1 + "\n" + nome2 + "\n" + nome3 + "\n");
                            break;
                        case "3":
                            Console.WriteLine("\nIMC é do Ubuntu1 Silva: " + ((peso1 / (altura1 * altura1)).ToString("0.00")));
                            Console.WriteLine("IMC é do Ubuntu2 Santos: " + ((peso2 / (altura2 * altura2)).ToString("0.00")));
                            Console.WriteLine("IMC é do Ubuntu3 Silva: " + ((peso3 / (altura3 * altura3)).ToString("0.00\n")));
                            break;
                        case "4":
                            try
                            {
                                Console.Write("\n");
                                dev d = new dev();
                                d.Contagem();
                            }
                            catch
                            {
                                return;
                            }
                            //if (EhDev1 == true && EhDev2 ==true)
                            //{
                            //    Console.WriteLine("\nUbuntu1 Silva e o Ubuntu2 Santos são devs.");
                            //}

                            //if (EhDev3 == true)
                            //{
                            //    Console.WriteLine("\nUbuntu3 Silva é um dev");
                            //}
                            //{
                            //    Console.WriteLine("E o Ubuntu3 Silva não é um dev...ainda\n");
                            //}
                            break;
                        case "5":
                            Console.WriteLine("\nUbuntus que tem o sobrenome Silva: \n" + "Ubuntu1 Silva\n" + "Ubuntu3 Silva\n");
                            break;

                        default:
                            Console.WriteLine("opção inválida!");
                            break;

                    }
                    Console.WriteLine("\nDeseja saber mais?");
                    Console.WriteLine("Digite 0 para sair ou uma outra opção para continuar");
                    ubuntu = (Console.ReadLine());
                }
            }
        }
    }
}
