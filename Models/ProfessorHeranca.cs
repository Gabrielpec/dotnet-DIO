using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //O sealed impede de ser instanciado
    public sealed class ProfessorHeranca : PessoaHeranca
    {
        //Professor não tem um construtor vazio, então obrigatoriamente exige um nome
        public ProfessorHeranca(string nome) : base (nome)
        {
            
        }
        public double salario { get; set; }

        //O sealed impede de ser sobrescrito
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Oi, sou o professor {Nome} e tenho {Idade} anos");
        }
    }
}