public class Hallogeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Hallo User " + user);
    }
}

public class Datageneric<T>
{
    private T data;
    public Datageneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
public class program
{
    public static void Main()
    {
        {
            Hallogeneric sapa = new Hallogeneric();
            sapa.SapaUser("Khansa");
        }

        Datageneric<string> dataNIM = new Datageneric<string>("103022300126");
        dataNIM.PrintData();
    }
}