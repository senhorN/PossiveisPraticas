using System;
using System.Collections.Generic;
using System.Text;

namespace possiveisPraticas
{
   class Venda
    {
        //Construtor Venda
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            id = Id;
            produto = Produto;
            preco = Preco;
            DataVenda = dataVenda;
        }
        //Propriedades
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
