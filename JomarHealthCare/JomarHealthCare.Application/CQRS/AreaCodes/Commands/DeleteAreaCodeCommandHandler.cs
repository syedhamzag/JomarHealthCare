using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Commands;


public class DeleteAreaCodeCommandHandler : IRequestHandler<DeleteAreaCodeCommand, bool>
{
    private readonly IAreaCodeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteAreaCodeCommandHandler(IAreaCodeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteAreaCodeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
