using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateInterviewQuestionHandler : IRequestHandler<UpdateInterviewQuestionCommand, bool>
    {
        private readonly IInterviewQuestionRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateInterviewQuestionHandler(IInterviewQuestionRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateInterviewQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<InterviewQuestion>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }

}
