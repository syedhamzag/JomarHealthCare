using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Queries;

internal class GetStaffTrainingByListByIdQueryHandler : IRequestHandler<GetStaffTrainingByListByIdQuery, StaffTrainingByListDataModel>
{
    private readonly IStaffTrainingByListRepository _repository;

    public GetStaffTrainingByListByIdQueryHandler(IStaffTrainingByListRepository repository)
    {
        _repository = repository;
    }

    public async Task<StaffTrainingByListDataModel> Handle(GetStaffTrainingByListByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new StaffTrainingByListDataModel
        {
            Certificate = entity.Certificate,
            CertificateAttachment = entity.CertificateAttachment,
            ExpiredDate = entity.ExpiredDate,
            Location = entity.Location,
            StaffPersonalInfoId = entity.StaffPersonalInfoId.ToString(),
            StaffTrainingId = entity.StaffTrainingId,
            StartDate = entity.StartDate,
            Trainer = entity.Trainer,
            Training = entity.Training,
            TrainingType = entity.TrainingType,
        };
    }
}