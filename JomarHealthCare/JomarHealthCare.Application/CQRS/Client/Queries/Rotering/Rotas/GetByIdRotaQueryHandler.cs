using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.Rotas;


internal class GetByIdRotaQueryHandler : IRequestHandler<GetByIdRotaQuery, RotaDataModel>
{
    private readonly IRotaRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdRotaQueryHandler(IRotaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RotaDataModel> Handle(GetByIdRotaQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().FirstOrDefaultAsync(x => x.RotaId == request.id);
        if (entity == null)
        {
            return new RotaDataModel();
        }
        return new RotaDataModel
        {
            RotaId = entity.RotaId,
            NumberOfStaff = entity.NumberOfStaff,
            RotaName = entity.RotaName,
            Gender = entity.Gender,
            Area = entity.Area,
            CompanyId = entity.CompanyId,
        };
    }
}