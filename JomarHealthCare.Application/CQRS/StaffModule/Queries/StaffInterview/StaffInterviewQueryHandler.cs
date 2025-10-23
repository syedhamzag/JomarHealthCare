using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffInterviewQueryHandler : IRequestHandler<StaffInterviewQuery, IQueryable<StaffInterview>>
    {
        private readonly IStaffInterviewRepository _repository;

        public StaffInterviewQueryHandler(IStaffInterviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffInterview>> Handle(StaffInterviewQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffPersonalInfoId.ToString().Trim() == key.ToString().Trim()).Select(s => new StaffInterview
                {
                    ClientSignature = s.ClientSignature,
                    Comment = s.Comment,
                    Heading = s.Heading,
                    InterviewDate = s.InterviewDate,
                    JobPosition = s.JobPosition,
                    ManagerSignature = s.ManagerSignature,
                    StaffSignature = s.StaffSignature,
                    ObtainMarks = s.ObtainMarks,
                    PassingMarks = s.PassingMarks,
                    Status = s.Status,
                    StaffPersonalInfoId = s.StaffPersonalInfoId,
                    StaffInterviewId = s.StaffInterviewId,
                    StaffInterviewTask = s.StaffInterviewTask.Select(task => new StaffInterviewTask
                    {
                        Answer = task.Answer,
                        Comment = task.Comment,
                        Point = task.Point,
                        Score = task.Score,
                        StaffInterviewTaskId = task.StaffInterviewTaskId,
                        Title = task.Title
                        
                    }).ToList()
                });
            }
            return _repository.Get();
        }
    }
}