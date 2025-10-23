using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.DataModels.EquipmentAssess;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories;

internal class EquipmentAssessmentDataRepository : GenericRepository<EquipmentAssessmentData>, IEquipmentAssessmentDataRepository
{
    private readonly MyCareDbContext _context;
    public EquipmentAssessmentDataRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(dbContext)
    {
        _context = context;
    }

    public async Task<EquipmentDeviceDataViewModel> GetByEquipmentAssessId(int Id)
    {
        var data = await _context.Set<EquipmentAssessmentData>()
            .Where(e => e.EquipmentAssessmentId == Id)
            .Select(e => new EquipmentDeviceDataViewModel
            {
                Id = e.Id,
                EquipmentAssessmentId = e.EquipmentAssessmentId,
                URL = e.URL,
                HowToUse = e.HowToUse,
                ClientRisk = e.ClientRisk,
                StaffRisk = e.StaffRisk,
                Image = e.Image
            })
            .FirstOrDefaultAsync();
        return data ?? new EquipmentDeviceDataViewModel();
    }
}
