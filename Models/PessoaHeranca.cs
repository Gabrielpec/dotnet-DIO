using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class PessoaHeranca
    {
        //Construtor vazio para caso não receba nenhum valor
        public PessoaHeranca()
        {
            
        }

        //Construtor caso receba um nome
        public PessoaHeranca(string nome){
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        //O virtual permite que o método seja sobrescrito!
        public virtual void Apresentar(){
            Console.WriteLine($"O nome é {Nome} e a idade {Idade}");
        }
    }
}