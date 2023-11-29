namespace SPR_4;

//Product parts

public class Wheels //колеса
{
    private int amount;
    private double radius;

    public Wheels(int _amount,double _radius)
    {
        amount = _amount;
        radius = _radius;
    }

   public int getNumberOfWheels() { return amount; }
   public double getDiameterOfWeel() { return radius*2; }
}

public class SeatBackrest  //сидіння до крісла
{
    private double height;
    private string color;

    public SeatBackrest(double _height,string _color)
    {
        height = _height;
        color = _color;
    }
   public double getBackrestHeight() { return height; }
   public string getColorBackrest() { return color; }
}

public class Seat //сидіння
{ 
    private string shape;

    public Seat(string _shape) { shape = _shape; }

   public string getSeatShape() { return shape; }
}

public class GasElevator //підйомний елеватор
{
    private double liftingHeight;

    public GasElevator(double _liftingHeight) { liftingHeight = _liftingHeight; }

   public double getElevatorHeight() { return liftingHeight; }
}