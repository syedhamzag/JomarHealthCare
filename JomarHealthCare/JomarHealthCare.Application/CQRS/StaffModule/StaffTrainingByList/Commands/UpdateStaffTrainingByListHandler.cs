using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffTrainingByListHandler : IRequestHandler<UpdateStaffTrainingByListCommand, bool>
    {
        private readonly IStaffTrainingByListRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public UpdateStaffTrainingByListHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IStaffTrainingByListRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<bool> Handle(UpdateStaffTrainingByListCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffTrainingByList>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);

            //var staff = await _staffPersonalInfoRepository.GetByKeyAsync(created.StaffPersonalInfoId, cancellationToken);
            //if (staff != null)
            //{
            //    string reciepientName = string.Concat(staff.FirstName, " ", staff.LastName);
            //    string reciepientEmail = staff.Email;
            //    string content = $"Dear {reciepientName},\nTraining By List Added to your Profile:\n Training: {request.DataModel.Training}\r\n on: {request.DataModel.StartDate}.\n Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\nBest regards,\nCare360 Team";
            //    await _emailService.SendEmailAsync(reciepientEmail, "Training By List Added to your Profile", content);
            //}
            return true;
        }
    }
}