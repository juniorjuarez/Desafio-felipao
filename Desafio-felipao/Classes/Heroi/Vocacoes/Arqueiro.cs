using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Heroi.Vocacoes
{
    internal class Arqueiro : Vocacao
    {
        public Arqueiro() {

            this.Forca = 15;
            this.Magia = 20;
            this.Agilidade = 65;
            definirVocacao("Arqueiro");
        }
    }
}
