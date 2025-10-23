using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ExternalUser;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Queries;


internal class GetAllExternalRoleAccessByCompanyIdQueryHandler : IRequestHandler<GetAllExternalRoleAccessByIdQuery, List<ExternalRoleAccessDataModel>>
{
    private readonly IExternalRoleAccessRepository _repository;
    private readonly IClientRepository _clientRepository;
    private readonly IStaffPersonalInfoRepository _personalInfoRepository;
    private readonly IExternalRoleRepository _externalRoleRepository;
    public GetAllExternalRoleAccessByCompanyIdQueryHandler(IExternalRoleAccessRepository repository, IClientRepository clientRepository,
        IStaffPersonalInfoRepository personalInfoRepository, IExternalRoleRepository externalRoleRepository)
    {
        _repository = repository;
        _clientRepository = clientRepository;
        _personalInfoRepository = personalInfoRepository;
        _externalRoleRepository = externalRoleRepository;

    }

    public async Task<List<ExternalRoleAccessDataModel>> Handle(GetAllExternalRoleAccessByIdQuery request, CancellationToken cancellationToken)
    {
        var externalRoleAccess = new List<ExternalRoleAccessDataModel>();
        var entities = await _repository.Get().Where(x => x.CreatedBy == request.id.ToString()).Include(s => s.Staff)
            .Include(s=>s.Client).ToListAsync(cancellationToken); // This method should return all records.
        foreach (var entity in entities)
        {
            var clients = await _clientRepository.Get().Where(s => s.CompanyId == Guid.Parse(entity.CreatedBy)).ToListAsync(cancellationToken);
            var staffs = await _personalInfoRepository.Get().Where(s => s.CompanyId == Guid.Parse(entity.CreatedBy)).ToListAsync(cancellationToken);
            var external = await _externalRoleRepository.Get().Where(s => s.ExternalId == entity.ExternalId).FirstOrDefaultAsync(cancellationToken);
            externalRoleAccess.Add(new ExternalRoleAccessDataModel
            {
                ExternalAccessId = entity.ExternalAccessId,
                CreatedBy = entity.CreatedBy,
                ExternalId = entity.ExternalId,
                ExternalName = external.FirstName + " " + external.LastName,
                Client = entity.Client.Select(client => new ExternalRoleAccessClientDataModel
                {
                        ExternalRoleAccessClientId = client.ExternalRoleAccessClientId,
                        ExternalAccessId = client.ExternalAccessId,
                        ClientId = client.ClientId.ToString(),
                        ClientName = clients.Where(x => x.ClientId == Guid.Parse(client.ClientId.ToString())).FirstOrDefault().Firstname + " " + clients.Where(x => x.ClientId == Guid.Parse(client.ClientId.ToString())).FirstOrDefault().Surname ?? ""
                }).ToList(),
                Staff = entity.Staff.Select(staff => new ExternalRoleAccessStaffDataModel
                {
                    ExternalRoleAccessStaffId = staff.ExternalRoleAccessStaffId,
                    ExternalAccessId = staff.ExternalAccessId,
                    StaffPersonalInfoId = staff.StaffPersonalInfoId.ToString(),
                    StaffName = staffs.Where(x => x.StaffPersonalInfoId == Guid.Parse(staff.StaffPersonalInfoId.ToString())).FirstOrDefault().FirstName + " " + staffs.Where(x => x.StaffPersonalInfoId == Guid.Parse(staff.StaffPersonalInfoId.ToString())).FirstOrDefault().LastName ?? ""
                }).ToList(),
            });
        }
        return externalRoleAccess;
    }
}