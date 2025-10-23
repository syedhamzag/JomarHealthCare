using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands;

public class UpdateClientCommandHandler : IRequestHandler<UpdateClientPersonalInfoCommand, ClientForUpdateDataModel>
{
    private readonly IClientRepository _clientRepository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateClientCommandHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork)
    {
        _clientRepository = clientRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ClientForUpdateDataModel> Handle(UpdateClientPersonalInfoCommand request, CancellationToken cancellationToken)
    {
        var requestData = request.DataModel;
        var client = await _clientRepository
               .Get(x => x.ClientId.ToString() == request.Id.ToString())
               .FirstOrDefaultAsync(cancellationToken);


        client.Pin = requestData.Pin;
        client.Firstname = requestData.Firstname;
        client.Middlename = requestData.Middlename;
        client.Surname = requestData.Surname;
        client.PreferredName = requestData.PreferredName;
        client.Email = requestData.Email;
        client.About = requestData.About;
        client.Hobbies = requestData.Hobbies;
        client.StartDate = requestData.StartDate;
        client.EndDate = requestData.EndDate;
        client.KeyworkerId = requestData.KeyworkerId;
        client.IdNumber = requestData.IdNumber;
        client.Gender = requestData.Gender;
        client.NumberOfCalls = requestData.NumberOfCalls;
        client.AreaCodeId = requestData.AreaCodeId;
        client.TeritoryId = requestData.TeritoryId;
        client.ServiceType = requestData.ServiceType;
        client.ProvisionVenue = requestData.ProvisionVenue;
        client.PostCode = requestData.PostCode;
        client.Rate = requestData.Rate;
        client.TeamLeaderId = requestData.TeamLeaderId;
        client.DateOfBirth = requestData.DateOfBirth;
        client.Telephone = requestData.Telephone;
        client.Language = requestData.Language;
        client.KeySafe = requestData.KeySafe;
        client.ChoiceOfStaff = requestData.ChoiceOfStaff;
        client.Capacity = requestData.Capacity;
        client.ProviderReference = requestData.ProviderReference;
        client.NumberOfStaff = requestData.NumberOfStaff;
        client.ProfileImage = requestData.ProfileImage;
        client.Address = requestData.Address;
        client.Latitude = requestData.Latitude;
        client.Longitude = requestData.Longitude;
        client.ClientManagerId = requestData.ClientManagerId;
        client.Denture = requestData.Denture;
        client.Aid = requestData.Aid;
        client.LocationDistance = requestData.LocationDistance;
        client.TimeMonitorLower = requestData.TimeMonitorLower;
        client.TimeMonitorHigher = requestData.TimeMonitorHigher;
        client.PracticalSupport = requestData.PracticalSupport;
        client.CallGap = requestData.CallGap;

        _clientRepository.Update(client);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return request.DataModel;
    }
}