using System;
using System.Threading;

namespace Tamagotchi.Controller
{
    class TamagotchiController
    {
        public int PokemonEscolhido { get; set; }
        public string NomeUsuario { get; set; }
        public TamagotchiController(string _nomeUsuario, int _pokemonEscolhido)
        {
            PokemonEscolhido = _pokemonEscolhido;
            NomeUsuario = _nomeUsuario;
        }
        public Pokemon AdotarMascote()
        {
            var escolhaUsuario = new PokemonService();
            var pokemon = escolhaUsuario.EscolhaPokemon(PokemonEscolhido);
            AdocaoPokemon(pokemon);
            return pokemon;
        }

        public void AdocaoPokemon(Pokemon pokemon)
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
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"{NomeUsuario} mascote adotado com sucesso, o ovo está chocando");
                        break;
                    }

                case 3: telaJogo.MenuOpcaoUsuario(NomeUsuario); break;

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


    }
}
