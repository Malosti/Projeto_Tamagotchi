using RestSharp;
using System.Text.Json;

namespace Tamagotchi
{
    class PokemonService
    {
        public int escolha { get; set; }

        public PokemonService()
        {
            
        }

        public Pokemon EscolhaPokemon(int escolha)
        {
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest($"{escolha}", Method.Get);
            var response = client.Execute(request);
            var infoPokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);
            return infoPokemon;
        }
    }
}
