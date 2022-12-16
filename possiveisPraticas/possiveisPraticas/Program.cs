using System;

namespace possiveisPraticas
{
    /*Hey dev
     se você veio aqui para visualizar o código, seja bem-vindo. 
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            //update [+]
            Venda v1 = new Venda(2, "Banana", 20.50M);

            string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

            Console.WriteLine(serializado);













            ////A classe file é feita pra ler arquivos em outros lugares 
            //string[] linhas = File.ReadAllLines("ATeste/TextFile1.txt");

            //foreach (string linha in linhas)
            //{
            //    Console.WriteLine(linha);

            //}
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            ////Data e hora
            //DateTime data = DateTime.Now;

            ////Exemplo 1
            ////Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

            ////Exemplo 2
            //Console.WriteLine(data.ToShortDateString());
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
             
            
            
            
            
            /* 
            //alterando o valor da moeda, colocando ela em Dolar

            //Maneira 1
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            decimal ValorMonetario = 82.23M;


            
            Console.WriteLine($"{ValorMonetario:c}");

            //Maneira 2
            //Console.WriteLine(ValorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));


            double Porcentagem = .3421;
            //Representação em porcentagem
            Console.WriteLine(Porcentagem.ToString("P"));

            int numero = 123456;
            //Representa traços entre os numeros 
            Console.WriteLine(numero.ToString("##-##-##"));
            */ 
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            //Instanciamos duas classes com o nome pessoa 1 e pessoa 2  
            H pessoa1 = new H();

            pessoa1.Nome = "Nicolas";
            pessoa1.Sobrenome = "Carloto";


            H pessoa2 = new H();

            pessoa2.Nome = "Eduardo";
            pessoa2.Sobrenome = "Madeira";


            Curso ADS = new Curso();

            ADS.Nome = "Ads";
            ADS.Alunos = new List<H>();



            ADS.Adicionar(pessoa1);
            ADS.Adicionar(pessoa2);
            ADS.ListarAlunos();
            
            */ 
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            ////Instanciei a classe H
            //H p1 = new H();


            //p1.Apresentar();





























            /* 
            int nrEntrada = int.Parse(Console.ReadLine());
            int produtoDigitos = 1, somaDigitos = 0;
            int resultado;
            while (nrEntrada > 0)
            {
                int digito = nrEntrada % 10;
                produtoDigitos *= digito;
                somaDigitos += digito;
                nrEntrada /= 10;
            }
            resultado = produtoDigitos - somaDigitos;
            Console.WriteLine(resultado);
            */ 









            /* 
            //Trabalhando com listas
            //List é uma classe
            List<string> teste = new List<string>();

            teste.Add("São Paulo");
            teste.Add("Rio de Janeiro");
            teste.Add("Minas Gerais");

            Console.WriteLine("Percorrendo a lista com FOR");

            for (int i = 0; i < teste.Count; i++)
            {
                Console.WriteLine($"Posição Nº {i} - {teste[i]} "); 
            }

            Console.WriteLine("Percorrendo a lista com FOREACH");
            int contadorForeach = 0;
            foreach(String valor in teste)
            {
                Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
                contadorForeach++;
            }
            */




































            /* 
            //Um vetor de 3 posições
            int[] Matriz = new int[3];




            Matriz[0] = 5;
            Matriz[1] = 2;
            Matriz[2] = 7;

            //Array rezise eu aumento o tamanho do array
            Array.Resize(ref Matriz, Matriz.Length * 2);


            Console.WriteLine("percorrendo o array com o FOR");
            for (int i = 0; i < Matriz.Length; i++)//Lenght representa o tamanho da da array 
            {
                Console.WriteLine($"Posição Nº {i} - {Matriz[i]} ");
            }

            
            Console.WriteLine("Percorrendo o array com FOREACH");
            int contadorForeach = 0;
            foreach (int valor in Matriz)
            {
                Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
                contadorForeach++;
            }
            
            //A representação é a mesma
            */

























































