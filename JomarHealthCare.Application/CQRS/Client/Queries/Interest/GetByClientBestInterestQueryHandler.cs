using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.BestInterest;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Interest;


internal class GetByClientBestInterestQueryHandler : IRequestHandler<GetByClientBestInterestQuery, BestInterestDataModel>
{
    private readonly IClientBestInterestRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientBestInterestQueryHandler(IClientBestInterestRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BestInterestDataModel> Handle(GetByClientBestInterestQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new BestInterestDataModel();
        }

        return _mapper.Map<BestInterestDataModel>(entity);
    }
}