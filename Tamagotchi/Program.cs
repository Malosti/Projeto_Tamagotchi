using System;
using System.Threading;
using Tamagotchi.Controller;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {

            var telasJogo = new View();

            var nomeUsuario = telasJogo.MenuInicial();

            telasJogo.MenuOpcaoUsuario(nomeUsuario);
            var opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    {
                        telasJogo.MenuEscolherPokemon(nomeUsuario);
                        var pokemonEscolhido = int.Parse(Console.ReadLine());
                        new TamagotchiController(nomeUsuario, pokemonEscolhido).AdotarMascote();
                        break;
                    }

                case 2: break;

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
                        break;
                    }
            }
        }
    }
}