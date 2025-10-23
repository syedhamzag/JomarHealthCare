using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, bool>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteClientCommandHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork)
        {
            _clientRepository = clientRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetByKeyAsync(new object[] { request.ClientId }, cancellationToken);
            if (client == null) return false;

            _clientRepository.Delete(client);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
