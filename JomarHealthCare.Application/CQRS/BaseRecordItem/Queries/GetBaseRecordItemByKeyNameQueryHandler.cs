using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.BaseRecordItem;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;


internal class GetBaseRecordItemByKeyNameQueryHandler : IRequestHandler<GetBaseRecordItemByKeyNameQuery, List<BaseRecordItemDataModel>>
{
    private readonly IBaseRecordRepository _repository;

    public GetBaseRecordItemByKeyNameQueryHandler(IBaseRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BaseRecordItemDataModel>> Handle(GetBaseRecordItemByKeyNameQuery request, CancellationToken cancellationToken)
    {
        var keyName = request.keyName.Trim();
        var baseRecordItems = await _repository.Get()
        .Where(x => x.KeyName == keyName)
        .SelectMany(x => x.BaseRecordItems)
        .Select(item => new BaseRecordItemDataModel
        {
            BaseRecordItemId = item.BaseRecordItemId,
            BaseRecordId = item.BaseRecordId,
            ValueName = item.ValueName,
            CreatedBy = item.CreatedBy
        })
        .ToListAsync(cancellationToken);

        return baseRecordItems;
    }
}