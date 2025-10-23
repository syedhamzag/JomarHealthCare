using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Hobby.Commands;

public class DeleteHobbyCommandHandler : IRequestHandler<DeleteHobbyCommand, bool>
{
    private readonly IHobbyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteHobbyCommandHandler(IHobbyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteHobbyCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.HobbyId, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
