using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public abstract class ClasseAbstrata
    {
        protected decimal saldo;

        //Um método abstrato não recebe uma estrutura, a classe herdeira será responsável por manipular ele
        public abstract void creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}