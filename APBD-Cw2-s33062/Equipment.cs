namespace APBD_Cw2_s33062;

enum Status
{
    Available,
    CurrentlyRented,
    Unavailable
}

public abstract class Equipment()
{
    private static int _nextId = 1;
    private Status currStatus{ get; set; } = Status.Available;
    public int Id { get; set; } = _nextId++;
    
}

public class Laptop() : Equipment()
{
    private String? model{ get; set; } = null;
    private String? batteryLife{ get; set; } = null;
    
}