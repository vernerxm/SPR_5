using System.Collections.Immutable;

namespace SPR_4;

abstract public class Builder
{
    public abstract Wheels getWheels();
    public abstract SeatBackrest getSeatBackrest();
    public abstract Seat getSeat();
    public abstract GasElevator getGasElevator();

   ~Builder() { }
}

class Director
{
    private Builder builder;

    public void setBuilder(Builder newBuilder) { builder = newBuilder; }

   public Chair getChair()
    {
        Chair chair = new Chair();
      chair.addWheels(builder.getWheels());  
      chair.addSeatBackrest( builder.getSeatBackrest());
      chair.addSeat(builder.getSeat());
      chair.addGasElevator(builder.getGasElevator());
        return chair;
    }
}

class GameChairBuilder : Builder
{
    public override Wheels getWheels() { return new Wheels(5, 10); }
    
    public override SeatBackrest getSeatBackrest() { return new SeatBackrest(80.5, "black"); }

    public override Seat  getSeat() { return new Seat("round"); }

    public override GasElevator getGasElevator() { return new GasElevator(40.8); }
}
class OfficeChairBuilder : Builder
{
    public override Wheels getWheels() { return new Wheels(4, 5); }
    
    public override SeatBackrest getSeatBackrest() { return new SeatBackrest(70.2, "white"); }

    public override Seat  getSeat() { return new Seat("quadrant"); }

    public override GasElevator getGasElevator() { return new GasElevator(35.7); }
}
