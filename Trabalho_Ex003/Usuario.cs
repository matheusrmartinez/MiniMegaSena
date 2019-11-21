using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex003
{
    public class Usuario : Pessoa
    {
        public int ExibirNiveisDeJogo()
        {
            int opcaoEscolhida = 0;

            Console.WriteLine("Jogo Mini Mega Sena Iniciado.");
            Console.WriteLine
                (
                    "================================== \n" +
                    $"{Nome}, digite 1 ou 2 de acordo o nível de jogo que gostaria de jogar: \n" +
                      $"Nível 1 - números de 1 a 30. \n" +
                      $"Nível 2 - números de 1 a 60. \n " +
                    "================================== \n"
                );
            opcaoEscolhida = int.Parse(Console.ReadLine());
            return opcaoEscolhida;
        }

        public string SolicitarNome()
        {
            string nome;

            Console.Write("Informe o nome do usuario: ");
            nome = Console.ReadLine();
            return nome;
        }


        public void InformarQuantidadeDeAcertos(int numerosCertos)
        {
            switch (numerosCertos)
            {
                case 4:
                    Console.WriteLine($"Parabéns {Nome}, acertou 4, mas ganhou pouco dinheiro");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine($"Parabéns {Nome}, acertou 5, quero um churrasco!");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine($"Parabéns {Nome}, acertou 6, você esta rico! Quero um carro!");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine($"Que pena {Nome}, você não pontuou o suficiente");
                    break;
            }
        }

        public bool JogarNovamente()
        {
            bool jogarNovamente = false;

            Console.WriteLine($"Deseja jogar novamente? (Sim ou Não)");
            jogarNovamente = Console.ReadLine().Contains("Sim") ? true : false;

            return jogarNovamente;
        }
    }
}
