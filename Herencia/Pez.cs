using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //( : Animal) = heredda de la clase animal
    class Pez : Animal
    {
        override public string desplazar()
        {
            return Nombre + " Esta nadando bien rikholino en el chapopote";
        }
    }
}
