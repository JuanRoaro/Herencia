using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Reptil : Animal
    {   
        public string cambiarPiel()
        {
            return Nombre + " cambio de piel";
        }
        public override string desplazar()
        {
            return Nombre + "Esta caminando";
        }
    }
}
