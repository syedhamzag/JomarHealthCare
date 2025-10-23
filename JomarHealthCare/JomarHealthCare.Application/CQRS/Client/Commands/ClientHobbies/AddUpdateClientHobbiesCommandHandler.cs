using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientHobbies;


public class AddUpdateClientHobbiesCommandHandler : IRequestHandler<AddClientHobbiesListCommand, List<Domain.Entities.ClientHobbies>>
{
    private readonly IClientHobbiesRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public AddUpdateClientHobbiesCommandHandler(IClientHobbiesRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Domain.Entities.ClientHobbies>> Handle(AddClientHobbiesListCommand request, CancellationToken cancellationToken)
    {
        var hobbyEntity = new List<Domain.Entities.ClientHobbies>();
        foreach (var command in request.Commands)
        {
            var hobby = new Domain.Entities.ClientHobbies
            {
                HId = command.HId,
                ClientId = command.ClientId
            };

            hobbyEntity.Add(hobby);
        }


        var success = await _repository.AddOrUpdate(hobbyEntity);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return hobbyEntity;
    }
}