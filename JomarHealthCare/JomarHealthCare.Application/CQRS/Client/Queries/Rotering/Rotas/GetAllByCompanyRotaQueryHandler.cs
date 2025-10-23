using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.Rotas;


internal class GetAllByCompanyRotaQueryHandler : IRequestHandler<GetAllByCompanyRotaQuery, List<RotaDataModel>>
{
    private readonly IRotaRepository _repository;
    private readonly IMapper _mapper;

    public GetAllByCompanyRotaQueryHandler(IRotaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RotaDataModel>> Handle(GetAllByCompanyRotaQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId && !x.Deleted).ToListAsync();

        return entities.Select(entity => new RotaDataModel
        {
            RotaId = entity.RotaId,
            NumberOfStaff = entity.NumberOfStaff,
            RotaName = entity.RotaName,
            Gender = entity.Gender,
            Area = entity.Area,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}