Console.WriteLine("Hello, World!");


//is this being absraxt good or should i just solve it w an enum
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

public class Employee(String cName, String cSurname) : User(cName, cSurname)
{

}




//user
//-add user
//-maybe add fee??
//


//add equpiment
//rent equipment(user, equipment)4
//view list przeterminowanych wypozyczen
//list all equipment
//list available equipment

//set status of equipment as unavailable

//view currently rented by user

//generate report

