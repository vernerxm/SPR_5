namespace SPR_4;
//final product
public class Chair
{
    private Wheels wheels ;
    private SeatBackrest seatBackrest ;
    private Seat seat ;
    private GasElevator gasElevator ;

    public void addWheels(Wheels _wheels) { wheels = _wheels; }
    public void addSeatBackrest(SeatBackrest _seatBackrest) { seatBackrest = _seatBackrest; }
    public void addSeat(Seat _seat) { seat= _seat; }
    public void addGasElevator(GasElevator _gasElevator) { gasElevator= _gasElevator; }

   public void printInfo()
    {
        Console.WriteLine("Number of wheels : " + wheels.getNumberOfWheels()+"with diameter" + wheels.getDiameterOfWeel());
        Console.WriteLine(seatBackrest.getColorBackrest()+"seat backrest with height : "+seatBackrest.getBackrestHeight());
        Console.WriteLine(seatBackrest.getColorBackrest()+"seat whith a"+ seat.getSeatShape()+"shape");
        Console.WriteLine("Gas elevator with height : "+ gasElevator.getElevatorHeight());
    }
    ~Chair() { Console.WriteLine("Final products deconstructor"); }
}