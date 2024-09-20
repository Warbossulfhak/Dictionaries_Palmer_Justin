using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
namespace Dictionaries_Palmer_Justin
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Dictionary Value list.
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Tiny Tina's Wonderlands");
            topGames.Add(2, "GS:GO");
            topGames.Add(3, "Halo 3");
            topGames.Add(4, "Elden Ring");
            topGames.Add(5, "Sonic Adventures 2");
            topGames.Add(6, "Kirby Airride");
            topGames.Add(7, "Donkey Kong 64");
            topGames.Add(8, "Runescape");
            topGames.Add(9, "GTA; San Andreas");
            topGames.Add(10, "Valorant");
            // foreach loop to print the key value pair.
            foreach(KeyValuePair<int, string> kvp in topGames)
            {//To print the key value pair use in a foreach loop.
                Console.WriteLine($"Key; {kvp.Key}, Value: {kvp.Value}"); 
            }
            // to check for an unknow key
            if (topGames.ContainsKey(1))
            {// prints to console favortie game is Tiny Tina's Wonderlands.
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            string result = "";
            // TryGetValue to get a value of unknown key.
            topGames.TryGetValue(11, out result);

            if(result != "")
            {
                Console.WriteLine(result);
            }
            else
            {// there is no game in th eeleventh posisiton.
                Console.WriteLine("There is no game in the eleventh posisition.");
            }

            if(topGames.ContainsKey(5))
            { // top games5 Rocket league.
                topGames[5] = "Rocket League";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string favGame = (string)hashTable[1];
            // Writes to the console Favorite Game is Tiny Tina's Wonderlands.
            Console.WriteLine($"Favorite Game: {favGame}");
            //elements are storred as dictionary entrys objects .
            Hashtable capitals = new Hashtable() { 
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" }
           }; 
            // foreach loop to access the dictionary entrys objects .
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            // removes all elements from Hashtables.
            capitals.Clear();
        }
    }
}