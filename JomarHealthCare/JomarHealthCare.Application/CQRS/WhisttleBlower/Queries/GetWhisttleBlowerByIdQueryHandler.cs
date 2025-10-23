using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Queries;

internal class GetWhisttleBlowerByIdQueryHandler : IRequestHandler<GetWhisttleBlowerByIdQuery, WhisttleBlowerDataModel>
{
    private readonly IWhisttleBlowerRepository _repository;

    public GetWhisttleBlowerByIdQueryHandler(IWhisttleBlowerRepository repository)
    {
        _repository = repository;
    }

    public async Task<WhisttleBlowerDataModel> Handle(GetWhisttleBlowerByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.WhisttleBlowerId == request.id).FirstOrDefaultAsync(cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new WhisttleBlowerDataModel
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
        };
    }
}