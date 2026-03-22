namespace APBD_Cw2_s33062;

public abstract class Equipment(String cName,String cSurname)
{
    private static int _nextId = 1;

    public int Id { get; set; } = _nextId++;
    
}