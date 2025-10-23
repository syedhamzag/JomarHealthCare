using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Commands;

public class UpdateServiceTypeCommandHandler : IRequestHandler<UpdateServiceTypeCommand, bool>
{
    private readonly IServiceTypeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateServiceTypeCommandHandler(IServiceTypeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateServiceTypeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}