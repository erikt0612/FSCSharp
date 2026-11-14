namespace RunningBunny;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Press enter to start");
        Console.ReadLine();

        using (new RunningBunnyGame().Run()) { }
    }
}