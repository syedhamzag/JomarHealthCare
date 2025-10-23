using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries.ComplainRegistor;

internal class GetByClientComplainRegisterQueryHandler : IRequestHandler<GetByClientComplainRegisterQuery, List<ComplainRegistorDataModel>>
{
    private readonly IComplainRegistorRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientComplainRegisterQueryHandler(IComplainRegistorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ComplainRegistorDataModel>> Handle(GetByClientComplainRegisterQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Include(x => x.ComplainRegistorClients.Where(x => x.ClientId == request.clientId)).Where(x => !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ComplainRegistorDataModel>();

        return _mapper.Map<List<ComplainRegistorDataModel>>(entities);
    }
}
