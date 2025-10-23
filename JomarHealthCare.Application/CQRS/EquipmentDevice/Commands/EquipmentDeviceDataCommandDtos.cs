using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Commands;

public class AddEquipmentDeviceDataCommand : IRequest<EquipmentAssessmentData>
{
    public int EquipmentAssessmentId { get; set; }
    public string URL { get; set; }
    public string HowToUse { get; set; }
    public string ClientRisk { get; set; }
    public string StaffRisk { get; set; }
    public string Image { get; set; }
}

public class DeleteEquipmentDeviceDataCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateEquipmentDeviceDataCommand : IRequest<bool>
{
    public int Id { get; set; }
    public int EquipmentAssessmentId { get; set; }
    public string URL { get; set; }
    public string HowToUse { get; set; }
    public string ClientRisk { get; set; }
    public string StaffRisk { get; set; }
    public string Image { get; set; }
}
