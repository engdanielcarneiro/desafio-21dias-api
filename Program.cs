using System;
using System.Collections.Generic;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       Daniel é um agricultor e precisa de um programa que ao digitar o numero inicial 1 e final 10, o programa mostra
       repetidamente todos os números na tela 
       */

            // Console.WriteLine("Digite o número inicial");
            // var numeroInicial = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Digite o número final");
            // int numeroFinal = Convert.ToInt32(Console.ReadLine());

            // int indice = numeroInicial;
            // while(indice <= numeroFinal)
            // {
            //   Console.WriteLine(indice);
            //   indice++;
            // }

            // for(int i = numeroInicial; i <= numeroFinal; i++)
            // {
            //   Console.WriteLine(i);
            // }

            // int[] itens = new int[]{1,2,3,4,5,6,7,8,9,10,11};
            // foreach(int item in itens)
            // {
            //   Console.WriteLine(item);
            // }

            // while(true){
            //     Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
            //     int sair = Convert.ToInt32(Console.ReadLine());
            //     if (sair == 1) break;
            //     else if(sair == 2) continue;

            //     Console.WriteLine("Opaaa estou por aqui!");
            // }

            List<Aluno> alunos = new List<Aluno>();
            while (true)
            {
                var opcao = 0;

                Console.WriteLine("Digite\n1 - Sair\n2 - Inserir alunos\n 3 - Checar situação dos alunos");
                opcao = Convert.ToInt32(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine("Finalizando programa.");
                    break;
                }

                switch (opcao)
                {
                    case 2:
                        var novoAluno = new Aluno();

                        Console.WriteLine("Digite o nome do aluno: ");
                        novoAluno.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a nota 1 do aluno: ");
                        novoAluno.Notas.Add(Double.Parse(Console.ReadLine()));

                        Console.WriteLine("Digite a nota 2 do aluno: ");
                        novoAluno.Notas.Add(Double.Parse(Console.ReadLine()));

                        Console.WriteLine("Digite a nota 3 do aluno: ");
                        novoAluno.Notas.Add(Double.Parse(Console.ReadLine()));

                        alunos.Add(novoAluno);

                        Console.WriteLine("Dados inseridos");

                        break;
                    case 3:
                        foreach (var aluno in alunos)
                        {
                            Console.WriteLine($"Aluno: {aluno.Nome}: {aluno.Situacao()}");

                        }
                        Console.WriteLine("------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }

        public static void aula02VariaveisJogoSoma()
        {
            //camelCase
            //PascalCase
            //unders_core

            Console.WriteLine("Digite o primeiro número");
            var numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            var soma = numeroUm * numeroDois;

            // Console.WriteLine($"Qual é o resultado da soma dos números {numeroUm} + {numeroDois} ?");
            Console.WriteLine($"Digite o numero premiado?");
            int resultado = Convert.ToInt32(Console.ReadLine());

            if (soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
            {
                Console.WriteLine($"Parabéns você acertou o resulado: {soma}");
            }
            else if (resultado == 20)
            {
                Console.WriteLine($"Você acertou a opção extraordinária, incrivel");
            }
            else
            {
                Console.WriteLine($"O resultado é {soma}, você errou, tente novamente na próxima");
            }
        }
    }
}