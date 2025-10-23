using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.Staff;

internal class GetAllUserByCompanyIdQueryHandler : IRequestHandler<GetAllUserByCompanyIdQuery, List<ApplicationUserDto>>
{
    private readonly IApplicationUserRepository _repository;

    public GetAllUserByCompanyIdQueryHandler(IApplicationUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ApplicationUserDto>> Handle(GetAllUserByCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId && x.StaffId != null).Include(s=>s.StaffPersonalInfo).ToListAsync(); // This method should return all records.

        return entities
            .Select(entity => new ApplicationUserDto
            {
                 Id = entity.Id,
                 Fullname = $"{entity.StaffPersonalInfo.FirstName} {entity.StaffPersonalInfo.MiddleName} {entity.StaffPersonalInfo.LastName}",
                 Email = entity.Email,
                 UserName = entity.UserName,
                 CompanyId = entity.CompanyId,
                 PhoneNumber = entity.StaffPersonalInfo.Telephone,
            }).ToList();
    }
}