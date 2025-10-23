using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries.ComplainRegistor;

internal class GetByCompanyComplainRegisterQueryHandler : IRequestHandler<GetByCompanyComplainRegisterQuery, List<ComplainRegistorDataModel>>
{
    private readonly IComplainRegistorRepository _repository;
    private readonly IMapper _mapper;

    public GetByCompanyComplainRegisterQueryHandler(IComplainRegistorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ComplainRegistorDataModel>> Handle(GetByCompanyComplainRegisterQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Include(x => x.ComplainRegistorClients).Include(x => x.ComplainRegistorStaff).Where(x => x.CompanyId == request.companyId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ComplainRegistorDataModel>();

        return _mapper.Map<List<ComplainRegistorDataModel>>(entities);
    }
}
