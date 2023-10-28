using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Heroi
{
    public abstract class Vocacao
    {

        private int Id { get; set; }
        private string Nome { get; set; }
        public int Forca { get; set; }
        public int Magia { get; set; }
        public int Agilidade { get; set; }

        public void definirVocacao(string vocacao)
        {

            this.Nome = vocacao;
        }

        public string imprimeVocacao() {

            return this.Nome;
        }


        public void imprimeAtributos() {
            Console.WriteLine("                                -------- Atributos --------                              ");
            Console.WriteLine("                                ===========================                              ");
            Console.WriteLine("                                ---------- Força ----------                              ");
            Console.WriteLine($"                                  {this.Forca}                                          ");
            Console.WriteLine("                                ---------- Magia ----------                              ");
            Console.WriteLine($"                                  {this.Magia}                                          ");
            Console.WriteLine("                                -------- Agilidade --------                              ");
            Console.WriteLine($"                                  {this.Agilidade}                                       ");
        }
       
    }
}
