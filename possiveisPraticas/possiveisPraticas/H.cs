using System;
using System.Collections.Generic;
using System.Text;

namespace possiveisPraticas
{
    class H
    {
        /// <summary>
        ///  propriedades nome, idade, cidade e observacoes
        /// </summary>
        public string Nome { get; set; } //Nome da pessoa 
        public string Sobrenome { get; set; }
                                                            //ToUpper > deixa os carcateres em maiusculo
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //propriedade de get; pega as duas variaveis Nome & Sobrenome.
        public int Idade { get; set; }//idade da pessoa 
        public string Cidade { get; set; }//cidade aonde a pessoa mora
        public string Observacoes { get; set; }//observacoes 


        public void Apresentar()
        {
            Nome = "Nicolas";
            Sobrenome = "Carloto";
            Idade = 20;
            Cidade = "Araçatuba";
            Console.WriteLine($" Seu nome é {NomeCompleto} idade deste rapaz é de {Idade} anos e ele mora em {Cidade}");
        }
    }
}
