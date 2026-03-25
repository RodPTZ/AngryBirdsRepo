using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class Matilda : Pajaro
    {
        public List<int> Huevos { get; set; } = new List<int>();
        public override void Enojarse()
        {
            base.Enojarse();
            Huevos.Add(2);
        }
        public override int calcularFuerza()
        {
            return (Ira * 2) + Huevos.Sum();
        }
    }
}