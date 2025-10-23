using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffTrainingByListHandler : IRequestHandler<CreateStaffTrainingByListCommand, StaffTrainingByListDataModel>
    {
        private readonly IStaffTrainingByListRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public CreateStaffTrainingByListHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IStaffTrainingByListRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<StaffTrainingByListDataModel> Handle(CreateStaffTrainingByListCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffTrainingByList>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);

            //var staff = await _staffPersonalInfoRepository.GetByKeyAsync(created.StaffPersonalInfoId, cancellationToken);
            //if (staff != null)
            //{
            //    string reciepientName = string.Concat(staff.FirstName, " ", staff.LastName);
            //    string reciepientEmail = staff.Email;
            //    string content = $"Dear {reciepientName},\nTraining By List Added to your Profile:\n Training: {request.DataModel.Training}\r\n on: {request.DataModel.StartDate}.\n Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\nBest regards,\nCare360 Team";
            //    await _emailService.SendEmailAsync(reciepientEmail, "Training By List Added to your Profile", content);
            //}
                
            return _mapper.Map<StaffTrainingByListDataModel>(created);
        }
    }




}