namespace AppSingleton;

public sealed class Singleton
{
    private static  Singleton? _instance;
    private static readonly object padlock = new object();
    private int numberOfInstances = 0;
    private int contar = 0;

    private Singleton()
    {
        Console.WriteLine("Instantiating inside the private constructor");
        numberOfInstances++;
        Console.WriteLine("Number of instances ={0}", numberOfInstances);
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                Console.WriteLine($"");
                lock (padlock)
                {
                   
                    if (_instance is null)
                    {
                        Console.WriteLine("criei a instancia no padlock");
                        _instance = new Singleton();
                    }
                    else
                    {
                        Console.WriteLine("agora não está nulo");
                    }
                }
            }

            return _instance;
        }
    }
}