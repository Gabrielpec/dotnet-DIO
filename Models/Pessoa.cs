using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        //Construtor, ele deve levar o mesmo nome que a classe
        //Um construtor também não tem um retorno
        public Pessoa(string nome, string sobrenome){
            //Recebendo os valores do parâmetro
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //Desconstrutor
        public void Deconstruct(out string nome, out string sobrenome){
            nome = Nome;
            sobrenome = Sobrenome;
        }

        //É permitido 2 ou mais construtores
        //Esse construtor em questão não recebe nenhum valor, caso o usuário não digite nada
        public Pessoa(){

        }

        private string _nome;
        private int _idade;
        public string Nome 
        { 

            get{
                return _nome.ToUpper();
            }
            set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }

        }


        //Nome com body expression
        /*public string Nome 
        { 

            get => _nome.ToUpper();
            set => _nome = value; //Não permite associar um valor

        }
        */

        public string Sobrenome { get; set; }

        //Propriedade Somente de Leitura
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


        public int Idade {
            get => _idade;
            set{
                if(value < 12){
                    throw new ArgumentException("Acesso proibido para menores de 12 anos!");
                }

                _idade = value;
            }
        }

        public void Apresentar(){
            //Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}");
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");

        }
    }
}