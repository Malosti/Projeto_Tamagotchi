using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pokemon
    {
        public string name { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public List<Abilities> abilities { get; set; }
    }
}