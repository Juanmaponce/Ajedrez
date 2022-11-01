using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez
{
    public class Caballo:PiezaAjedrez
    {
        public override string Mover()
        {
            return base.Mover() + "Caballo...";
        }
    }
}
