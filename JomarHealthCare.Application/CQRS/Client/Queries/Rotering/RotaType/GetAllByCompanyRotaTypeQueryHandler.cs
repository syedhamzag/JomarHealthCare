using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaTasks;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaType;

internal class GetAllByCompanyRotaTypeQueryHandler : IRequestHandler<GetAllByCompanyIdRotaTypeQuery, List<ClientRotaTypeDataModel>>
{
    private readonly IClientRotaTypeRepository _repository;
    private readonly IMapper _mapper;

    public GetAllByCompanyRotaTypeQueryHandler(IClientRotaTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientRotaTypeDataModel>> Handle(GetAllByCompanyIdRotaTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId && !x.Deleted).ToListAsync();

        return entities.Select(entity => new ClientRotaTypeDataModel
        {
            ClientRotaTypeId = entity.ClientRotaTypeId,
            RotaType = entity.RotaType,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}