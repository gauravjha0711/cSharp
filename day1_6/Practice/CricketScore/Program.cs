using System;
public class CricketMatch
{
    public int[] playerScores;
    public int currentIndex;

    public CricketMatch()
    {
        playerScores = new int[5]; // Max 5 players
        currentIndex = 0;
    }

    public void AddPlayerScore(int score)
    {
        if (score < 0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }
        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores.");
        }
        playerScores[currentIndex] = score;
        currentIndex++;
    }

    public int CalculateTotalScore()
    {
        int total = 0;
        for (int i = 0; i < currentIndex; i++)
        {
            total += playerScores[i];
        }
        return total;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            CricketMatch match = new CricketMatch();
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            foreach (string val in values)
            {
                int score = int.Parse(val);
                match.AddPlayerScore(score);
            }

            int totalScore = match.CalculateTotalScore();
            Console.WriteLine($"Total score of the cricket team: {totalScore}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
