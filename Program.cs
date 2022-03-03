using MovieDatabase;

string yn = "y"; 
Console.WriteLine("Welcome to the Movie List Application!");

List<Movie> movieList = new List<Movie>();
Movie movie = new ("Star Wars", "scifi");
movieList.Add(movie);

movieList.Add(new Movie("2001 A Space Odyssey", "scifi"));
movieList.Add(new Movie("Snow White and the Seven Dwarfs", "animated"));
movieList.Add(new Movie("Psycho", "horror"));
movieList.Add(new Movie("Citizen Kane", "drama"));
movieList.Add(new Movie("Beauty and the Beast", "animated"));
movieList.Add(new Movie("The Shining", "horror"));
movieList.Add(new Movie("Taxi Driver", "drama"));
movieList.Add(new Movie("The Exorcist", "horror"));
movieList.Add(new Movie("Toy Story", "animated"));

Console.WriteLine($"There are {movieList.Count} movies in this list.");
string userCategory = "";

do 
{   
    bool inList = false;
    Console.WriteLine("What category are you interested in? ");
    Console.WriteLine($"Either enter the name, or enter\n 1 for scifi\n 2 for drama\n 3 for animated\n 4 for horror\n");
    int intCategory;
    try
    {
        userCategory = Console.ReadLine().ToLower();
        bool isInt = int.TryParse(userCategory, out intCategory);
        if(isInt)
            switch (intCategory)
            {
                case 1: userCategory = "scifi";
                    break;
                case 2: userCategory = "drama";
                    break;
                case 3: userCategory = "animated";
                    break;
                case 4: userCategory = "horror";
                    break;
                default: userCategory = "Invalid Number";
                    Console.WriteLine("Only categories 1-4 are currently in the movie database. ");              
                    break;
            }
        foreach (var movieCat in movieList)
        {
            if (movieCat.GetMovieCategory().Equals(userCategory))
            {
                Console.WriteLine($"{movieCat.GetMovieTitle()}");
                inList = true;
            }
        }
        if (inList != false)
            Console.WriteLine("\nSORTED ORDER");
        List<Movie> movieCatList = movieList.Where(x => x.GetMovieCategory() == userCategory).ToList();
        var movieListSorted = movieCatList.OrderBy(x => x.GetMovieTitle()).ToList();
        foreach (var movieCat2 in movieListSorted)
        {
        
            Console.WriteLine($"{movieCat2.GetMovieTitle()}");
            inList = true;
            
        }

    }
    catch (Exception Ex)
    {
        Console.WriteLine("Your input wasn't valid.");
    }
    if (inList == false)
        Console.WriteLine("We don't have the category you typed. Please enter, drama, scifi, animated, or horror.");

    Console.WriteLine("\nWould you like to continue? y or n");
    yn = Console.ReadLine().ToLower();
}
while (yn == "y");





