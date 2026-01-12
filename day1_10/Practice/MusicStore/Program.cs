using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        ArrayList Title = new ArrayList();
        ArrayList Artist = new ArrayList();
        while (true)
        {
            Console.Write("Enter Title of the song: ");
            string title = Console.ReadLine();
            if (!IsValidInput(title))
            {
                continue;
            }
            if (title.ToLower().Equals("quit"))
            {
                break;
            }
            else
            {
                Console.Write("Enter Artist of the song: ");
                string artist = Console.ReadLine();
                if (!IsValidInput(artist))
                {
                    continue;
                }
                Title.Add(title);
                Artist.Add(artist);
            }
        }
        DisplayAlbum(Title, Artist);
    }
    public static bool IsValidInput(string input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }
    public static void DisplayAlbum(ArrayList Title, ArrayList Artist)
    {
        Console.WriteLine("Album Songs:");
        for (int i = 0; i < Title.Count; i++)
        {
            Console.WriteLine($"Title: {Title[i]}, Artist: {Artist[i]}");
        }
    }
}