using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientHobbies;


public class DeleteClientHobbiesCommandHandler : IRequestHandler<DeleteClientHobbiesCommand, bool>
{
    private readonly IClientHobbiesRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientHobbiesCommandHandler(IClientHobbiesRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteClientHobbiesCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
