using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.BillTo;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.BillTo;

public class AddClientBillToCommandHandler : IRequestHandler<CreateClientBillToCommand, ClientBillTo>
{
    private readonly IClientBillToRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientBillToCommandHandler(IClientBillToRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientBillTo> Handle(CreateClientBillToCommand request, CancellationToken cancellationToken)
    {
        var data = new ClientBillTo
        {
            Email = request.Email,
            BillTo = request.BillTo,
            ClientId = request.ClientId
        };

        await _repo.AddAsync(data);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientBillTo>(data);
    }
}