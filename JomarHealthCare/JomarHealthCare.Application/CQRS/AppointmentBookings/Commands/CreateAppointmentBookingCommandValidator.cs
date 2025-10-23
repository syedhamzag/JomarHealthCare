using FluentValidation;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Commands
{
    public class CreateAppointmentBookingCommandValidator : AbstractValidator<CreateAppointmentBookingCommand>
    {
        public CreateAppointmentBookingCommandValidator()
        {
            RuleFor(x => x.DataModel.Subject).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.Class).GreaterThan(0);
            RuleFor(x => x.DataModel.Type).GreaterThan(0);
            RuleFor(x => x.DataModel.Status).GreaterThan(0);
        }
    }

}