using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class Chuck : Pajaro
    {
        public int Velocidad { get; set; }
        public override void Enojarse()
        {
            Velocidad += 2;
        }
        public override int calcularFuerza()
        {
            if (Velocidad <= 80)
            {
                return 150;
                return 150 + (Velocidad - 80) * 5;
            }
        }
    }
}