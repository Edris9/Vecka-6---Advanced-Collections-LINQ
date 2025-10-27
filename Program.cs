namespace Vecka_6___Advanced_Collections___LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<Game>
                    {
                        new Game { Title = "The Last of Us Part II", Genre = "Action-Adventure", ReleaseYear = 2020, Rating = 9.3, Price = 499 },
                        new Game { Title = "Cyberpunk 2077", Genre = "RPG", ReleaseYear = 2020, Rating = 8.1, Price = 399 },
                        new Game { Title = "Elden Ring", Genre = "Action-RPG", ReleaseYear = 2022, Rating = 9.8, Price = 599 },
                        new Game { Title = "God of War Ragnarök", Genre = "Action-Adventure", ReleaseYear = 2022, Rating = 9.4, Price = 699 },
                        new Game { Title = "Baldur's Gate 3", Genre = "RPG", ReleaseYear = 2023, Rating = 9.7, Price = 599 },
                        new Game { Title = "Hogwarts Legacy", Genre = "Action-RPG", ReleaseYear = 2023, Rating = 8.5, Price = 599 },
                        new Game { Title = "Spider-Man 2", Genre = "Action-Adventure", ReleaseYear = 2023, Rating = 9.1, Price = 799 },
                        new Game { Title = "Starfield", Genre = "RPG", ReleaseYear = 2023, Rating = 7.8, Price = 699 },
                        new Game { Title = "Helldivers 2", Genre = "Shooter", ReleaseYear = 2024, Rating = 8.6, Price = 449 },
                        new Game { Title = "Black Myth: Wukong", Genre = "Action-RPG", ReleaseYear = 2024, Rating = 9.0, Price = 599 }
                    };


            //var allgames = games.Select(game => game.Title);

            //var rpggames = games.Where(game => game.Genre == "RPG");
            //foreach (var game in rpggames)
            //{
            //    Console.WriteLine(game.Title);
            //}

            //var moderngame = games.Any(games => games.ReleaseYear > 2050);
            //Console.WriteLine("There are modern games in the list." + moderngame);
            //if (moderngame == true)
            //{
            //    Console.WriteLine("There are modern games in the list.");
            //    foreach (var game in games)
            //    {
            //        Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("There are no modern games in the list.");
            //}


        }

    }
    
}

