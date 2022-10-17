using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class AlunoHeranca : PessoaHeranca
    {
        /*
        Caso tenha a opção de não receber nada na sub-classe, é necessário criar um construtor vazio
        nela também
        */
        public AlunoHeranca()
        {
            
        }


        /*
        Construtor chamando o Nome de PessoaHeranca, 
        a base é como se estivesse chamando o construtor da
        super classe
        */
        public AlunoHeranca(string nome) : base (nome)
        {

        }
        public double nota { get; set; }

        //Sobrescrevendo um método
        public sealed override void Apresentar()
        {
            Console.WriteLine($"O nome do aluno é {Nome} e a idade é {Idade}, e sou um aluno nota {nota}");
        }
    }
}