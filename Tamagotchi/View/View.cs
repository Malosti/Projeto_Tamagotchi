using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class View
    {
        public static string MenuInicial()
        {
            Console.WriteLine("=========== TAMAGOTCHI ===========");
            Console.WriteLine("       Olá, seja bem vindo!!!     ");
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            var nomeUsuario = Console.ReadLine();
            Console.Clear();
            return nomeUsuario;
        }

        public static void MenuOpcaoUsuario(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine($"{nomeUsuario}, o que deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine("1 - ADOTAR MASCOTE");
            Console.WriteLine("2 - VER SEUS MASCOTES ");
            Console.WriteLine("3 - SAIR DO JOGO");
            Console.WriteLine();
        }

        public static void MenuAdocaoPokemon(Pokemon pokemon, string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine($"{nomeUsuario}, você deseja:");
            Console.WriteLine();
            Console.WriteLine($"1 - Saber mais sobre o {pokemon.name}");
            Console.WriteLine($"2 - Adotar o {pokemon.name}");
            Console.WriteLine("3 - Voltar");

        }

        public static void MenuEscolherPokemon(string nomeUsuario)
        {
            Console.Clear();
            Console.WriteLine("========= ADOTAR POKÉMON ========= \n");
            Console.WriteLine($"{nomeUsuario}, escolha uma espécie: ");
            Console.WriteLine();
            Console.WriteLine("1 - Bulbasaur");
            Console.WriteLine("4 - Charmander");
            Console.WriteLine("7 - Squirtle");
            Console.WriteLine();
        }

        public static void EstatisticaMascote(Pokemon pokemon)
        {
            Console.Clear();
            Console.WriteLine(" ======== Dados Pessoais ======== ");
            Console.WriteLine($" - Nome Pokemon: {pokemon.name.ToUpper()}");
            Console.WriteLine($" - Altura: {pokemon.height} m");
            Console.WriteLine($" - Peso: {pokemon.weight} Kg \n");
            Console.WriteLine(" ========= Necessidades ========= ");

            if(pokemon.VerificaFome() == true)
                Console.WriteLine(" O Pokémon está com fome");
            else
                Console.WriteLine(" O Pokémon está alimentado");

            if(pokemon.VerificaDescanso() ==  true)
                Console.WriteLine(" O Pokémon está com sono");
            else
                Console.WriteLine(" O Pokémon está descansado");

            if(pokemon.VerificaHumor() == true)
                Console.WriteLine(" O Pokémon quer brincar");
            else
                Console.WriteLine(" O Pokémon está feliz");

            Console.WriteLine(" ========== Habilidades ========= ");
            foreach (var item in pokemon.abilities)
            {
                Console.WriteLine($" - {item.ability.name.ToUpper()}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static int ListaMascotes(string nomeUsuario, List<Pokemon> pokemons)
        {
            Console.Clear();
            Console.WriteLine(" ========== Lista de Pokemons ========== \n ");
            Console.WriteLine($"{nomeUsuario}, você possui {pokemons.Count} Pokémons \n");
            foreach (var item in pokemons)
            {
                Console.WriteLine($" - {item.name.ToUpper()}");
            }
            Console.WriteLine();
            Console.WriteLine("Com qual deseja interagir ? ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
