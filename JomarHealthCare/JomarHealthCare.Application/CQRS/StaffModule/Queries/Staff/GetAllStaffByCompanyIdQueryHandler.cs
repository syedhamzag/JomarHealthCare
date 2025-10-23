using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.Staff;

internal class GetAllStaffByCompanyIdQueryHandler : IRequestHandler<GetAllStaffByCompanyIdQuery, List<GetStaffByCompanyDataModel>>
{
    private readonly IStaffPersonalInfoRepository _repository;

    public GetAllStaffByCompanyIdQueryHandler(IStaffPersonalInfoRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetStaffByCompanyDataModel>> Handle(GetAllStaffByCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new GetStaffByCompanyDataModel
        {
            StaffPersonalInfoId = entity.StaffPersonalInfoId,
            Fullname = $"{entity.FirstName} {entity.MiddleName} {entity.LastName}",
            RegistrationId = entity.RegistrationId,
            ProfilePix = entity.ProfilePix,
            Telephone = entity.Telephone,
            StartDate = entity.StartDate,
            StaffStatus = entity.Status,
            Email = entity.Email,
            CanDrive = entity.CanDrive,
            IsAgency = entity.IsAgencyStaff,
            IsOfficeStaff = entity.IsOfficeStaff,
            IsApplicant = entity.IsApplicant,
            IsActive = entity.IsActive,
        }).ToList();
    }
}