            /*
            //instanciei a classe H chamada de <<new>>
            H info = new H();

            //instanciando a calculadora 
            Calculadora calc = new Calculadora();

            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy HH:mm") + " | Desenvolvido por SenhorN"); //data e hora em tempo real para documentar o algoritmo 
            //pulo de uma linha 
            Console.WriteLine("");
            
            Console.WriteLine("Pressione barra para continuar...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy HH:mm | ") + " Olá, Bem vindo ao possiveis práticas!");
            Console.WriteLine("|");
            Console.WriteLine("|");

            Console.WriteLine("~: O desenvolvedor senhorN fez esse algoritmo para praticar suas experiências.");
            Console.WriteLine(""); //pulo de uma linha 

            Console.WriteLine("~: Pressione barra para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Por favor, nos diga mais sobre você:");
            Console.WriteLine(""); //pulo de uma linha

            

            Console.WriteLine($"~: Qual o seu nome...");
            
            #region Algoritmo lê nome do usuario
            string name = Console.ReadLine();
            info.Nome = name;//a variavel da classe nome recebendo valor do usuario 
            #endregion 
            Console.WriteLine($"~: O seu nome é: {info.Nome}" + ", certo?");
            
            string option = Console.ReadLine(); //se a pessoa responder sim 
            //if (option == "sim"||option =="s" || option == "ss") ///dentro do IF tem o pipe, caracter composto por ||que significa OU. Podendo adicionar inumeras condições
            {
                
                Console.WriteLine("~: ok, prosseguindo o proximo passo");
                Console.WriteLine("");//pulo de uma linha 

                Console.WriteLine("~: Infome sua idade: ");
                
                #region algoritmo lendo a idade do usuario
                int age = Convert.ToInt32(Console.ReadLine());
                info.Idade = age;//idade recebe valor em inteiro da variavel age
                #endregion 
                
                Console.WriteLine($"~: Certo, sua idade é {info.Idade}");
                Console.WriteLine("");//pulo de uma linha

                Console.WriteLine("~:Informe aonde você mora: ");
                
                #region Algoritmo lendo aonde o usuario mora
                string city = Console.ReadLine();
                info.Cidade = city;
                #endregion 
                Console.WriteLine($"~: Sério, você mora em {info.Cidade} ?");

                Console.WriteLine("~: Belezaaa, vamos prosseguir.");//saida do IF
                Console.WriteLine("");//pulo de uma linha 

                Console.WriteLine("Pressione barra para continuar...");
                Console.ReadKey();
                Console.Clear();

            }
            #region situação de erro
            else
            {
                Console.WriteLine("Erro 500: Por favor consulte um dev para solucionar o problema!");
                Console.ReadKey();//O algoritmo acaba aqui 
                //se <<não>> ele percorre
            }
            #endregion 

            Console.WriteLine("");
            
            //Expondo os informações do usuário e percorrendo o algoritmo 
            Console.WriteLine($"~: {info.Nome}, você tem {info.Idade} e mora em {info.Cidade}, ok. ");
            Console.Clear();//Limpatela 

            Console.WriteLine($"~: {info.Nome}, escolha uma letra vogal abaixo");
            Console.WriteLine("~: a, e, i, o, u");

            Console.WriteLine("~:Qual:");
            string letra = Console.ReadLine();
            
            #region Usando o switch para testes
            //usando o switch pra utilizar o exemplo de vogal
            switch (letra){
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("~: Isto é uma vogal, você é inteligente. Parabéns! 200QI+");
                    break;
                default:
                    Console.WriteLine("~: não é uma vogal, seu burro!");
                    break;
            }
            #endregion

            #region Operadores aritmeticos


            ///calc.Somar(10, 60);//mais
            ///calc.Subtrair(20, 50);//menos
            ///calc.Multiplicacao(20, 12);//vezes
            ///calc.Divisao(2, 5);//divisão

            ///calc.Potencia(20, 3);//existe a possibilidade de usar potencias no csharp
          
            ///calc.Seno(10);
            ///calc.Coseno(3);
            ///calc.Tangente(6);
            calc.RaizQuadrada(6);
            #endregion 


            Console.WriteLine("~: Bom, esse algoritmo foi desenvolvido pelo senhorN no intuito dele se descontrair :)");
            Console.WriteLine("");
            Console.WriteLine("~: Obrigador por jogar!");
            Console.ReadKey();//Fim do algoritmo.
            */
            
            //development senhorN. 
        }
        
    }
}
