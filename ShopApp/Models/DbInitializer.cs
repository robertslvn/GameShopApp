using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Games.Any())
            {
                context.AddRange
                (
                    new Game { Name = "NieRL Automata", Price = 79.99M, ShortDescription = "NieR: Automata for the PS4", LongDescription = "Invaders from another world attack without warning - unleashing the machine lifeforms. To break the deadlock, a new breed of android infantry is sent into the fray: the YoRHa squad. NieR: Automata™ is a fresh take on the action role-playing game (RPG) genre that gracefully blends mesmerising action with a captivating story.", Category = Categories["PS4 Games"], ImageUrl = "/Images/nier.jpg", InStock = true, IsGameOfTheWeek = true, ImageThumbnailUrl = "/Images/nier.jpg", RatingInformation = "" },
                    new Game { Name = "NBA 2K17", Price = 59.99M, ShortDescription = "NBA 2k17 for the PS4", LongDescription = "Jump into the next installment of the NBA 2K franchise with NBA 2K17 for PlayStation 4. Enjoy an authentic NBA experience that blurs the line between video game and reality.", Category = Categories["PS4 Games"], ImageUrl = "/Images/nba.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/nba.jpg", RatingInformation = "" },
                    new Game { Name = "Battlefield 1", Price = 69.99M, ShortDescription = "Battlefield 1 for the PS4", LongDescription = "Grab your Mauser and trench club and get ready to battle Old Fritz and the Hun in Battlefield 1 for Playstation 4. The Battlefield franchise returns to its military origins in this World War I-inspired first-person shooter. Fight your way across No Man's Land or take to the skies in intense dogfights and experience the Great War like never before.", Category = Categories["PS4 Games"], ImageUrl = "/Images/bfield.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/bfield.jpg", RatingInformation = "" },
                    new Game { Name = "Destiny 2", Price = 79.99M, ShortDescription = "Destiny 2 for the PS4", LongDescription = "Embark on an epic journey across the solar system in Destiny 2 for PlayStation 4. The Red Legion have destroyed the last safe city. Powerless and defeated, as one of the surviving Guardians you'll need to get busy, travel to unexplored worlds, uncover new weapons, and learn new combat abilities to defeat the Red Legion. Don't worry, you've got this.", Category = Categories["PS4 Games"], ImageUrl = "/Images/destiny.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/destiny.jpg", RatingInformation = "" },
                    new Game { Name = "NHL 17", Price = 39.99M, ShortDescription = "NHL 17 for the XBOX One", LongDescription = "Hit the ice, push the pace, and compete for the Cup in NHL 17 for Xbox One. Go head-to-head against your favourite players and teams as you guide your team to the ultimate prize with improved gameplay mechanics and a new Net Battle system. Game modes include Draft Champions, World Cup of Hockey, Franchise EASHL, and Be a Pro.", Category = Categories["XBOX ONE Games"], ImageUrl = "/Images/nhl.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/nhl.jpg", RatingInformation = "" },
                    new Game { Name = "Mass Effect: Andromedia", Price = 49.99M, ShortDescription = "Mass Effect: Andromedia for the XBOX One", LongDescription = "Join the expedition and go far beyond the Milky Way to new uncharted worlds in Mass Effect: Andromeda Deluxe Edition for Xbox One. With your team of military-trained explorers, you'll encounter hostility at every turn as you traverse through distant solar systems. The choices you make throughout the game will determine mankind's survival in the Andromeda galaxy.", Category = Categories["XBOX ONE Games"], ImageUrl = "/Images/meffect.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/meffect.jpg", RatingInformation = "" },
                    new Game { Name = "For Honor: Deluxe Edition", Price = 59.99M, ShortDescription = "For Honor: Deluxe Edition for the XBOX One", LongDescription = "Storm castles and slash your way through epic medieval-era battles in For Honor: Deluxe Edition for Xbox One. Take control of a legendary Knight, Viking, or Samurai warrior and dive headlong into chaotic single-player campaign. Use the Art of Battle combat system to master sword fighting, then take your skills online in frenetic multiplayer matches.", Category = Categories["XBOX ONE Games"], ImageUrl = "/Images/fhonor.jpg", InStock = false, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/fhonor.jpg", RatingInformation = "" },
                    new Game { Name = "Sid Meier’s Civilization VI", Price = 79.99M, ShortDescription = " Sid Meier’s Civilization VI for the PC", LongDescription = "Take the reins of your chosen civilization and lead your people from the Stone Age to the Information Age in Sid Meier's Civilization VI for PC. Use a mix of military might, diplomatic cunning, and investment in research to rise and become the leader of the greatest civilization known to mankind.", Category = Categories["PC Games"], ImageUrl = "/Images/civ.jpg", InStock = true, IsGameOfTheWeek = true, ImageThumbnailUrl = "/Images/civ.jpg", RatingInformation = "" },
                    new Game { Name = "Diablo III", Price = 39.99M, ShortDescription = "Diable III for the PC", LongDescription = "Unbox the ultimate Diablo III experience with this Battle Chest, which includes the original base game Diablo III, as well as the Reaper of Souls expansion pack. Mephisto, the Angel of Death, has emerged to steal the Black Soulstone. Battle endless hordes of demonic enemies on your quest to save the realms.", Category = Categories["PC Games"], ImageUrl = "/Images/diablo.jpg", InStock = true, IsGameOfTheWeek = true, ImageThumbnailUrl = "/Images/diablo.jpg", RatingInformation = "" },
                    new Game { Name = "Grant Theft Auto V", Price = 69.99M, ShortDescription = "Grand Theft Auto V for the PC", LongDescription = "Grand Theft Auto V for PC features a young street hustler, a retired bank robber, and a terrifying psychopath who are entangled with the criminal underworld, the U.S. government and the entertainment industry. In order to survive the streets of Los Santos and Blaine County, they must pull off a series of dangerous heists. ", Category = Categories["PC Games"], ImageUrl = "/Images/gta.jpg", InStock = true, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/gta.jpg", RatingInformation = "" },
                    new Game { Name = "World of Warcraft: Legion", Price = 49.99M, ShortDescription = "World of Warcraft: Legion for the PC", LongDescription = "A terrible darkness has returned to Azeroth in World of Warcraft: Legion. Set in the Broken Isles, this expansion features new dungeons, raids, and world bosses to conquer. Legion introduces the Demon Hunter class, Artifacts, revamped PVP system, and raised level cap of 110. An included boost instantly levels a new or existing character to level 100. ", Category = Categories["PC Games"], ImageUrl = "/Images/warcraft.jpg", InStock = false, IsGameOfTheWeek = false, ImageThumbnailUrl = "/Images/warcraft.jpg", RatingInformation = "" }
                );

            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "PS4 Games" },
                        new Category { CategoryName = "XBOX ONE Games" },
                        new Category { CategoryName = "PC Games" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }


}
