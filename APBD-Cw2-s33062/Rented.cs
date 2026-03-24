namespace APBD_Cw2_s33062;

public class Rented(User person,DateTime date,DateTime plannedReturn)
{    
    private User Person { get; set; } = person;
    DateTime Date{ get; set; }=date;
    private DateTime PlannedReturn { get; set; } = plannedReturn;
    DateTime? Return { get; set; } = null;
    
    List<Fee> Fees = new List<Fee>();
}

public class Fee()
{
    bool paid = false;
    private DateTime? paidDate = null;

}