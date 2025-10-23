using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.SpecialHealthMedication;

public class AddSpecialHealthMedicationCommandHandler : IRequestHandler<CreateSpecialHealthMedicationCommand, SpecialHealthAndMedicationDataModel>
{
    private readonly IClientSpecialHealthAndMedicationRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddSpecialHealthMedicationCommandHandler(IClientSpecialHealthAndMedicationRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<SpecialHealthAndMedicationDataModel> Handle(CreateSpecialHealthMedicationCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SpecialHealthAndMedication>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<SpecialHealthAndMedicationDataModel>(created);
    }
}