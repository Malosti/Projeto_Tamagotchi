using RestSharp;
using System;

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
            var option = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest($"{option}", Method.Get);
            var response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
    }
}