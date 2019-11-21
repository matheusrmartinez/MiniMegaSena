using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex003
{
    sealed public class MegaSenaNivelDois : MegaSena
    {
        public MegaSenaNivelDois(string nomeUsuario) : base(nomeUsuario)
        {
            NomeUsuario = nomeUsuario;
        }
        public override int RetornarNumeroDigitado()
        {
            int numeroEscolhido = 0;
            Console.WriteLine("==================================");
            Console.Write($"{NomeUsuario}, digite 6 números de 1 a 60: ");
            numeroEscolhido = base.RetornarNumeroDigitado();
            return numeroEscolhido;
        }
    }
}
