using MediatR;
using JomarHealthCare.Application.DataModels.BaseRecordItem;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;

internal class GetBaserecordItemByIdQueryHandler : IRequestHandler<GetBaseRecordItemByIdQuery, BaseRecordItemDataModel>
{
    private readonly IBaseRecordItemRepository _repository;

    public GetBaserecordItemByIdQueryHandler(IBaseRecordItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseRecordItemDataModel> Handle(GetBaseRecordItemByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.BaseRecordItemId, cancellationToken);
        return new BaseRecordItemDataModel
        {
            BaseRecordItemId = entity.BaseRecordItemId,
            BaseRecordId = entity.BaseRecordId,
            ValueName = entity.ValueName,
            CreatedBy = entity.CreatedBy
        };
    }
}