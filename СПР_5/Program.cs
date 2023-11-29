namespace SPR_4;

public class Program
{
    static void Main()
    {
        Chair gameChair= new Chair();
        Chair officeChair = new Chair();

        Director director = new Director();

        GameChairBuilder gameChairBuilder = new GameChairBuilder();
        OfficeChairBuilder officeChairBuilder = new OfficeChairBuilder();
        Console.WriteLine("GameChair");
        director.setBuilder( gameChairBuilder);
        gameChair = director.getChair();
        gameChair.printInfo();
        
        Console.WriteLine("OfficeChair");
        director.setBuilder( officeChairBuilder);
        officeChair = director.getChair();
        officeChair.printInfo();
    }
}