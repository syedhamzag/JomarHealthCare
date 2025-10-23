using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Hobby.Commands;
public class UpdateHobbyCommandHandler : IRequestHandler<UpdateHobbyCommand, bool>
{
    private readonly IHobbyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateHobbyCommandHandler(IHobbyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateHobbyCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.HId, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        data.Description = request.Description;

        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}