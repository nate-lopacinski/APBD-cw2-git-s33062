namespace APBD_Cw2_s33062;

public class Rented
{
    DateTime _date;
    DateTime PlannedReturn;
    DateTime? Return = null;
    int? ToPay = null;
    public Rented(DateTime date)
    {
        _date = date;
    }
    
}