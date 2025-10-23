namespace JomarHealthCare.Application.DataModels.Client.InvoiceRate;

public class ClientInvoiceRateDataModel
{
    public int Id { get; set; }
    public string ServiceType { get; set; }
    public string Period { get; set; }
    public decimal? Rate { get; set; }
    public Guid? ClientId { get; set; }
}
