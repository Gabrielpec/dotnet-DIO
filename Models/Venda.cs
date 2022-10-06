using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        // public Venda(int id, string produto, decimal preco, DateTime datavenda)
        // {
        //     Id = id;
        //     Produto = produto;
        //     Preco = preco;
        //     DataVenda = datavenda;
        // }
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        
        //Interrogação permite que a propriedade seja nula
        public decimal? Desconto { get; set; }
    }
}