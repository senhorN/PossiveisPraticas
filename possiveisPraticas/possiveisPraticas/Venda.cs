using System;
using System.Collections.Generic;
using System.Text;

namespace possiveisPraticas
{
    class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            id = id;
            produto = produto;
            preco = preco;
        }
        public int id { get; set; }
        public string produto { get; set; }
        public decimal preco { get; set; }
    }
}
