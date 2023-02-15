using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pokemon
    {
        public string name { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public List<Abilities> abilities { get; set; }
        public int hungry { get; set; }
        public int thirst{ get; set; }
        public int sleep { get; set; }
        public int humor { get; set; }

        public Pokemon()
        {
            var pontos = new Random();

            hungry = pontos.Next(1, 9);
            thirst = pontos.Next(1, 9);
            sleep = pontos.Next(1, 9);
            humor = pontos.Next(1, 9);
        }

        public void BrincarMascote()
        {
            humor++;
            hungry--;
        }
        public void DescansarMascote()
        {
            sleep++;
            thirst--;
        }
        public void AlimentarMascote()
        {
            hungry++;
            sleep--;
        }
        public void HidratarMascote()
        {
            thirst++;
            humor--;
        }

    }
}