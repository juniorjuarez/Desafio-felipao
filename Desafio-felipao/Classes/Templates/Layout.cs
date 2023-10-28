using Desafio_felipao.Classes.Heroi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Templates
{
    internal class Layout
    {

        public static List<Personagem> personagens = new List<Personagem>();
        private static int opcao;
        public static void TelaPrincipal()
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Digite a opção desejada :                                ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                1 - Criar Personagem:                                    ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                2 - Seleciona Personagem:                                ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                3 - Sair:                                                ");
            Console.WriteLine("                                ===========================                              ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarPersonagem();
                    break;
                case 2:
                    SelecionaPersonagem();
                    break;
                case 3:
                    Console.WriteLine("                                Sistema sendo encerrado!");
                    Console.WriteLine("                                Aperte [ENTER} para Fechar:                           ");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
                    Console.ReadKey();
                    TelaPrincipal();
                    break;
            }
        }

        public static void CriarPersonagem()
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Criando um personagem :                                  ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Nome do Personagem:                                      ");
            string nome = Console.ReadLine();
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Vocação do Personagem:                                   ");
            Console.WriteLine("                                1- Mago | 2 - Guerreiro | 3 - Arqueiro | 4 - Curandeiro  ");
            opcao = int.Parse(Console.ReadLine());

            string vocacao = opcao switch
            {
                1 => "Mago",
                2 => "Guerreiro",
                3 => "Arqueiro",
                4 => "Curandeiro",
                _ => "Vocação Inválida",
            };

            if (vocacao == "Vocação Inválida")
            {
                Console.WriteLine("                                Opção Inválida, tente novamente.");
                Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
                Console.ReadKey();
                CriarPersonagem();
                return;
            }

            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                EXP:                                                     ");
            int xp = int.Parse(Console.ReadLine());
            Console.WriteLine("                                ===========================                              ");

            Personagem personagem = new Personagem();
            personagem.setNome(nome);
            personagem.setExperiencia(1500);
            personagem.setVocacao(vocacao);
            personagem.imprimeDados();
            personagens.Add(personagem);

            Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
            Console.ReadKey();
            TelaPrincipal();



        }

        public static void SelecionaPersonagem()
        {


            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                Buscando personagens                                     ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                Nome do Personagem:                                      ");
            string nome = Console.ReadLine();

            var heroi = personagens.FirstOrDefault(p => p.getNome() == nome);

            if (heroi == null)
            {
                Console.WriteLine($"                               Personagem {heroi} não existe                        ");
                Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
                Console.ReadKey();
                TelaPrincipal();

            }
            else
            {
                
                Console.WriteLine("                                Personagem encontrado:");
                Console.WriteLine("                                ===========================                          ");
                Console.WriteLine($"                               Nome: {heroi.getNome()}                              ");
                Console.WriteLine("                                ===========================                          ");
                Console.WriteLine($"                               Experiência: {heroi.getExperiencia()}                ");
                Console.WriteLine("                                ===========================                          ");
                Console.WriteLine($"                               Vocação: {heroi.getVocacao()}                        ");
                Console.WriteLine("                                ===========================                          ");
                switch (heroi.getExperiencia())
                {
                    case var xp when xp < 1000:
                        Console.WriteLine("                                  Nível: Ferro                               ");
                        break;
                    case var xp when xp >= 1001 && xp <= 2000:
                        Console.WriteLine("                                  Nível: Bronze                              ");
                        break;
                    case var xp when xp >= 2001 && xp <= 5000:
                        Console.WriteLine("                                  Nível: Prata                               ");
                        break;
                    case var xp when xp >= 6001 && xp <= 7000:
                        Console.WriteLine("                                  Nível: Ouro                                ");
                        break;
                    case var xp when xp >= 7001 && xp <= 8000:
                        Console.WriteLine("                                  Nível: Platina                             ");
                        break;
                    case var xp when xp >= 8001 && xp <= 9000:
                        Console.WriteLine("                                  Nível: Ascendente                          ");
                        break;
                    case var xp when xp >= 9001 && xp <= 10000:
                        Console.WriteLine("                                  Nível: Imortal                             ");
                        break;
                    case var xp when xp >= 10001:
                        Console.WriteLine("                                  Nível: Radiante                             ");
                        break;
                    default:
                        Console.WriteLine("                                  XP inválido                                 ");
                        break;
                }



                Console.WriteLine("                                Aperte [ENTER} para voltar:                           ");
                Console.ReadKey();
                TelaPrincipal();


            }
        }

    }
}
