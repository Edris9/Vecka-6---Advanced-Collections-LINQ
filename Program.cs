namespace Vecka_6___Advanced_Collections___LINQ;
using System.Text.Json;

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
                    new Game { Title = "Black Myth: Wukong", Genre = "Action-RPG", ReleaseYear = 2024, Rating = 9.0, Price = 599 },
                    new Game { Title = "Red Dead Redemption 2", Genre = "Action-Adventure", ReleaseYear = 2018, Rating = 9.7, Price = 399 },
                    new Game { Title = "The Witcher 3", Genre = "RPG", ReleaseYear = 2015, Rating = 9.8, Price = 299 },
                    new Game { Title = "Minecraft", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.0, Price = 269 },
                    new Game { Title = "Grand Theft Auto V", Genre = "Action-Adventure", ReleaseYear = 2013, Rating = 9.5, Price = 349 },
                    new Game { Title = "Dark Souls III", Genre = "Action-RPG", ReleaseYear = 2016, Rating = 9.2, Price = 399 },
                    new Game { Title = "Sekiro: Shadows Die Twice", Genre = "Action-Adventure", ReleaseYear = 2019, Rating = 9.4, Price = 499 },
                    new Game { Title = "Bloodborne", Genre = "Action-RPG", ReleaseYear = 2015, Rating = 9.3, Price = 299 },
                    new Game { Title = "Horizon Zero Dawn", Genre = "Action-RPG", ReleaseYear = 2017, Rating = 8.9, Price = 349 },
                    new Game { Title = "Ghost of Tsushima", Genre = "Action-Adventure", ReleaseYear = 2020, Rating = 9.2, Price = 499 },
                    new Game { Title = "Death Stranding", Genre = "Action", ReleaseYear = 2019, Rating = 8.2, Price = 399 },
                    new Game { Title = "Resident Evil 4", Genre = "Horror", ReleaseYear = 2023, Rating = 9.3, Price = 599 },
                    new Game { Title = "Final Fantasy XVI", Genre = "RPG", ReleaseYear = 2023, Rating = 8.7, Price = 699 },
                    new Game { Title = "Street Fighter 6", Genre = "Fighting", ReleaseYear = 2023, Rating = 9.0, Price = 599 },
                    new Game { Title = "Mortal Kombat 1", Genre = "Fighting", ReleaseYear = 2023, Rating = 8.3, Price = 699 },
                    new Game { Title = "Diablo IV", Genre = "Action-RPG", ReleaseYear = 2023, Rating = 8.5, Price = 699 },
                    new Game { Title = "The Legend of Zelda: Tears of the Kingdom", Genre = "Action-Adventure", ReleaseYear = 2023, Rating = 9.9, Price = 599 },
                    new Game { Title = "Super Mario Bros. Wonder", Genre = "Platformer", ReleaseYear = 2023, Rating = 9.1, Price = 599 },
                    new Game { Title = "Alan Wake 2", Genre = "Horror", ReleaseYear = 2023, Rating = 9.0, Price = 599 },
                    new Game { Title = "Palworld", Genre = "Survival", ReleaseYear = 2024, Rating = 8.4, Price = 299 },
                    new Game { Title = "Dragon's Dogma 2", Genre = "Action-RPG", ReleaseYear = 2024, Rating = 8.6, Price = 699 }
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

        //var SortedGames = games.OrderBy(game => game.ReleaseYear);
        //foreach (var game in SortedGames)
        //{
        //    Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
        //}

        //var SortedGames = games.OrderByDescending(game => game.ReleaseYear);
        //foreach (var game in SortedGames)
        //{
        //    Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
        //}

        //var RatingAverage = games.Average(game => game.Rating);
        //Console.WriteLine("The average rating of all games is: " + RatingAverage);

        //var maxrating = games.Max(game => game.Rating);
        //Console.WriteLine("The highest rating of all games is: " + maxrating);

        //var lowrating = games.Min(game => game.Rating);
        //Console.WriteLine("The lowest rating of all games is: " + lowrating);

        //var bestgame = games.First(game => game.Rating == maxrating);
        //Console.WriteLine("The best rated game is: " + bestgame.Title + "with rating: " + bestgame.Rating);

        //var GruppedGames = games.GroupBy(game => game.Genre);
        //foreach (var group in GruppedGames)
        //{
        //    Console.WriteLine($"Genre: { group.Key}");

        //    foreach(var game in group)
        //    {
        //    Console.WriteLine($" - {game.Title} ({game.ReleaseYear}) Rating: {game.Rating}");

        //    }
        //}


        //var budgetforgame = games
        //.Where(g => g.Price <= 300 && g.Genre == "RPG")
        //.OrderByDescending(g => g.Rating)
        //.Select(g => $"The titel is {g.Title} and pris {g.Price} Rating for this is {g.Rating} and it realsed year: {g.ReleaseYear}");

        //foreach (var game in budgetforgame)
        //{
        //    Console.WriteLine(game);
        //}

        //var pagination = games.Skip(3).Take(5);
        //foreach (var game in pagination)
        //{
        //    Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
        //}

        //var cheapestgame = games
        //    .OrderBy(g => g.Price)
        //    .First();
        //Console.WriteLine($"The cheapest game is {cheapestgame.Title} with a price of {cheapestgame.Price} SEK.");

        //try
        //{

        //string jsonText = File.ReadAllText("books.json");
        //var bookList = JsonSerializer.Deserialize<List<Books>>(jsonText);
        //foreach (var line in bookList)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}
        //catch (FileNotFoundException ex)
        //{
        //    Console.WriteLine("File not found: " + ex.Message);

        //}


        // reserve metod in list
        List<string> sampleList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry"
        };

        Console.WriteLine("Original List:");
        foreach (var item in sampleList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Thsi is reversed list:");
        sampleList.Reverse();

        foreach (var item in sampleList)
        {
            Console.WriteLine(item);
        }


    }
}

