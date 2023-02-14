using System.Collections.Generic;
using System;

namespace Tamagotchi
{
    public class Pokemon
    {
        public string name { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public List<Abilities> abilities { get; set; }


        public Pokemon AdotarMacote(int escolhaPokemonUsuario)
        {
            var escolhaUsuario = new PokemonService();
            var pokemon = escolhaUsuario.EscolhaPokemon(escolhaPokemonUsuario);
            return pokemon;
        }

        public void ListaMascote()
        {

        }
    }
}