using APBD_Cw2_s33062.Logic;

namespace APBD_Cw2_s33062;

public class ParseCommend1


{
    
static void ParseCommend(List<String> args)
{

    switch (args[0])
    {
        case "add":
            switch (args[1])
            {
                case "student":
                    UserLogic.CreateStudent(args[2], args[3]);
                    break;
                case "employee":
                    UserLogic.CreateEmployee(args[2], args[3]);
                    break;
                default:
                    throw new NonExistentTypeException();
                    break;
            }
            break;
        case "new":
            switch (args[1])
            {
                case "laptop":
                    RentingLogic.AddLaptop();
                    break;
                default:
                    throw new NonExistentTypeException();
            }
            break;
        case "rent":
            break;
    }
}

}