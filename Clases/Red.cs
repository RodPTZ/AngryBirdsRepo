using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
    public class Red : Pajaro
    {
        public int VecesEnojado { get; set; }
        public override void Enojarse()
        {
            base.Enojarse();
            vecesEnojado++;
        }
        public override int calcularFuerza()
        {
            return Ira * 10 * vecesEnojado;
        }  
    }
}