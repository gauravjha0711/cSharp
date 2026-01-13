class Program
{
    public static void Main()
    {
        // Console.WriteLine("Heello, LINQ!");
        //DataSource;
        // string[] names = {"gaurav","kundan","krishna","shubham","john"};

        // //write the query
        // //IEnumerable<string> names
        // // var name = from s in names where s.Contains('a') select s;
        // var name = names.Where(s=>s.Contains('a'));
        // var name2 = name.Where(s=>s.Length>6);
        // //execute the query
        // foreach(string s in name)
        // {
        //     Console.WriteLine(s);
        // }
        // Console.WriteLine("--------");
        // foreach(string s in name2)
        // {
        //     Console.WriteLine(s);
        // }



        IList<string> stringList = new List<string>()
        {
            "c# tutorial",
            "java tutorial",
            "python tutorial",
            "learn c++",
            "java",
        };
        var result = stringList.Where(s=>s.Contains("tutorial"));
        foreach(var str in result)
        {
            Console.WriteLine(str);
        }
    }
}