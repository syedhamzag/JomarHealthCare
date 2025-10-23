using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Reviews;

public record GetByClientReviewQuery(Guid clientId) : IRequest<ReviewDataModel>;
