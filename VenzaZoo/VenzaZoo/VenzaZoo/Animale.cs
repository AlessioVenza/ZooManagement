using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenzaZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Eta { get; set; }
        public int Peso { get; set; }
        public string StatoDiSalute { get; set; }
        public DateOnly DataArrivo { get; set; }
        public int AnimaliAlloZoo { get; set; }


        private double _pesoIniziale;
        private int _numeroControlliVeterinari;

        private double CalcolaVariazionePesoPercentuale()
        {
            return _pesoIniziale - Peso;
        }

        public double CalcolaCiboDiarioKg()
        {
            return 0;
        }
        public double CalcolaCostoGestioneMensile()
        {
            return 0;
        }
        public string EmettiVerso()
        {
            return "";
        }
        public double AggiornaPeso(double nuovoPeso)
        {
            return nuovoPeso = 0;
        }

    }
}
