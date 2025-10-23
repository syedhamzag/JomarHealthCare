using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.BaseRecordItem;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;


internal class GetAllBaseRecordItemByBaseIdQueryHandler : IRequestHandler<GetAllBaseRecordItemByBaseIdQuery, List<BaseRecordItemDataModel>>
{
    private readonly IBaseRecordItemRepository _repository;

    public GetAllBaseRecordItemByBaseIdQueryHandler(IBaseRecordItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BaseRecordItemDataModel>> Handle(GetAllBaseRecordItemByBaseIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.BaseRecordId == request.BaseRecordId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new BaseRecordItemDataModel
        {
            BaseRecordItemId = entity.BaseRecordItemId,
            BaseRecordId = entity.BaseRecordId,
            ValueName = entity.ValueName,
            CreatedBy = entity.CreatedBy
        }).ToList();
    }
}