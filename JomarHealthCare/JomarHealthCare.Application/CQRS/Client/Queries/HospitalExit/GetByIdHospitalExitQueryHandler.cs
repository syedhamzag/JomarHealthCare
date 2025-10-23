using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HospitalExit;


internal class GetByIdHospitalExitQueryHandler : IRequestHandler<GetByIdClienHospitalExitQuery, HospitalExitDataModel>
{
    private readonly IHospitalExitRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdHospitalExitQueryHandler(IHospitalExitRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<HospitalExitDataModel> Handle(GetByIdClienHospitalExitQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new HospitalExitDataModel();

        return _mapper.Map<HospitalExitDataModel>(entity);
    }
}