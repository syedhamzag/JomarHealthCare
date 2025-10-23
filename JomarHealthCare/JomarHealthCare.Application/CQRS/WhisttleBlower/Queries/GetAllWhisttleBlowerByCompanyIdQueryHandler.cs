using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Queries;


internal class GetAllWhisttleBlowerByCompanyIdQueryHandler : IRequestHandler<GetAllWhisttleBlowerByIdQuery, List<WhisttleBlowerDataModel>>
{
    private readonly IWhisttleBlowerRepository _repository;

    public GetAllWhisttleBlowerByCompanyIdQueryHandler(IWhisttleBlowerRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<WhisttleBlowerDataModel>> Handle(GetAllWhisttleBlowerByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.id).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new WhisttleBlowerDataModel
        {
            ActionTaken = entity.ActionTaken,
            CandourAction = entity.CandourAction,
            ClientName = entity.ClientName,
            CreatedBy = entity.CreatedBy,
            Happening = entity.Happening,
            Image = entity.Image,
            IncidentDate = entity.IncidentDate,
            IncidentType = entity.IncidentType,
            IsThereWitness = entity.IsThereWitness,
            NameOfHandlingPerson = entity.NameOfHandlingPerson,
            NameOfHandlingPersonTel = entity.NameOfHandlingPersonTel,
            PersonReportingName = entity.PersonReportingName,
            PhoneNo = entity.PhoneNo,
            ReferenceNumber = entity.ReferenceNumber,
            Status = entity.Status,
            WhisttleBlowerId = entity.WhisttleBlowerId,
            WitnessDetail = entity.WitnessDetail,
            LikeCalling = entity.LikeCalling,
            CompanyId = entity.CompanyId.ToString()
        }).ToList();
    }
}