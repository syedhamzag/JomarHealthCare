using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaType;


internal class GetByIdRotaTypeQueryHandler : IRequestHandler<GetByIdRotaTypeQuery, ClientRotaTypeDataModel>
{
    private readonly IClientRotaTypeRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdRotaTypeQueryHandler(IClientRotaTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientRotaTypeDataModel> Handle(GetByIdRotaTypeQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().FirstOrDefaultAsync(x => x.ClientRotaTypeId == request.id);
        if (entity == null)
        {
            return new ClientRotaTypeDataModel();
        }
        return new ClientRotaTypeDataModel
        {
            ClientRotaTypeId = entity.ClientRotaTypeId,
            RotaType = entity.RotaType,
            CompanyId = entity.CompanyId,
        };
    }
}