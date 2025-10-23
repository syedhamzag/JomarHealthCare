namespace JomarHealthCare.Application.DataModels.Client.BillTo;

public class ClientBillToDataModel
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string BillTo { get; set; }

    public Guid? ClientId { get; set; }
}
