using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    internal class StaffMatrixQueryHandler : IRequestHandler<StaffMatrixQuery, List<StaffMatrixDataModel>>
    {
        private readonly IStaffPersonalInfoRepository _repository;

        public StaffMatrixQueryHandler(IStaffPersonalInfoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StaffMatrixDataModel>> Handle(StaffMatrixQuery request, CancellationToken cancellationToken)
        {

            var staff = await _repository.Get(s => s.CompanyId == request.key)
            .Include(s => s.Trainings).Include(s => s.StaffSpotCheck).Include(s => s.StaffAdlObs)
            .Include(s => s.StaffMedCompObs).Include(s => s.StaffKeyWorkerVoice).Include(s => s.StaffSupervisionAppraisal)
            .Include(s => s.StaffCompetenceTest).Include(s => s.StaffSurvey).Include(s => s.StaffReference)
            .Include(s => s.StaffShadowing).Include(s => s.StaffInterview).Include(s => s.StaffHealth)
            .Select(entity => new StaffMatrixDataModel
            {
                StaffPersonalInfoId = entity.StaffPersonalInfoId,
                RegistrationId = entity.RegistrationId,
                FullName = entity.FirstName + " " + entity.LastName,
                DateOfBirth = entity.DateOfBirth,
                ProfilePix = entity.ProfilePix,
                DBS = new StaffMatrixDetailDataModel
                {
                    Expiry = entity.DBSExpiryDate.ToString()
                },
                //NMC = new StaffMatrixDetailDataModel
                //{
                //    Date = DateTime.Parse(entity),
                //    Expiry = DateTime.Parse(entity.DateOfExpiry)
                //},
                DriverLicense = new StaffMatrixDetailDataModel
                {
                    Expiry = entity.DrivingLicenseExpiryDate.ToString()
                },
                //Performance = new StaffMatrixDetailDataModel
                //{
                //    Date = DateTime.Parse(s.Date),
                //    Expiry = DateTime.Parse(s.Deadline)
                //},
                //NextOfKin = new StaffMatrixDetailDataModel
                //{
                //    Date = entity,
                //},
                DateOfEmployment = new StaffMatrixDetailDataModel
                {
                    Date = entity.EmploymentDate.ToString(),
                    Expiry = entity.EndDate.ToString()
                },
                Trainings = new StaffMatrixDetailDataModel
                {
                    Date = entity.Trainings.OrderBy(s => s.StartDate).LastOrDefault().StartDate.ToString(),
                    Expiry = entity.Trainings.OrderBy(s => s.StartDate).LastOrDefault().ExpiredDate.ToString()
                },
                SpotChecks = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffSpotCheck.OrderBy(s=>s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffSpotCheck.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString(),
                },
                AdlObs = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffAdlObs.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffAdlObs.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                MedCompObs = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffMedCompObs.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffMedCompObs.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                KeyWorkerVoice =  new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffKeyWorkerVoice.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffKeyWorkerVoice.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                Supervision = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffSupervisionAppraisal.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffSupervisionAppraisal.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                Appraisal = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffSupervisionAppraisal.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffSupervisionAppraisal.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                CompetenceTest = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffCompetenceTest.OrderBy(s => s.CreatedOn).LastOrDefault().CreatedOn.ToString(),
                },
                Survey =  new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffSurvey.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffSurvey.OrderBy(s => s.Date).LastOrDefault().Deadline.ToString()
                },
                References = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffReference.OrderBy(s => s.Date).LastOrDefault().Date.ToString(),
                    Expiry = entity.StaffReference.OrderBy(s => s.Date).LastOrDefault().DateofExit
                },
                Shadowing = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffShadowing.OrderBy(s => s.CreatedOn).LastOrDefault().CreatedOn.ToString(),
                },
                Interview =  new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffInterview.OrderBy(s => s.CreatedOn).LastOrDefault().CreatedOn.ToString(),
                },
                Health = new StaffMatrixDetailDataModel
                {
                    Date = entity.StaffHealth.OrderBy(s => s.CreatedOn).LastOrDefault().CreatedOn.ToString(),
                },

            }).ToListAsync(cancellationToken);
            
            return staff;
        }
    }
}
