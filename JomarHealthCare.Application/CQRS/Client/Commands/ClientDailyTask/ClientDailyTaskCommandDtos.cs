using MediatR;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientDailyTask;
public class AddClientDailyTaskCommand : IRequest<Domain.Entities.ClientDailyTask>
{
    public string DailyTaskName { get; set; }
    public string HowToPerformTask { get; set; }
    public DateTime Date { get; set; }
    public DateTime AmendmentDate { get; set; }
    public Guid? ClientId { get; set; }
    public string Image { get; set; }
    public string Video { get; set; }
}


public class DeleteClientDailyTaskCommand : IRequest<bool>
{
    public int DailyTaskId { get; set; }
}

public class UpdateClientDailyTaskCommand : IRequest<bool>
{
    public int DailyTaskId { get; set; }
    public string DailyTaskName { get; set; }
    public string HowToPerformTask { get; set; }
    public DateTime Date { get; set; }
    public DateTime AmendmentDate { get; set; }
    public Guid? ClientId { get; set; }
    public string Image { get; set; }
    public string Video { get; set; }
}
