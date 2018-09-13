using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Ave : Animal
    {   
        public string ponerHuevo()
        {
            return Nombre + "Puso un huevo";
        }
        public override string desplazar()
        {
            return Nombre + "Esta volando";
        }
    }
}
