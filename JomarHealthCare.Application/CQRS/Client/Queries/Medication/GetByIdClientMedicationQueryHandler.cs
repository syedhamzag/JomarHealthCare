using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Medication;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Medication;


internal class GetByIdClientMedicationQueryHandler : IRequestHandler<GetByIdClientMedicationQuery, ClientMedicationDataModel>
{
    private readonly IClientMedicationRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdClientMedicationQueryHandler(IClientMedicationRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientMedicationDataModel> Handle(GetByIdClientMedicationQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientMedicationId == request.id).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new ClientMedicationDataModel();
        }

        return _mapper.Map<ClientMedicationDataModel>(entity);
    }
}
