using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalEntry;


internal class GetByClientHospitalEntryQueryHandler : IRequestHandler<GetByClientHospitalEntryQuery, List<HospitalEntryDataModel>>
{
    private readonly IClientHospitalEnteryRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientHospitalEntryQueryHandler(IClientHospitalEnteryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<HospitalEntryDataModel>> Handle(GetByClientHospitalEntryQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<HospitalEntryDataModel>();

        return _mapper.Map<List<HospitalEntryDataModel>>(entities);
    }
}