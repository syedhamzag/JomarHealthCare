using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.DataModels.Client.ClientHobbies;
using JomarHealthCare.Application.DataModels.Client.EquipmentDevices;
using JomarHealthCare.Application.DataModels.Client.HealthCondition;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;
using System.ComponentModel.Design;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    private readonly MyCareDbContext _context;
    public ClientRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<ClientDataModel>> GetAll()
    {
        var rec = await (from client in _context.Set<Client>()
                         join staff in _context.Set<StaffPersonalInfo>()
                             on client.ClientManagerId equals staff.StaffPersonalInfoId.ToString() into staffGroup
                         from staff in staffGroup.DefaultIfEmpty()
                         select new ClientDataModel
                         {
                             ClientId = client.ClientId,
                             Firstname = client.Firstname,
                             Middlename = client.Middlename,
                             Surname = client.Surname,
                             ProfileImage = client.ProfileImage,
                             DateOfBirth = client.DateOfBirth,
                             UniqueId = client.UniqueId,
                             PreferredName = client.PreferredName,
                             ManagerName = staff != null
                                 ? staff.FirstName + " " + staff.MiddleName + " " + staff.LastName
                                 : null
                         }).ToListAsync();
        return rec;
    }

    public async Task<List<ClientDataModel>> GetAllByCompanyId(Guid companyId)
    {
        var rec = await (from client in _context.Set<Client>().Where(c => c.CompanyId == companyId)
                         join staff in _context.Set<StaffPersonalInfo>()
                             on client.ClientManagerId equals staff.StaffPersonalInfoId.ToString() into staffGroup
                         from staff in staffGroup.DefaultIfEmpty()
                         select new ClientDataModel
                         {
                             ClientId = client.ClientId,
                             Firstname = client.Firstname,
                             Middlename = client.Middlename,
                             Surname = client.Surname,
                             ProfileImage = client.ProfileImage,
                             DateOfBirth = client.DateOfBirth,
                             UniqueId = client.UniqueId,
                             PreferredName = client.PreferredName,
                             ManagerName = staff != null
                                 ? staff.FirstName + " " + staff.MiddleName + " " + staff.LastName
                                 : null
                         }).ToListAsync();
        return rec;
    }

    public async Task<ClientDetailDataModel> GetClientDetailById(Guid clientId)
    {
        var rec = await (from client in _context.Set<Client>().Include(x => x.AreaCode).Include(x => x.Territory)
                        .Include(x => x.ClientHobbies).ThenInclude(x => x.Hobbies)
                        .Include(x => x.ClientHealthCondition)
                        .Include(x => x.EquipmentAssessment)
                         join staff in _context.Set<StaffPersonalInfo>()
                             on client.ClientManagerId equals staff.StaffPersonalInfoId.ToString() into staffGroup
                         from staff in staffGroup.DefaultIfEmpty()
                         join team in _context.Set<StaffPersonalInfo>()
                             on client.TeamLeaderId equals team.StaffPersonalInfoId.ToString() into staffTeamGroup
                         from team in staffTeamGroup.DefaultIfEmpty()
                         join keywork in _context.Set<StaffPersonalInfo>()
                             on client.KeyworkerId equals keywork.StaffPersonalInfoId.ToString() into staffKeyGroup
                         from keywork in staffKeyGroup.DefaultIfEmpty()
                         select new ClientDetailDataModel
                         {
                             ClientId = client.ClientId,
                             Firstname = client.Firstname,
                             Middlename = client.Middlename,
                             Surname = client.Surname,
                             Telephone = client.Telephone,
                             Address = client.Address,
                             IdNumber = client.IdNumber,
                             CompanyId = client.CompanyId,
                             Gender = client.Gender,
                             Denture = client.Denture,
                             Aid = client.Aid,
                             StartDate = client.StartDate,
                             EndDate = client.EndDate,
                             NumberOfCalls = client.NumberOfStaff,
                             AreaCode = client.AreaCode != null ? client.AreaCode.Name : null,
                             Territory = client.Territory != null ? client.Territory.Name : null,
                             ServiceType = client.ServiceType,
                             ProviderReference = client.ProviderReference,
                             ProvisionVenue = client.ProvisionVenue,
                             PostCode = client.PostCode,
                             Rate = client.Rate,
                             Language = client.Language,
                             KeySafe = client.KeySafe,
                             ChoiceOfStaff = client.ChoiceOfStaff,
                             Capacity = client.Capacity,
                             NumberOfStaff = client.NumberOfStaff,
                             Latitude = client.Latitude,
                             Longitude = client.Longitude,
                             PracticalSupport = client.PracticalSupport,
                             CallGap = client.CallGap,
                             About = client.About,
                             ProfileImage = client.ProfileImage,
                             DateOfBirth = client.DateOfBirth,
                             UniqueId = client.UniqueId,
                             PreferredName = client.PreferredName,
                             ClientManager = staff != null
                                 ? staff.FirstName + " " + staff.MiddleName + " " + staff.LastName
                                 : null,
                             TeamLeader = team != null
                                 ? team.FirstName + " " + team.MiddleName + " " + team.LastName
                                 : null,
                             Keyworker = keywork != null
                                 ? keywork.FirstName + " " + keywork.MiddleName + " " + keywork.LastName
                                 : null,
                             ClientHobbies = client.ClientHobbies
                                 .Select(x => new ClientHobbiesDataModel
                                 {
                                     HId = x.CHId,
                                     Name = x.Hobbies.Name
                                 }).ToList(),
                             GetClientHealthCondition = client.ClientHealthCondition
                                 .Select(x=> new ClientHealthConditionDataModel
                                 {
                                     CHCId = x.CHCId,
                                     Name = x.Name,
                                     Description = x.Description,
                                     Condition = x.Condition,
                                     CausesAndTrigger = x.CausesAndTrigger,
                                     Symptoms = x.Symptoms,
                                     ClientManagingWithCondition = x.ClientManagingWithCondition,
                                     RiskToClient = x.RiskToClient,
                                     RiskToStaff = x.RiskToStaff,
                                     ActionRequiredToStaff = x.ActionRequiredToStaff,
                                     EscalationsApproach = x.EscalationsApproach,
                                     Image = x.Image,
                                 }).ToList(),
                             GetEquipmentAssessment = client.EquipmentAssessment.Select(x=> new ClientEquipmentDeviceDataModel
                             {
                                 Id = x.Id,
                                 EquipmentName = x.EquipmentName,
                                 EquipmentLocation = x.EquipmentLocation,
                                 EquipmentStatus = x.EquipmentStatus,
                                 Url = x.Url,
                                 Training = x.Training,
                                 ExpiryDate = x.ExpiryDate,
                                 HowToUse = x.HowToUse,
                                 RiskOfClient = x.RiskOfClient,
                                 RiskOfStaff = x.RiskOfStaff,
                                 Environment = x.Environment,
                                 RiskControl = x.RiskControl,
                                 Escalation = x.Escalation,
                                 Attachment = x.Attachment,
                             }).ToList()
                         }).FirstOrDefaultAsync(x => x.ClientId == clientId);
        return rec;
    }
}
