using Skeleton;

public class StartUp
{
    static void Main(string[] args)
    {
        var dragon = new Dragon("Pesho", new ConsoleIntroducer());

        dragon.Introduce();
    }
}
