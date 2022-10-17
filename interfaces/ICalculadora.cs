using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.interfaces
{
    public interface ICalculadora
    {
        //Interfaces não exigem acessores, pois por padrão já se entende que são públicos
        //Tudo o que for inserido aqui deve ser implementado
        int Somar(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Subtrair(int num1, int num2);

        //Método padrão, com um corpo a implementação se torna opcional
        int Dividir(int num1, int num2){
            return num1 / num2;
        }
    }
}