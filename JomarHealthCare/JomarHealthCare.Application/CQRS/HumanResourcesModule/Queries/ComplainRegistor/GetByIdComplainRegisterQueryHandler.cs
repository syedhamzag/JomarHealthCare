using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries.ComplainRegistor;

internal class GetByIdComplainRegisterQueryHandler : IRequestHandler<GetByIdComplainRegisterQuery, ComplainRegistorDataModel>
{
    private readonly IComplainRegistorRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdComplainRegisterQueryHandler(IComplainRegistorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public async Task<ComplainRegistorDataModel> Handle(GetByIdComplainRegisterQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new ComplainRegistorDataModel();

        return _mapper.Map<ComplainRegistorDataModel>(entity);
    }
}
