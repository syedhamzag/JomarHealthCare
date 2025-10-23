using MediatR;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Commands;


internal class StaffRotaCheckInCommandHandler : IRequestHandler<StaffRotaClockInCommand, string>
{
    private readonly IStaffRotaRepository _repository;

    public StaffRotaCheckInCommandHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(StaffRotaClockInCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.ClockIn(request.data);
        return result;
    }
}