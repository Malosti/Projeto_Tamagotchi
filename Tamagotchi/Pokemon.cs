
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pokemon
    {
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public List<Ability> Abilities { get; set; } = new List<Ability>();

    }
}