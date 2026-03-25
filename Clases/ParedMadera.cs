using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
public class ParedMadera : Obstaculo
{
    public int Ancho { get; set; }

    public override int Resistencia()
    {
        return Ancho * 25;
    }
}
}