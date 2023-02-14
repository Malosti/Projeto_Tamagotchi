using RestSharp;
using System;
using System.Text.Json;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new View();

            menu.BoasVindas();             
        }
    }
}