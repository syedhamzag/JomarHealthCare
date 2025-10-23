using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public class UpdateTaskBoardHandler : IRequestHandler<UpdateTaskBoardCommand, bool>
    {
        private readonly IEmailService _emailService;
        private readonly IClientTaskBoardRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public UpdateTaskBoardHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IClientTaskBoardRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<bool> Handle(UpdateTaskBoardCommand request, CancellationToken cancellationToken)
        {
            var existing = await _repo.GetByKeyAsync(request.DataModel.TaskBoardId, new CancellationToken());

            // Update main fields
            _mapper.Map(request.DataModel, existing); // This will update the scalar fields

            // Handle child tasks manually
            var assignedTo = request.DataModel.AssignedTo;

            foreach (var assignStaff in assignedTo)
            {
                var existingAssignedTo = existing.AssignedTo
                    .FirstOrDefault(x => x.StaffPersonalInfoId == assignStaff.StaffPersonalInfoId);

                if (existingAssignedTo != null)
                {
                    // Update existing task
                    _mapper.Map(assignStaff, existingAssignedTo);
                }
                else
                {
                    // Add new task
                    var newTask = _mapper.Map<ClientTaskBoardAssignedTo>(assignStaff);
                    existing.AssignedTo.Add(newTask);
                }
                var staff = await _staffPersonalInfoRepository.GetByKeyAsync(assignStaff.StaffPersonalInfoId,cancellationToken);
                string content = $"Dear {string.Concat(staff.FirstName," ",staff.LastName)},\r\n\r\nA new task has been assigned to you with the following details:\r\n\r\nTask Title: {request.DataModel.TaskName}\r\nDeadline: {request.DataModel.CompletionDate.ToString("dd-MM-yyyy")}\r\n\r\nThis task will keep a history of all related activities. Kindly log in to your Care360 account to review and complete the task. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                await _emailService.SendEmailAsync(staff.Email, "New Task Assigned to You on Care360", content);
            }

            _repo.Update(existing);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}