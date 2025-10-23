using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Medication;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Medication;


public class AddClientMedicationCommandHandler : IRequestHandler<CreateClientMedicationCommand, ClientMedicationDataModel>
{
    private readonly IClientMedicationRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientMedicationCommandHandler(IClientMedicationRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientMedicationDataModel> Handle(CreateClientMedicationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entity = _mapper.Map<ClientMedication>(request.DataModel); // DutyOnCall type now correctly resolved
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<ClientMedicationDataModel>(created);
        }
        catch (Exception ex)
        {

            throw;
        }

    }
}