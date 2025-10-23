using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Queries;


internal class GetAllStaffTrainingByListByStaffIdQueryHandler : IRequestHandler<GetAllStaffTrainingByListByIdQuery, List<StaffTrainingByListDataModel>>
{
    private readonly IStaffTrainingByListRepository _repository;

    public GetAllStaffTrainingByListByStaffIdQueryHandler(IStaffTrainingByListRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<StaffTrainingByListDataModel>> Handle(GetAllStaffTrainingByListByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.StaffPersonalInfoId == request.StaffPersonalInfoId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new StaffTrainingByListDataModel
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
        }).ToList();
    }
}