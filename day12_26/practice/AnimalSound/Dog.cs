using System;
using System.Runtime.InteropServices.Marshalling;
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Bark Bark");
    }
}