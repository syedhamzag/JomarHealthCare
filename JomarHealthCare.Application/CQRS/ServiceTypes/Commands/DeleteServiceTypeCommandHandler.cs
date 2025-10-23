using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Commands;


public class DeleteServiceTypeCommandHandler : IRequestHandler<DeleteServiceTypeCommand, bool>
{
    private readonly IServiceTypeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteServiceTypeCommandHandler(IServiceTypeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteServiceTypeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
