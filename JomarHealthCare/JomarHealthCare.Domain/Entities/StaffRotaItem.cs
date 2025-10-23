namespace JomarHealthCare.Domain.Entities;

/// <summary>
/// Dynamic items for Staff Rota
/// </summary>
public class StaffRotaItem
{
    public int StaffRotaItemId { get; set; }
    public int StaffRotaId { get; set; }
    public int StaffRotaDynamicAdditionId { get; set; }
    public virtual StaffRota StaffRota { get; set; }
}
