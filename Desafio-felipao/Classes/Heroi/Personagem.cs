using Desafio_felipao.Classes.Heroi.Vocacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Heroi
{
    internal class Personagem
    {


        private string nomePersonagem { get; set; }

        private int Experiencia { get; set; }

        private Vocacao vocacao { get; set; }

        public void setNome(string nome)
        {
            this.nomePersonagem = nome;
        }
        public void setExperiencia(int xp)
        {
            this.Experiencia = xp;
        }

        public string getNome()
        {
            return this.nomePersonagem;
        }

        public int getExperiencia()
        {
            return this.Experiencia;
        }

        public string getVocacao()
        {

           return vocacao.imprimeVocacao();

        }

        public string setVocacao(string vocacao)
        {

            switch (vocacao)
            {
                case "Mago":
                    this.vocacao = new Mago();
                    break;

                case "Guerreiro":
                    this.vocacao = new Guerreiro();
                    break;

                case "Arqueiro":
                    this.vocacao = new Arqueiro();
                    break;

                case "Curandeiro":
                    this.vocacao = new Curandeiro();
                    break;

                default:
                    Console.WriteLine("Vocação Não existe");
                    break;
            }
            return vocacao;
        }

        public void imprimeDados()
        {

            Console.WriteLine($"                                Nome do Personagem:  {this.nomePersonagem}              ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine($"                                Classe:  {this.vocacao.imprimeVocacao()}                ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine($"                                XP:  {this.Experiencia}                                 ");
            Console.WriteLine("                                ===========================                              ");
            this.vocacao.imprimeAtributos();






        }

    }
}
