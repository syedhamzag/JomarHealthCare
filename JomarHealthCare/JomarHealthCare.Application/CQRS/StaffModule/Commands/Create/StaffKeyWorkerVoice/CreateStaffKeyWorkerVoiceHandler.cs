using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffKeyWorkerVoiceHandler : IRequestHandler<CreateStaffKeyWorkerVoiceCommand, StaffKeyWorkerVoiceDataModel>
    {
        private readonly IStaffKeyWorkerVoiceRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStaffKeyWorkerVoiceHandler(IStaffKeyWorkerVoiceRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffKeyWorkerVoiceDataModel> Handle(CreateStaffKeyWorkerVoiceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffKeyWorkerVoice>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffKeyWorkerVoiceDataModel>(created);
        }
    }
}