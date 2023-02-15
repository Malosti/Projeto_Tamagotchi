using System;
using System.Collections.Generic;
using System.Threading;

namespace Tamagotchi.Controller
{
    class TamagotchiController
    {
        private int PokemonEscolhido { get; set; }
        private string NomeUsuario { get; set; }
        private List<Pokemon> pokemons { get; set; }

        public TamagotchiController(string _nomeUsuario, int _pokemonEscolhido, List<Pokemon> _pokemons)
        {
            PokemonEscolhido = _pokemonEscolhido;
            NomeUsuario = _nomeUsuario;
            pokemons = _pokemons;
        }
        public Pokemon AdotarMascote()
        {
            var escolhaUsuario = new PokemonService();
            var pokemon = escolhaUsuario.EscolhaPokemon(PokemonEscolhido);
            AdocaoPokemon(pokemon);
            return pokemon;
        }

        private void AdocaoPokemon(Pokemon pokemon)
        {
            var telaJogo = new View();
            telaJogo.MenuAdocaoPokemon(pokemon, NomeUsuario);
            var escolhaFuncaoPokemon = int.Parse(Console.ReadLine());

            switch (escolhaFuncaoPokemon)
            {

                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine($"Nome Pokemon: {pokemon.name}");
                        Console.WriteLine($"Altura: {pokemon.height} m");
                        Console.WriteLine($"Peso: {pokemon.weight} Kg \n");
                        Console.WriteLine("Habilidades:");

                        foreach (var item in pokemon.abilities)
                        {
                            Console.WriteLine(item.ability.name);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        AddMascoteLista(pokemon);
                        Console.WriteLine($"{NomeUsuario} mascote adotado com sucesso, o ovo está chocando");
                        Console.ReadKey();
                        break;
                    }

                case 3: Console.Clear(); break;

                default:
                    {
                        Console.WriteLine("Por favor, digite uma opção válida!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        telaJogo.MenuOpcaoUsuario(NomeUsuario);
                        break;
                    }
            }
        }

        private void AddMascoteLista(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

    }
}
