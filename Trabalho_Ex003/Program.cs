using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoEscolhida, numerosCertos = 0;
            int[] numerosDigitados = new int[6];
            int[] numerosSorteados = new int[6];
            bool jogarNovamente = true;
            string nomeUsuario;

            while (jogarNovamente)
            {
                Usuario interacoesUsuario = new Usuario();
                nomeUsuario = interacoesUsuario.SolicitarNome();
                MegaSena megaSena = new MegaSena(nomeUsuario);
                interacoesUsuario.Nome = nomeUsuario;

                opcaoEscolhida = interacoesUsuario.ExibirNiveisDeJogo();
                numerosDigitados = megaSena.ArmazenarNumerosDigitados(opcaoEscolhida);
                numerosSorteados = megaSena.SortearNumeros(numerosDigitados);
                numerosCertos = megaSena.VerificarNumerosCertos(numerosDigitados, numerosSorteados);
                interacoesUsuario.InformarQuantidadeDeAcertos(numerosCertos);
                jogarNovamente = interacoesUsuario.JogarNovamente();
            }
        }
    }
}
