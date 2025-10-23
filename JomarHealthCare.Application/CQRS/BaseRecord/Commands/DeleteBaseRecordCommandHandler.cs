using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Commands;

public class DeleteBaseRecordCommandHandler : IRequestHandler<DeleteBaseRecordsCommand, bool>
{
    private readonly IBaseRecordRepository _baseRepository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteBaseRecordCommandHandler(IBaseRecordRepository baseRepository, IUnitOfWork unitOfWork)
    {
        _baseRepository = baseRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteBaseRecordsCommand request, CancellationToken cancellationToken)
    {
        var data = await _baseRepository.GetByKeyAsync(request.BaseRecordId, cancellationToken);
        if (data == null) return false;

        _baseRepository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
