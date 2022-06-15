using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    internal class Alunos
    {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double PontosRestante()
        {
            if (Aprovado()){
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }
    }
}
