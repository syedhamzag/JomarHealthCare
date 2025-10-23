using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.BaseRecordItem;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;
internal class GetAllBaseRecordItemQueryHandler : IRequestHandler<GetAllBaseRecordItemQuery, List<BaseRecordItemDataModel>>
{
    private readonly IBaseRecordItemRepository _repository;

    public GetAllBaseRecordItemQueryHandler(IBaseRecordItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BaseRecordItemDataModel>> Handle(GetAllBaseRecordItemQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.
        if (entities == null || entities.Count < 0)
        {
            return new List<BaseRecordItemDataModel>();
        }
        return entities.Select(entity => new BaseRecordItemDataModel
        {
            BaseRecordItemId = entity.BaseRecordItemId,
            BaseRecordId = entity.BaseRecordId,
            ValueName = entity.ValueName,
            CreatedBy = entity.CreatedBy
        }).ToList();
    }
}