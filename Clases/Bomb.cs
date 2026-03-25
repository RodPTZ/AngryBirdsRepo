using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class Bomb : Pajaro
    {
        public int Topes { get; set; } = 9000;
        public override int CalcularFuerza()
        {
            int fuerza = Ira * 2;
            return fuerza > topes ? topes : fuerza;
        }
    }
}