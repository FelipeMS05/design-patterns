using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PersonagemBase : IPersonagem
    {
        public string GetName()
        {
            Type type = this.GetType();
            return type.Name;
        }
        public abstract void Atacar();
        public abstract void Escolhido();
    }
}
