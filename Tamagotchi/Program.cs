using System;
using System.Collections.Generic;
using System.Threading;
using Tamagotchi.Controller;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPokemons = new List<Pokemon>();
            var jogar = 1;
            var nomeUsuario = View.MenuInicial();

            while (jogar == 1)
            {
                View.MenuOpcaoUsuario(nomeUsuario);
                var opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            View.MenuEscolherPokemon(nomeUsuario);
                            var pokemonEscolhido = int.Parse(Console.ReadLine());
                            if (pokemonEscolhido == 1 || pokemonEscolhido == 4 || pokemonEscolhido == 7)
                            {
                                new TamagotchiController(nomeUsuario, pokemonEscolhido, listaPokemons).AdotarMascote();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Escolha um pokémon válido...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            }

                        }

                    case 2:
                        {
                            View.ListaMascotes(nomeUsuario, listaPokemons);
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Tchau! Volte logo :)");
                            Thread.Sleep(1000);
                            jogar = 3;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Por favor, digite uma opção válida!");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}