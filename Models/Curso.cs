using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados(){
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public void ListarAlunos(){

            for (int contador = 0; contador < Alunos.Count; contador++){

                //string texto = "N: " + (contador + 1) + " - " + Alunos[contador].NomeCompleto;
                string texto = $"N. {contador + 1} - {Alunos[contador].NomeCompleto}";

                Console.WriteLine(texto);

            }

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}