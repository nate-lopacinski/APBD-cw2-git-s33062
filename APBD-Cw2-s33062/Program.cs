Console.WriteLine("Hello, World!");


//sprzet
//laptop projektor ...
//2+ typy użtkownikow
//wypozyczenie: moment wypożyczenia, termin zwrotu, faktyczny zwrot oraz wynikające opłaty lub kary.

public abstract class User(String cName,String cSurname)
{
    private static int _nextId = 1;

    public int Id { get; set; } = _nextId++;
    public string Name { get; set; } = cName;
    public string Surname { get; set; } =  cSurname;
    
}

public class Student(String cName, String cSurname) : User(cName, cSurname)
{

}