using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelQuartos
{
    class Quarto
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
