using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class MockGameRepository : IGameRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Game> Games
        {
            get
            {
                return new List<Game>
                {
                    new Game {GameId = 1, Name="Battlefield 1", Price=49.99M, ShortDescription="Battlefield 1 for Xbox One", LongDescription="Fight your way through epic battles going from tight urban combat in a besieged French city to big open spaces in the Italian Alps or frantic combats in the deserts of Arabia, in large scale battles as infantry or piloting vehicles on land, air and sea, from the tanks and bikes on the ground, to biplanes and gigantic battleships.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://images-eds-ssl.xboxlive.com/image?url=8Oaj9Ryq1G1_p3lLnXlsaZgGzAie6Mnu24_PawYuDYIoH77pJ.X5Z.MqQPibUVTcB7WVDn.f4Uli2dyqvJAR1iMrHLquSMr6CthfgctOtrsyBnC_Zv7eq4lChNPm3qxR33Lgrxz_OKuNIamR55zuk1T3S7eijaPWjhPD17gypzf67BKzxlcZcyOS5jy8FHejUvn0dC_gMzLOR9pOvfNfQ2BvOFWqhskBQ6BqgGiZ4OA-", InStock=true, IsGameOfTheWeek=false, ImageThumbnailUrl="http://compass.xbox.com/assets/4d/40/4d40fdd8-8d8b-4dd2-997f-355649c11489.png?n=Battlefield1_boxshot_124x160.png"},
                    new Game {GameId = 2, Name="Nier: Automata", Price=18.95M, ShortDescription="Nier: Automata for PS4", LongDescription="Humanity has been driven from the Earth by mechanical beings from another world. In a final effort to take back the planet, the human resistance sends a force of android soldiers to destroy the invaders. Now, a war between machines and androids rages on... A war that could soon unveil a long-forgotten truth of the world.", Category = _categoryRepository.Categories.ToList()[1],ImageUrl="https://static-ca.ebgames.ca/images/products/726191/3max.jpg", InStock=true, IsGameOfTheWeek=false, ImageThumbnailUrl="https://static-ca.ebgames.ca/images/products/726191/2med.jpg"},
                    new Game {GameId = 3, Name="FIFA 17", Price=39.99M, ShortDescription="FIFA 17 for Xbox One", LongDescription="Powered by Frostbite, FIFA 17 transforms the way you play, compete, and emotionally connect with the game. FIFA 17 immerses you in authentic football experiences by leveraging the sophistication of a new game engine, while introducing you to football players full of depth and emotion, and taking you to brand new worlds accessible only in the game. Complete innovation in the way players think and move, physically interact with opponents, and execute in attack lets you own every moment on the pitch.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="http://images-eds.xboxlive.com/image?url=8Oaj9Ryq1G1_p3lLnXlsaZgGzAie6Mnu24_PawYuDYIoH77pJ.X5Z.MqQPibUVTcoYBrJRe6ocDBW_8MGfBUlzYTrjKUmdO25Ts6oNYyGWDGvobTsbqjSpF4U8V66rCHXSJROerarXXIWHohVywULDMckBZUPKnb7dVWs6o0yDltdjxorEBW21R3KJ4RG5JtFzabVQIxWleTEldxvQ2.I2OvBoELfNsabstNqb66h5k-&format=png&h=294&w=215", InStock=true, IsGameOfTheWeek=true, ImageThumbnailUrl="http://compass.xbox.com/assets/fc/77/fc770261-0907-43fb-a097-faa60b708987.png?n=Fifa-17-boxshot_124x160_standard.png"},
                    new Game {GameId = 4, Name="Overwatch", Price=12.95M, ShortDescription="Overwatch for PC", LongDescription="Clash on the battlefields of tomorrow and choose your hero from a diverse cast of soldiers, scientists, adventurers, and oddities. Bend time, defy physics, and unleash an array of extraordinary powers and weapons. Engage your enemies in iconic locations from around the globe in the ultimate team-based shooter. Take your place in Overwatch. The world needs heroes.", Category = _categoryRepository.Categories.ToList()[2],ImageUrl="https://static-ca.ebgames.ca/images/products/722244/3max.jpg", InStock=true, IsGameOfTheWeek=true, ImageThumbnailUrl="https://static-ca.ebgames.ca/images/products/722244/2med.jpg"}
                };
            }
        }

        public IEnumerable<Game> GamesOfTheWeek { get; }
        public Game GetGameById(int GameId)
        {
            throw new System.NotImplementedException();
        }
    }
}
