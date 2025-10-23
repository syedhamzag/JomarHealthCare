using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvoiceRate;


public class CreateClientInvoiceRateCommand : IRequest<ClientInvoiceRate>
{
    public string ServiceType { get; set; }
    public string Period { get; set; }
    public decimal? Rate { get; set; }
    public Guid? ClientId { get; set; }
}
public class UpdateClientInvoiceRateCommand() : IRequest<bool>
{
    public int Id { get; set; }
    public string ServiceType { get; set; }
    public string Period { get; set; }
    public decimal? Rate { get; set; }
    public Guid? ClientId { get; set; }
}

public class DeleteClientInvoiceRateCommand : IRequest<bool>
{
    public int Id { get; set; }
}