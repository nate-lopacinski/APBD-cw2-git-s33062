namespace APBD_Cw2_s33062;

//is this being absraxt good or should i just solve it w an enum
//zaleta osobnych klass jest latwiejsze zmienianie ilosci max wypozyczen i think
public abstract class User(String cName,String cSurname)
{
    private static int _nextId = 1;

    public int Id { get; set; } = _nextId++;
    public string Name { get; set; } = cName;
    public string Surname { get; set; } =  cSurname;
    static public int MaxRentingAmount { get; set; }
    
}

public class Student(String cName, String cSurname) : User(cName, cSurname)
{
    new public static int MaxRentingAmount { get; set; } =2;
}

public class Employee(String cName, String cSurname) : User(cName, cSurname)
{
    new public static int MaxRentingAmount { get; set; } =5;

}
