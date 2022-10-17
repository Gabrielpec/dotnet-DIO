using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Corrente : ClasseAbstrata
    {
        public override void creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}