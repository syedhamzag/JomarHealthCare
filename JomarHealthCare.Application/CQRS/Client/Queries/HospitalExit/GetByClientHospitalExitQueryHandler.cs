using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalExit;


internal class GetByClientHospitalExitQueryHandler : IRequestHandler<GetByClientHospitalExitQuery, List<HospitalExitDataModel>>
{
    private readonly IHospitalExitRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientHospitalExitQueryHandler(IHospitalExitRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<HospitalExitDataModel>> Handle(GetByClientHospitalExitQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<HospitalExitDataModel>();

        return _mapper.Map<List<HospitalExitDataModel>>(entities);
    }
}