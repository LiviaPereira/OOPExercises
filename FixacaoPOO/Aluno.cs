using System;
using System.Collections.Generic;
using System.Text;

namespace FixacaoPOO
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double DiferencaNotaFinal()
        {
            return 60 - NotaFinal();
        }
    }
}
