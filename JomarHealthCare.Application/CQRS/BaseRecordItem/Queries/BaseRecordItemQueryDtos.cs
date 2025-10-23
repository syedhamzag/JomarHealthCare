using MediatR;
using JomarHealthCare.Application.DataModels.BaseRecordItem;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;

public record GetBaseRecordItemByIdQuery(int BaseRecordItemId) : IRequest<BaseRecordItemDataModel>;

public record GetAllBaseRecordItemQuery() : IRequest<List<BaseRecordItemDataModel>>;

public record GetAllBaseRecordItemByBaseIdQuery(int BaseRecordId) : IRequest<List<BaseRecordItemDataModel>>;

public record GetBaseRecordItemByKeyNameQuery(string keyName) : IRequest<List<BaseRecordItemDataModel>>;