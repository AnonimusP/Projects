using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WebApplication2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            {
                using (var context = new WebApplication2Context(serviceProvider.GetRequiredService<DbContextOptions<WebApplication2Context>>()))
                {
                    //Look for any movies
                    if (context.Game.Any())
                    {
                        return; //DB has been seeded
                    }
                    context.Game.AddRange(
                        new Game
                        {
                            tytul = "CS:GO",
                            data_wydania = DateTime.Parse("01-11-2008"),
                            gatunek = "Akcji/Multiplayer",
                            ocena = "18+",
                            cena = 2
                        },
                        new Game
                        {
                            tytul = "Battlefield",
                            data_wydania = DateTime.Parse("01-11-2010"),
                            gatunek = "Akcji/Multiplayer",
                            ocena = "18+",
                            cena = 2
                        },
                        new Game
                        {
                            tytul = "Skyrim",
                            data_wydania = DateTime.Parse("01-11-2012"),
                            gatunek = "Akcji/RPG",
                            ocena = "13+",
                            cena = 2
                        }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}

