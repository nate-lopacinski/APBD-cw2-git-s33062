namespace APBD_Cw2_s33062.Logic;

public interface IUserLogic
{
    static abstract public User CreateStudent(String cName, String cSurname);
    static abstract User CreateEmployee(String cName, String cSurname);
}