using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Subzero : PersonagemBase
    {
        public override void Atacar()
        {
            Console.WriteLine("Ataque" + GetName());
        }

        public override void Escolhido()
        {
            Console.WriteLine(GetName());
        }
    }
}
