namespace APBD_Cw2_s33062;

enum Status
{
    Available,
    CurrentlyRented,
    Unavailable
}

public abstract class Equipment(String cName,String cSurname)
{
    private static int _nextId = 1;
    private Status currStatus{ get; set; } = Status.Available;
    public int Id { get; set; } = _nextId++;
    
}

public class Laptop(String cName,String cSurname) : Equipment(cName, cSurname)
{
    private String? model{ get; set; } = null;
    
}