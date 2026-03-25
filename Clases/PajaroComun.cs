using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class PajaroComun : Pajaro
    {
        public override int CalcularFuerza()
        {
            return Ira * 2;
        }
    }
}