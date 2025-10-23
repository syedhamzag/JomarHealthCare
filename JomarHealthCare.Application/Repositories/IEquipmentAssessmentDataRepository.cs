using JomarHealthCare.Application.DataModels.EquipmentAssess;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories;

public interface IEquipmentAssessmentDataRepository : IGenericRepository<EquipmentAssessmentData>
{
    Task<EquipmentDeviceDataViewModel> GetByEquipmentAssessId(int Id);
}
