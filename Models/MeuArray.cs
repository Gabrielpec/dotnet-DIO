using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //Classes genéricas recebem o <nome> após o nome
    public class MeuArray<T>
    {
        //Array tipada
        private static int capacidade = 10;

        //Array não tipada
        private T[] array = new T[capacidade];

        private int contador = 0;

        public void AdicionarElementoArray(T elemento)
        {
            if(contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]{
            get{ return array[index]; }
            set{ array[index] = value; }
        }
    }
}