using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateInterviewQuestionHandler : IRequestHandler<CreateInterviewQuestionCommand, InterviewQuestionDataModel>
    {
        private readonly IInterviewQuestionRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateInterviewQuestionHandler(IInterviewQuestionRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<InterviewQuestionDataModel> Handle(CreateInterviewQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<InterviewQuestion>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<InterviewQuestionDataModel>(result);
        }
    }

}
