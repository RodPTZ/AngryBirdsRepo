using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class CerdoEscudo : Obstaculo
    {
        public int ResistenciaEscudo { get; set; }

        public override int Resistencia()
        {
            return ResistenciaEscudo * 10;
        }
    }
}