using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvoiceRate;


public class UpdateClientInvoiceRateCommandHanlder : IRequestHandler<UpdateClientInvoiceRateCommand, bool>
{
    private readonly IClientInvoiceRateRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateClientInvoiceRateCommandHanlder(IClientInvoiceRateRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateClientInvoiceRateCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.Id, new CancellationToken());

        existing.ServiceType = request.ServiceType;
        existing.Period = request.Period;
        existing.Rate = request.Rate;

        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}