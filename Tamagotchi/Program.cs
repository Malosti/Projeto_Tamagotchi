using RestSharp;
using System;
using System.Text.Json;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu Pokemon");
            Console.WriteLine();
            Console.WriteLine("1 - Bulbasaur");
            Console.WriteLine("4 - Charmander");
            Console.WriteLine("7 - Squirtle");
            Console.WriteLine();
            var option = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            var escolhaUsuario = new PokemonService();

            var pokemon = escolhaUsuario.EscolhaPokemon(option);

            Console.WriteLine($"Nome Pokemon: {pokemon.name}");
            Console.WriteLine($"Altura: {pokemon.height} m");
            Console.WriteLine($"Peso: {pokemon.weight} Kg \n");
            Console.WriteLine("Habilidades:");

            foreach (var item in pokemon.abilities)
            {
                Console.WriteLine(item.ability.name);
            }
                       
        }
    }
}