using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Commands;

public class UpdateBaseRecordCommandHandler : IRequestHandler<UpdateBaseRecordsCommand, bool>
{
    private readonly IBaseRecordRepository _baseRepository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateBaseRecordCommandHandler(IBaseRecordRepository baseRepository, IUnitOfWork unitOfWork)
    {
        _baseRepository = baseRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateBaseRecordsCommand request, CancellationToken cancellationToken)
    {
        var data = await _baseRepository.GetByKeyAsync(request.BaseRecordId, cancellationToken);
        if (data == null) return false;

        data.KeyName = request.KeyName;
        data.Description = request.Description;

        _baseRepository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}