using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Balance;

public record CreateBalanceCommand(List<BalanceDataModel> DataModel) : IRequest<List<BalanceDataModel>>;
public record UpdateBalanceCommand(BalanceDataModel DataModel) : IRequest<bool>;

public class DeleteBalanceCommand : IRequest<bool>
{
    public int Id { get; set; }
}