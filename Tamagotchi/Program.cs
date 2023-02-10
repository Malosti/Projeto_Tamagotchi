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

            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest($"{option}", Method.Get);
            var response = client.Execute(request);
            var infoPokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);

            Console.WriteLine($"Nome do Pokemon: {infoPokemon.name.ToUpper()}");
            Console.WriteLine($"Altura: {infoPokemon.height} m");
            Console.WriteLine($"Peso: {infoPokemon.weight} Kg");
                       
        }
    }
}