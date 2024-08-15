using SingletonPattern;
 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program başlıyor.\n");
        
        //Singelton1
        Console.WriteLine("Singelton1 çalışıyor.");
        Singelton1 s1 = Singelton1.Instance;
        Console.WriteLine("\n");
        
        //Singelton2
        Console.WriteLine("Singelton2 çalışıyor.");
        Parallel.Invoke(
            () => AccessSingleton1(),
            () => AccessSingleton1(),
            () => AccessSingleton1()
        );
        Console.WriteLine("\n");
        
        
        // Singelton3
        Parallel.Invoke(
            () => AccessSingleton(),
            () => AccessSingleton(),
            () => AccessSingleton()
        );
        Console.WriteLine("\n");

        // Singelton4
        Parallel.Invoke(
            () => AccessSingleton2(),
            () => AccessSingleton2(),
            () => AccessSingleton2()
        );
    }
    static void AccessSingleton1()
    {
        Singelton2 singleton = Singelton2.Instance;
        Console.WriteLine(singleton.GetHashCode());
    }
    static void AccessSingleton()
    {
        Singelton3 singleton = Singelton3.Instance;
        Console.WriteLine(singleton.GetHashCode());
    }
    static void AccessSingleton2()
    {
        Singelton4 singleton = Singelton4.Instance;
        Console.WriteLine(singleton.GetHashCode());
    }
}


