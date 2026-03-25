using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class CerdoCasco : Obstaculo
    {
        public int ResistenciaCasco { get; set; }

        public override int Resistencia()
        {
            return ResistenciaCasco * 10;
        }
    }
}