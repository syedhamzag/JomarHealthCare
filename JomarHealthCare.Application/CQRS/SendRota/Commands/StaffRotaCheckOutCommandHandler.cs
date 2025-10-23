using MediatR;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Commands;


internal class StaffRotaCheckOutCommandHandler : IRequestHandler<StaffRotaClockOutCommand, string>
{
    private readonly IStaffRotaRepository _repository;

    public StaffRotaCheckOutCommandHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(StaffRotaClockOutCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.ClockOut(request.data);
        return result;
    }
}
