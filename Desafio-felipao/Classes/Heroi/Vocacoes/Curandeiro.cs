using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Heroi.Vocacoes
{
    internal class Curandeiro : Vocacao
    {
        public Curandeiro() {
            this.Forca = 10;
            this.Magia = 70;
            this.Agilidade = 20;
            definirVocacao("Curandeiro");
        } 
    }
}
