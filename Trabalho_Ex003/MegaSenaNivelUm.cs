using System;

namespace Trabalho_Ex003
{
    public class MegaSenaNivelUm : MegaSena
    {
        public MegaSenaNivelUm(string nomeUsuario) : base(nomeUsuario)
        {
            NomeUsuario = nomeUsuario;
        }
        public override int RetornarNumeroDigitado()
        {
            int numeroEscolhido = 0;
            Console.WriteLine("==================================");
            Console.Write($"{NomeUsuario}, informe um número de 1 a 30: ");
            numeroEscolhido = base.RetornarNumeroDigitado();
            return numeroEscolhido;
        }
    }
}
