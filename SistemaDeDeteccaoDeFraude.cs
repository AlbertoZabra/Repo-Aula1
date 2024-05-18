using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SistemaDeDeteccaoDeFraude
    {
        public HashSet<string> operacoes;

        public SistemaDeDeteccaoDeFraude()
        {
            operacoes = new HashSet<string>();
        }

        public bool AdicionarTransacao(string operacaoId)
        {
            if (!operacoes.Add(operacaoId))
            {
                Console.WriteLine($"CUIDADO FRAUDE!!!! Operação duplicada detectada: {operacaoId}");
                return false;
            }
            Console.WriteLine($"Operação {operacaoId} adicionada com sucesso.");
            return true;
        }
    }
}