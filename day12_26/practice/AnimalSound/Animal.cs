using System;
class Animal
{
    protected string name;
    public virtual void Sound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}