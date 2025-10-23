using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffKeyWorkerVoiceHandler : IRequestHandler<UpdateStaffKeyWorkerVoiceCommand, bool>
    {
        private readonly IStaffKeyWorkerVoiceRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStaffKeyWorkerVoiceHandler(IStaffKeyWorkerVoiceRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStaffKeyWorkerVoiceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffKeyWorkerVoice>(request.DataModel);
            _repo.Update(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}