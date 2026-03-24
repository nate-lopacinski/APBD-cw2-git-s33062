namespace APBD_Cw2_s33062.Logic;

public class UserLogic :   IUserLogic
{
    static public User CreateStudent(String cName, String cSurname)
    {
        return(new Student(cName, cSurname));
    }

    static public User CreateEmployee(String cName, String cSurname)
    {
        return(new Employee(cName, cSurname));
    }

}