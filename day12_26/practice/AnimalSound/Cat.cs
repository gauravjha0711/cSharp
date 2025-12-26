using System;
using System.Runtime.InteropServices.Marshalling;
class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Meow Meow");
    }
}