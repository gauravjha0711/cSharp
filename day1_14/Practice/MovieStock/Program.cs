using System;
using System.ComponentModel.DataAnnotations;
public class Movie
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genere { get; set; }
    public int Ratings { get; set; } 
}
public class Program
{
    public static List<Movie> movies = new List<Movie>()
        {
            new Movie(){ Title="Sholay", Artist="Dharmendra", Genere="Drama", Ratings=9 },
            new Movie(){ Title="Gadar", Artist="Sunny Deol", Genere="Action", Ratings=8 },
            new Movie(){ Title="3 Idiots", Artist="Aamir Khan", Genere="Comedy", Ratings=9 },
            new Movie(){ Title="Dilwale", Artist="Ajay Devgn", Genere="Romance", Ratings=7 },
            new Movie(){ Title="Coolie No.1", Artist="Govinda", Genere="Comedy", Ratings=6 }
        };
    public static void Main()
    {
        // Console.WriteLine("Enter details of Movie in one string space separated: Title Artist Genere Ratings");
        // string MovieDetails = Console.ReadLine();
        // AddMovie(MovieDetails);
        while (true)
        {
            Console.WriteLine("1. For adding Movies Details.");
            Console.WriteLine("2. For viewing or search details of Movies by Genre.");
            Console.WriteLine("3. Sort by ratings. and see Movie Details.");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice:");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter details of Movie in one string space separated: Title Artist Genere Ratings");
                string MovieDetails = Console.ReadLine();
                AddMovie(MovieDetails);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter Genre to filter Movies:");
                string genre = Console.ReadLine();
                List<Movie> FilteredMovies = ViewMoviesByGenre(genre);
                if(FilteredMovies.Count == 0)
                {
                    Console.WriteLine("No movies found for the given genre.");
                }
                else
                {
                    foreach(var movie in FilteredMovies)
                    {
                        Console.WriteLine($"Title: {movie.Title}, Artist: {movie.Artist}, Genre: {movie.Genere}, Ratings: {movie.Ratings}");
                    }
                }
            }
            else if(choice == 3)
            {
                List<Movie> SortedMovies = ViewMoviesByRatings();
                if(SortedMovies.Count == 0)
                {
                    Console.WriteLine("No movies available to sort.");
                }
                else
                {
                    foreach(var movie in SortedMovies)
                    {
                        Console.WriteLine($"Title: {movie.Title}, Artist: {movie.Artist}, Genre: {movie.Genere}, Ratings: {movie.Ratings}");
                    }
                }
            }
            else if(choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    public static void AddMovie(string MovieDetails)
    {
        string[] Details = MovieDetails.Split(' ');
        Movie movie = new Movie();
        movie.Title = Details[0];
        movie.Artist = Details[1];
        movie.Genere = Details[2];
        movie.Ratings = int.Parse(Details[3]);
        movies.Add(movie);
    }
    public static List<Movie> ViewMoviesByGenre(string genre)
    {
        List<Movie> FilterMovies = movies.Where(m=>m.Genere == genre).ToList();
        return FilterMovies;
    }
    public static List<Movie> ViewMoviesByRatings()
    {
        List<Movie> OrderMovie = movies.OrderBy(m=>m.Ratings).ToList();
        return OrderMovie;
    }
}