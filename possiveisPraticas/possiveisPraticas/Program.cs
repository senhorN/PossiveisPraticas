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
            //instanciei a classe H chamada de <<new>>
            H info = new H();

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
            if (option == "sim"||option =="s" || option == "ss") ///dentro do IF tem o pipe, caracter composto por ||que significa OU. Podendo adicionar inumeras condições
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
            Console.WriteLine("Bom, esse algoritmo foi desenvolvido pelo senhorN no intuito dele se descontrair :)");
            Console.WriteLine("");
            Console.WriteLine("Obrigador por jogar!");
            Console.ReadKey();//Fim do algoritmo.
            
            
            /*---------------------------------------------------------------------------------------------------- */ 
            
            
            //operador 'e' representado por &&
            bool presencaMinina;
            double media = 7.5;
            
            if(presencaMinima && media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }    
            else 
            {
                Console.WriteLine("Reprovado!");
            }
            
            
            //Operador NOT (negação) representado por !
            bool choveu = true;
            bool estaTarde = false;
            
            if(!choveu && !estaTarde)
            {
                Console.WriteLine("vou pedalar");
            }
            else 
            {
                Console.WriteLine("vou pedalar outro dia");
            }
            //development senhorN. 
        }
        
    }
}
