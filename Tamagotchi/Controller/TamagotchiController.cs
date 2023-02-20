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
            View.MenuAdocaoPokemon(pokemon, NomeUsuario);
            var escolhaFuncaoPokemon = int.Parse(Console.ReadLine());

            switch (escolhaFuncaoPokemon)
            {

                case 1:
                    {
                        View.EstatisticaMascote(pokemon);
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
                        View.MenuOpcaoUsuario(NomeUsuario);
                        break;
                    }
            }
        }

        private void AddMascoteLista(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public void InteracoesPokemon(string _nomeUsuario, string opcaoUsuario, Pokemon pokemon)
        {

            Console.WriteLine($"{_nomeUsuario} qual o que deseja fazer? ");
            Console.WriteLine($" 1 - Alimentar o ");
            Console.WriteLine($" 2 - Brincar com o ");
            Console.WriteLine($" 3 - Colocar o para dormir");
            Console.WriteLine($" 4 - Voltar");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: pokemon.AlimentarMascote(); break;

                case 2: pokemon.BrincarMascote(); break;

                case 3: pokemon.DescansarMascote(); break;

                case 4: View.MenuOpcaoUsuario(_nomeUsuario); break;

                default: InteracoesPokemon(_nomeUsuario, opcaoUsuario, pokemon); break;
            }

        }

    }
}
