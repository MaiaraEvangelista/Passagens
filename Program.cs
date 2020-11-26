using System;

namespace Passagem_Áerea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;

            //Dados
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] datas = new string[5];
            

            Console.Clear();

            Console.WriteLine("Passagens Áereas");
            Console.WriteLine("-------------------");

            //Entrada
            do
            {
                Console.WriteLine("Digite sua senha para o acesso: ");
                string senha = Console.ReadLine(); 
                senhaValida = EfetuarLogin(senha);

            } while (!senhaValida);
            
            Console.WriteLine("-------------------------------------------------");
            //Menu Principal
            do
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("[1]- Cadastrar Passagens");
                Console.WriteLine("[2]- Listar Passagens");
                Console.WriteLine("[0]- Sair");
                Console.WriteLine("---------------------------------------");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Cadastrar Passagens");
                        Console.WriteLine("------------------------------------");
                        do
                        {
                            if(contador <5){
                            Console.WriteLine($"Escreva o nome do {contador+ 1}º passageiro");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite  o destino: ");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a origem: ");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a data do vôo: ");
                            datas[contador] = Console.ReadLine();

                            contador++;

                            } else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                          
                            Console.WriteLine("---------------------------------------------");

                            Console.WriteLine("Você deseja cadastrar mais pessoas? S/N");
                            resposta = Console.ReadLine();

                          

                        } while (resposta == "s");
                        Console.Clear();
                        break;

                        case 2:
                            Console.WriteLine("Listar Passagens");   
                           for (var i = 0; i < contador; i++)
                           {
                              Console.WriteLine($"Passageiro: {nomes[i]}, Origem {origem[i]}, com Destino {destino[i]}data do vôo: {datas[i]} ");
                    
                           }

                        break;

                        case 0:
                            Console.WriteLine("Obrigada por escolher os nossos serviços. Faça uma boa viagem!");
                        break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                      
                }
                
            } while (escolha !=0);

           // EfetuarLogin(senha);
            //Parte das Funções
                bool EfetuarLogin(string senha){
                    if(senha == "123456"){
                       // Console.WriteLine("Senha Válida");
                        return true;
                    } else{
                       // Console.WriteLine("--------------------------");
                        Console.WriteLine("Senha Inválida");
                        return false;
                    }
                }
                
           
        }
    }
}
