using MediatR;
using JomarHealthCare.Application.DataModels.BaseRecord;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Queries;


internal class GetBaseRecordByIdQueryHandler : IRequestHandler<GetBaseRecordByIdQuery, BaseRecordDataModel>
{
    private readonly IBaseRecordRepository _repository;

    public GetBaseRecordByIdQueryHandler(IBaseRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseRecordDataModel> Handle(GetBaseRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.BaseRecordId, cancellationToken);
        return new BaseRecordDataModel
        {
            BaseRecordId = entity.BaseRecordId,
            KeyName = entity.KeyName,
            Description = entity.Description
        };
    }
}