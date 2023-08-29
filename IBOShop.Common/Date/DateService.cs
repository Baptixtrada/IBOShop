namespace IBOShop.Common.Date;

public class DateService : IDateService
{
    public DateTime GetDate()
    {
        return DateTime.Now.Date;
    }
}