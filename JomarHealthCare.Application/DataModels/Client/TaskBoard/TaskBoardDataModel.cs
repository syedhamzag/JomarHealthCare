using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Client.TaskBoard;

public class ClientTaskBoardDataModel
{
    public int TaskBoardId { get; set; }
    public string TaskName { get; set; }
    public string ClientId { get; set; }
    public string TaskImage { get; set; }
    public string Attachment { get; set; }
    public DateTime CompletionDate { get; set; }
    public string Note { get; set; }
    public int Priority { get; set; }
    public int Type { get; set; }
    public int Status { get; set; }
    public string CreatedBy { get; set; }
    public List<ClientTaskBoardAssignedToDataModel> AssignedTo { get; set; }
}
public class ClientTaskBoardAssignedToDataModel
{
    public int TaskBoardAssignedToId { get; set; }
    public Guid StaffPersonalInfoId { get; set; }
    public int TaskBoardId { get; set; }
}
