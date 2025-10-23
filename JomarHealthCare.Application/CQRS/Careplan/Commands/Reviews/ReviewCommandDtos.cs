using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Reviews;

public record CreateReviewCommand(ReviewDataModel DataModel) : IRequest<ReviewDataModel>;
public record UpdateReviewCommand(ReviewDataModel DataModel) : IRequest<bool>;