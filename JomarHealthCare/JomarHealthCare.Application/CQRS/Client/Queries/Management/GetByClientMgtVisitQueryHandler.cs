using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Management;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Management;


internal class GetByClientMgtVisitQueryHandler : IRequestHandler<GetByClientMgtVisitQuery, List<ClientMgtVisitDataModel>>
{
    private readonly IClientMgtVisitRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientMgtVisitQueryHandler(IClientMgtVisitRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientMgtVisitDataModel>> Handle(GetByClientMgtVisitQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ClientMgtVisitDataModel>();

        return _mapper.Map<List<ClientMgtVisitDataModel>>(entities);
    }
}