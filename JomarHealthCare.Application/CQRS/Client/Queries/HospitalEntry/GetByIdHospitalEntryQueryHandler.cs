using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalEntry;

internal class GetByIdHospitalEntryQueryHandler : IRequestHandler<GetByIdClienHospitalEntryQuery, HospitalEntryDataModel>
{
    private readonly IClientHospitalEnteryRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdHospitalEntryQueryHandler(IClientHospitalEnteryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public async Task<HospitalEntryDataModel> Handle(GetByIdClienHospitalEntryQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new HospitalEntryDataModel();

        return _mapper.Map<HospitalEntryDataModel>(entity);
    }
}

