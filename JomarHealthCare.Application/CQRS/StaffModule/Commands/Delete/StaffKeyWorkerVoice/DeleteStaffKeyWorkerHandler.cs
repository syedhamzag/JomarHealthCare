using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class DeleteStaffKeyWorkerVoiceHandler : IRequestHandler<DeleteStaffKeyWorkerVoiceCommand, bool>
    {
        private readonly IStaffKeyWorkerVoiceRepository _repo;

        public DeleteStaffKeyWorkerVoiceHandler(IStaffKeyWorkerVoiceRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteStaffKeyWorkerVoiceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get(x => x.KeyWorkerId == request.Id).FirstOrDefaultAsync();
            if (entity == null)
                throw new KeyNotFoundException("Staff KeyWorkerVoice not found");
            _repo.Delete(entity);
            return true;
        }
    }
}