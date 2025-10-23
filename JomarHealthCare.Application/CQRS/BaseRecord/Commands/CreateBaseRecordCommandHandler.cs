using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Commands;

public class CreateBaseRecordCommandHandler : IRequestHandler<CreateBaseRecordsCommand, BaseRecordModel>
{
    private readonly IBaseRecordRepository _baseRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateBaseRecordCommandHandler(IBaseRecordRepository baseRepository, IUnitOfWork unitOfWork)
    {
        _baseRepository = baseRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<BaseRecordModel> Handle(CreateBaseRecordsCommand request, CancellationToken cancellationToken)
    {
        var data = new BaseRecordModel
        {
            KeyName = request.KeyName,
            Description = request.Description,
            CreatedBy = request.CreatedBy
        };

        await _baseRepository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}