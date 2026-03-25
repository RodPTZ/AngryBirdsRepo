using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class Terence : Pajaro
    {
        public int VecesEnojado { get; set; }
        public int Multiplicador { get; set; }
        public override void Enojarse()
        {
            base.Enojarse();
            VecesEnojado++;
        }
        public override int CalcularFuerza()
        {
            return Ira * VecesEnojado * Multiplicador;
        }
    }
}