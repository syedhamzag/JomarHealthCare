using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.BillTo;
public class UpdateClientBillToCommandHandler : IRequestHandler<UpdateClientBillToCommand, bool>
{
    private readonly IClientBillToRepository _repo;
    private readonly IUnitOfWork _uow;

    public UpdateClientBillToCommandHandler(IClientBillToRepository repo, IUnitOfWork uow)
    {
        _repo = repo;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateClientBillToCommand request, CancellationToken cancellationToken)
    {
        var data = await _repo.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Email = request.Email;
        data.BillTo = request.BillTo;

        _repo.Update(data);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}