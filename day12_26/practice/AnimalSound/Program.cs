using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Animal Sound Simulaor: ");
        Console.WriteLine("Enter number of animals: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid number of animals.");
            return;
        }
        Animal[] animals = new Animal[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter type of animal {i + 1} (Dog/Cat): ");
            string type = Console.ReadLine().Trim().ToLower();
            if (type == "dog")
            {
                animals[i] = new Dog();
            }
            else if (type == "cat")
            {
                animals[i] = new Cat();
            }
            else if(type=="animal")
            {
                animals[i] = new Animal();
            }
            else
            {
                Console.WriteLine("Unknown animal type. Defaulting to generic Animal.");
                animals[i] = new Animal();
            }
        }
        for (int i = 0; i < n; i++)
        {
            animals[i].Sound();
        }
    }
}