using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public class CreateTaskBoardHandler : IRequestHandler<CreateTaskBoardCommand, ClientTaskBoardDataModel>
    {
        private readonly IClientTaskBoardRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public CreateTaskBoardHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IClientTaskBoardRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<ClientTaskBoardDataModel> Handle(CreateTaskBoardCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ClientTaskBoard>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            foreach (var assignStaff in created.AssignedTo)
            {
                var staff = await _staffPersonalInfoRepository.GetByKeyAsync(assignStaff.StaffPersonalInfoId, cancellationToken);
                string content = $"Dear {string.Concat(staff.FirstName, " ", staff.LastName)},\r\n\r\nA new task has been assigned to you with the following details:\r\n\r\nTask Title: {request.DataModel.TaskName}\r\nDeadline: {request.DataModel.CompletionDate.ToString("dd-MM-yyyy")}\r\n\r\nThis task will keep a history of all related activities. Kindly log in to your Care360 account to review and complete the task. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                await _emailService.SendEmailAsync(staff.Email, "New Task Assigned to You on Care360", content);
            }
            return _mapper.Map<ClientTaskBoardDataModel>(created);
        }
    }




}