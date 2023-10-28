using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_felipao.Classes.Heroi.Vocacoes
{
    internal class Guerreiro : Vocacao
    {
        public Guerreiro()
        {

            this.Forca = 50;
            this.Magia = 10;
            this.Agilidade = 40;
            definirVocacao("Guerreiro");
        }
    }
}

