using MediatR;
using JomarHealthCare.Application.CQRS.Client.Commands.Voice;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Commands.ComplainRegister;

public class DeleteComplainRegisterCommandHandler : IRequestHandler<DeleteComplainRegisterCommand, bool>
{
    private readonly IComplainRegistorRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteComplainRegisterCommandHandler(IComplainRegistorRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteComplainRegisterCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
