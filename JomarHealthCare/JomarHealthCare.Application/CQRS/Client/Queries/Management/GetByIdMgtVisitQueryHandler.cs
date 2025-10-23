using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Management;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Management;


internal class GetByIdMgtVisitQueryHandler : IRequestHandler<GetByIdClientMgtVisitQuery, ClientMgtVisitDataModel>
{
    private readonly IClientMgtVisitRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdMgtVisitQueryHandler(IClientMgtVisitRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public async Task<ClientMgtVisitDataModel> Handle(GetByIdClientMgtVisitQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new ClientMgtVisitDataModel();

        return _mapper.Map<ClientMgtVisitDataModel>(entity);
    }
}
