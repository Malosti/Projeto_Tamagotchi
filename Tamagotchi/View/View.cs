using System;

namespace Tamagotchi
{
    public class View
    {
        public string MenuInicial()
        {
            Console.WriteLine("=========== TAMAGOTCHI ===========");
            Console.WriteLine("       Olá, seja bem vindo!!!     ");
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            var nomeUsuario = Console.ReadLine();
            Console.Clear();
            return nomeUsuario;
        }

        public void MenuOpcaoUsuario(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine($"{nomeUsuario}, o que deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine("1 - ADOTAR MASCOTE");
            Console.WriteLine("2 - VER SEUS MASCOTES ");
            Console.WriteLine("3 - SAIR DO JOGO");
            Console.WriteLine();
        }

        public void MenuAdocaoPokemon(Pokemon pokemon, string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine($"{nomeUsuario}, você deseja:");
            Console.WriteLine();
            Console.WriteLine($"1 - Saber mais sobre o {pokemon.name}");
            Console.WriteLine($"2 - Adotar o {pokemon.name}");
            Console.WriteLine("3 - Voltar");

        }

        public void MenuEscolherPokemon(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine("========= ADOTAR POKÉMON ========= \n\n");
            Console.WriteLine($"{nomeUsuario}, escolha uma espécie: ");
            Console.WriteLine();
            Console.WriteLine("1 - Bulbasaur");
            Console.WriteLine("4 - Charmander");
            Console.WriteLine("7 - Squirtle");
            Console.WriteLine();
        }
    }
}
