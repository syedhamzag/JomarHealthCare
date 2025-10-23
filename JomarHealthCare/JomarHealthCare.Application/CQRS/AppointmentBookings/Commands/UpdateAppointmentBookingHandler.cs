using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Commands
{
    public class UpdateAppointmentBookingHandler : IRequestHandler<UpdateAppointmentBookingCommand, bool>
    {
        private readonly IAppointmentBookingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly IClientRepository _clientRepository;

        public UpdateAppointmentBookingHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IClientRepository clientRepository, IAppointmentBookingRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _clientRepository = clientRepository;
        }

        public async Task<bool> Handle(UpdateAppointmentBookingCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<AppointmentBooking>(request.DataModel);
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

                    string content = $"Dear {reciepientName},\nYou have been selected as an attendee with the following details:\nMeeting Title: {request.DataModel.Subject}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy hh:mm:ss")}\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\nBest regards,\nCare360 Team";
                    await _emailService.SendEmailAsync(reciepientEmail, "You are Attendee of MDT on Care360", content);
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
                string content = $"Dear {reciepientName},\nYou have been selected as an attendee with the following details:\nMeeting Title: {request.DataModel.Subject}\r\n on: {request.DataModel.Date.ToString("dd-MM-yyyy hh:mm:ss")}\n. Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\nBest regards,\nCare360 Team";
                await _emailService.SendEmailAsync(reciepientEmail, "You are Attendee of MDT on Care360", content);
            }
            return true;
        }
    }
}