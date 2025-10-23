using MediatR;
using JomarHealthCare.Application.DataModels.BaseRecord;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Queries;

public record GetBaseRecordByIdQuery(Guid BaseRecordId) : IRequest<BaseRecordDataModel>;

public record GetAllBaseRecordQuery() : IRequest<List<BaseRecordDataModel>>;