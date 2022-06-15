using Newtonsoft.Json;
using Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = new List<Statistics>()
                {
                    new Statistics()
                    {
                        Name = "Strength",
                        Points = 10
                    },
                    new Statistics()
                    {
                        Name = "Inteligence",
                        Points = 10
                    }
                }
            };

            player.LevelUp();

            string playerSerialized = JsonConvert.SerializeObject(player);

            File.WriteAllText(@"C:\Users\Adrian\Desktop\PlayerSerialized.json", playerSerialized);
        }
    }
}
