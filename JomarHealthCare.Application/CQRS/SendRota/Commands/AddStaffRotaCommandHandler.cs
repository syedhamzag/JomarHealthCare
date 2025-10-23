using MediatR;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Commands;


internal class AddStaffRotaCommandHandler : IRequestHandler<CreateStaffRotaCommand, string>
{
    private readonly IStaffRotaRepository _repository;

    public AddStaffRotaCommandHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(CreateStaffRotaCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.CreateStaffRota(request.data);
        return result;
    }
}