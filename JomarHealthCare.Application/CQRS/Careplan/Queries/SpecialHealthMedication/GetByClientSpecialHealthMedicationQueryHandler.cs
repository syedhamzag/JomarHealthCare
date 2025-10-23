using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.SpecialHealthMedication;

internal class GetByClientSpecialHealthMedicationQueryHandler : IRequestHandler<GetByClientSpecialHealthMedicationQuery, SpecialHealthAndMedicationDataModel>
{
    private readonly IClientSpecialHealthAndMedicationRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientSpecialHealthMedicationQueryHandler(IClientSpecialHealthAndMedicationRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SpecialHealthAndMedicationDataModel> Handle(GetByClientSpecialHealthMedicationQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new SpecialHealthAndMedicationDataModel();
        }

        return _mapper.Map<SpecialHealthAndMedicationDataModel>(entity);
    }
}
