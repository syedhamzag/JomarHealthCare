using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvoiceRate;

public class AddClientInvoiceRateCommandHanlder : IRequestHandler<CreateClientInvoiceRateCommand, ClientInvoiceRate>
{
    private readonly IClientInvoiceRateRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientInvoiceRateCommandHanlder(IClientInvoiceRateRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientInvoiceRate> Handle(CreateClientInvoiceRateCommand request, CancellationToken cancellationToken)
    {
        var data = new ClientInvoiceRate
        {
            ServiceType = request.ServiceType,
            Period = request.Period,
            Rate = request.Rate,
            ClientId = request.ClientId
        };

        await _repo.AddAsync(data);
        await _uow.SaveChangesAsync(cancellationToken);
        return data;
    }
}