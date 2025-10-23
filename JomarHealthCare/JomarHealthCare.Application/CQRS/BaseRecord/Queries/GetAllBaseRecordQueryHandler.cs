using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.BaseRecord;
using JomarHealthCare.Application.DataModels.BaseRecordItem;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Queries;

internal class GetAllBaseRecordQueryHandler : IRequestHandler<GetAllBaseRecordQuery, List<BaseRecordDataModel>>
{
    private readonly IBaseRecordRepository _repository;

    public GetAllBaseRecordQueryHandler(IBaseRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BaseRecordDataModel>> Handle(GetAllBaseRecordQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Include(x => x.BaseRecordItems).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new BaseRecordDataModel
        {
            BaseRecordId = entity.BaseRecordId,
            KeyName = entity.KeyName,
            Description = entity.Description,
            CreatedBy = entity.CreatedBy,
            BaseRecordItems = entity.BaseRecordItems.Select(item => new BaseRecordItemDataModel
            {
                BaseRecordItemId = item.BaseRecordItemId,
                BaseRecordId = item.BaseRecordId,
                ValueName = item.ValueName,
                CreatedBy = item.CreatedBy
            }).ToList()
        }).ToList();
    }
}
