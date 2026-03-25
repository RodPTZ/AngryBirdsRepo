using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
public class IslaCerdito
{
    public List<Obstaculo> Obstaculos { get; set; } = new List<Obstaculo>();

    public bool EstaDestruida()
    {
        return Obstaculos.Count == 0;
    }
}
}