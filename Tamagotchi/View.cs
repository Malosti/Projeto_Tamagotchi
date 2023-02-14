using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi;

namespace Tamagotchi
{
    public class View
    {
        public void BoasVindas()
        {
            Console.WriteLine("=========== TAMAGOTCHI ===========");
            Console.WriteLine("       Olá, seja bem vindo!!!     ");
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            var nomeUsuario = Console.ReadLine();
            Console.Clear();
            OpcoesUsuario(nomeUsuario);
        }

        public void OpcoesUsuario(string nomeUsuario)
        {
            Console.WriteLine($"{nomeUsuario}, o que deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine("1 - ADOTAR MASCOTE");
            Console.WriteLine("2 - VER SEUS MASCOTES ");
            Console.WriteLine("3 - SAIR DO JOGO");
            Console.WriteLine();
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("========= ADOTAR POKÉMON =========");
                        Console.WriteLine($"{nomeUsuario}, escolha uma espécie: ");
                        Console.WriteLine("1 - Bulbasaur");
                        Console.WriteLine("4 - Charmander");
                        Console.WriteLine("7 - Squirtle");
                        Console.WriteLine();

                        var escolhaPokemonUsuario = int.Parse(Console.ReadLine());
                        var pokemon = new Pokemon().AdotarMacote(escolhaPokemonUsuario);

                        Console.Clear();
                        Console.WriteLine($"{nomeUsuario}, você deseja:");
                        Console.WriteLine($"1 - Saber mais sobre o {pokemon.name}");
                        Console.WriteLine($"2 - Adotar o {pokemon.name}");
                        Console.WriteLine("3 - Voltar");
                        var escolhaFuncaoPokemon = int.Parse(Console.ReadLine());

                        switch (escolhaFuncaoPokemon)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"Nome Pokemon: {pokemon.name}");
                                    Console.WriteLine($"Altura: {pokemon.height} m");
                                    Console.WriteLine($"Peso: {pokemon.weight} Kg \n");
                                    Console.WriteLine("Habilidades:");

                                    foreach (var item in pokemon.abilities)
                                    {
                                        Console.WriteLine(item.ability.name);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine($"{nomeUsuario} mascote adotado com sucesso, o ovo está chocando");
                                    break;
                                }

                            case 3: OpcoesUsuario(nomeUsuario); break;

                            default:
                                {
                                    Console.WriteLine("Por favor, digite uma opção válida!");
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    break;
                                }
                        }

                        break;
                    }

                case 2: new Pokemon().ListaMascote(); break;

                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Tchau! Volte logo :)");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Por favor, digite uma opção válida!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        OpcoesUsuario(nomeUsuario);
                        break;
                    }
            }
        }
    }
}
