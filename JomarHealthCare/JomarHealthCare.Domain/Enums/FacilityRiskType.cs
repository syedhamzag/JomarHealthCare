using System.ComponentModel;

namespace JomarHealthCare.Domain.Enums;

public enum FacilityRiskType
{
    [Description("Access Risk")]
    AccessRisk = 0,
    [Description("Fire Risk")]
    FireRisk = 1,
    [Description("Moving and Handling")]
    MovingAndHandling = 2,
    [Description("Equipment and Tool")]
    EquipmentAndTool = 3,
    [Description("Hazard/COSHH Risk")]
    HazardRisk = 4,
    [Description("Tools Risk")]
    ToolsRisk = 5,
    [Description("Loan Working Risk")]
    LoonWorkingRisk = 6,
    [Description("Height Risk")]
    HeightRisk = 7,
    [Description("Document Control Risk")]
    DocumentControlRisk = 8,
    [Description("Waste Risk")]
    WasteRisk = 9
}
