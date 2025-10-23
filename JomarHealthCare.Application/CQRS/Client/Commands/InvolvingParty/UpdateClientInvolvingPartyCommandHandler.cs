using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvolvingParty;


public class UpdateClientInvolvingPartyCommandHandler : IRequestHandler<UpdateClientInvolvingPartyCommand, bool>
{
    private readonly IClientInvolvingPartyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateClientInvolvingPartyCommandHandler(IClientInvolvingPartyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateClientInvolvingPartyCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.ClientInvolvingPartyId, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        data.ClientInvolvingPartyItem = request.ClientInvolvingPartyItem;
        data.Email = request.Email;
        data.Address = request.Address;
        data.Telephone = request.Telephone;
        data.Relationship = request.Relationship;


        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}