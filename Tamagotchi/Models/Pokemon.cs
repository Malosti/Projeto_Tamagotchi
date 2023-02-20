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
        public int sleep { get; set; }
        public int humor { get; set; }

        public Pokemon()
        {
            var pontos = new Random();
            hungry = pontos.Next(1, 9);
            sleep = pontos.Next(1, 9);
            humor = pontos.Next(1, 9);
        }

        public bool VerificaHumor()
        {
            return (humor > 3);
        }
        public void BrincarMascote()
        {
            humor++;
            hungry--;
        }
        public bool VerificaDescanso()
        {
            return this.sleep < 5;
        }
        public void DescansarMascote()
        {
            sleep++;
        }
        public bool VerificaFome()
        {
            return (hungry < 3);
        }
        public void AlimentarMascote()
        {
            hungry++;
            sleep--;
        }
    }
}