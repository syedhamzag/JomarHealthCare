using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Commands
{
    public class UpdateCommunicationLogHandler : IRequestHandler<UpdateCommunicationLogCommand, bool>
    {
        private readonly ICommunicationLogRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly IClientRepository _clientRepository;

        public UpdateCommunicationLogHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IClientRepository clientRepository, ICommunicationLogRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _clientRepository = clientRepository;
        }

        public async Task<bool> Handle(UpdateCommunicationLogCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<CommunicationLog>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            string reciepientName = string.Empty;
            string reciepientEmail = string.Empty;
            foreach (var external in entity.AttendeeName.Split(","))
            {

                if (external != null)
                {
                    reciepientName = external;
                    reciepientEmail = external;

                    string content = $"Dear {reciepientName},\r\n\r\nYou have been selected as an attendee with the following details:\r\n\r\nMeeting Title: {request.DataModel.MeetingTitle}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy")} {request.DataModel.Time}\r\n\r\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                    await _emailService.SendEmailAsync(reciepientEmail, "You are Attendee of MDT on Care360", content);
                }
            }
            foreach (var external in entity.ApologiesName.Split(","))
            {

                if (external != null)
                {
                    reciepientName = external;
                    reciepientEmail = external;

                    string content = $"Dear {reciepientName},\r\n\r\nYou have been selected as an apologies with the following details:\r\n\r\nMeeting Title: {request.DataModel.MeetingTitle}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy")} {request.DataModel.Time}\r\n\r\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                    await _emailService.SendEmailAsync(reciepientEmail, "You are Apologies of MDT on Care360", content);
                }
            }
            foreach (var attendeeStaff in entity.Attendee)
            {

                var staff = await _staffPersonalInfoRepository.GetByKeyAsync(attendeeStaff.AttendeesId, cancellationToken);
                if (staff == null)
                {
                    var client = await _clientRepository.GetByKeyAsync(attendeeStaff.AttendeesId, cancellationToken);
                    if (client != null)
                    {
                        reciepientName = string.Concat(client.Firstname, " ", client.Surname);
                        reciepientEmail = client.Email;
                    }
                    else
                        continue;
                }
                else
                {
                    reciepientName = string.Concat(staff.FirstName, " ", staff.LastName);
                    reciepientEmail = staff.Email;
                }
                string content = $"Dear {reciepientName},\r\n\r\nYou have been selected as an attendee with the following details:\r\n\r\nMeeting Title: {request.DataModel.MeetingTitle}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy")} {request.DataModel.Time}\r\n\r\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                await _emailService.SendEmailAsync(reciepientEmail, "You are Attendee of MDT on Care360", content);
            }
            foreach (var apologiesStaff in entity.Apologies)
            {
                var staff = await _staffPersonalInfoRepository.GetByKeyAsync(apologiesStaff.ApologiesId, cancellationToken);
                if (staff == null)
                {
                    var client = await _clientRepository.GetByKeyAsync(apologiesStaff.ApologiesId, cancellationToken);
                    if (client != null)
                    {
                        reciepientName = string.Concat(client.Firstname, " ", client.Surname);
                        reciepientEmail = client.Email;
                    }
                    else
                        continue;
                }
                else
                {
                    reciepientName = string.Concat(staff.FirstName, " ", staff.LastName);
                    reciepientEmail = staff.Email;
                }
                string content = $"Dear {reciepientName},\r\n\r\nYou have been selected as an apologies with the following details:\r\n\r\nMeeting Title: {request.DataModel.MeetingTitle}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy")} {request.DataModel.Time}\r\n\r\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                await _emailService.SendEmailAsync(reciepientEmail, "You are Apologies of MDT on Care360", content);
            }
            return true;
        }
    }
}