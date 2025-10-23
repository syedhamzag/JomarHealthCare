using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Commands;


public class DeleteBaseRecordItemCommandHandler : IRequestHandler<DeleteBaseRecordItemCommand, bool>
{
    private readonly IBaseRecordItemRepository _baseRepository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteBaseRecordItemCommandHandler(IBaseRecordItemRepository baseRepository, IUnitOfWork unitOfWork)
    {
        _baseRepository = baseRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteBaseRecordItemCommand request, CancellationToken cancellationToken)
    {
        var data = await _baseRepository.GetByKeyAsync(request.BaseRecordItemId, cancellationToken);
        if (data == null) return false;

        _baseRepository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
