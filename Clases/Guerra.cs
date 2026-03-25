using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirdsRepo
{
     public static class Guerra
    {
        // Saber si un pájaro derriba un obstáculo
        public static bool PuedeDerribar(Pajaro pajaro, Obstaculo obstaculo)
        {
            return pajaro.Fuerza() > obstaculo.Resistencia();
        }

        // Ataque de la isla pájaro 
        public static void Atacar(IslaPajaro islaPajaro, IslaCerdito islaCerdito)
        {
            foreach (var pajaro in islaPajaro.Pajaros)
            {
                if (islaCerdito.EstaDestruida())
                    break;

                var obstaculo = islaCerdito.Obstaculos[0]; // el más cercano

                if (PuedeDerribar(pajaro, obstaculo))
                {
                    islaCerdito.Obstaculos.RemoveAt(0); // lo rompe
                }
                // si no, no pasa nada
            }
        }
    }
}