using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex003
{
    public class MegaSena
    {
        public MegaSena(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;
        }
        public string NomeUsuario { get; set; }
        Usuario usuario = new Usuario();

        public string SolicitarNome()
        {
            string nome;

            Console.Write("Informe o nome do usuario: ");
            nome = Console.ReadLine();
            return nome;
        }

        public int[] ArmazenarNumerosDigitados(int opcaoEscolhida)
        {
            Usuario interacoesUsuario = new Usuario();
            MegaSenaNivelUm megaSenaNivelUm;
            MegaSenaNivelDois megaSenaNivelDois;
            int[] numerosInformados = new int[6];

            switch (opcaoEscolhida)
            {
                case 1:
                    megaSenaNivelUm = new MegaSenaNivelUm(NomeUsuario);
                    for (int i = 0; i < 6; i++)
                    {
                        numerosInformados[i] = megaSenaNivelUm.RetornarNumeroDigitado();
                    }
                    break;

                case 2:
                    megaSenaNivelDois = new MegaSenaNivelDois(NomeUsuario);
                    for (int i = 0; i < 6; i++)
                    {
                        numerosInformados[i] = megaSenaNivelDois.RetornarNumeroDigitado();
                    }
                    break;
            }
            return numerosInformados;
        }
        public virtual int RetornarNumeroDigitado()
        {
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            return numeroEscolhido;
        }

        public int[] SortearNumeros(int[] numerosInformados)
        {
            Random random = new Random();
            int[] numerosSorteados;

            numerosSorteados = numerosInformados.OrderBy(x => random.Next()).ToArray();

            return numerosSorteados;
        }

        public int VerificarNumerosCertos(int[] numerosInformados, int[] numerosSorteados)
        {
            int contadorAcertos = 0;

            for (int i = 0; i < 6; i++)
            {
                if (numerosInformados[i] == numerosSorteados[i])
                    contadorAcertos++;
            }
            return contadorAcertos;
        }
    }
}
