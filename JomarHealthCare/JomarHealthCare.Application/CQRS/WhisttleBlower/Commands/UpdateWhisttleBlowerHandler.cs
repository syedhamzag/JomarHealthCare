using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Commands
{
    public class UpdateWhisttleBlowerHandler : IRequestHandler<UpdateWhisttleBlowerCommand, bool>
    {
        private readonly IWhisttleBlowerRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public UpdateWhisttleBlowerHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IWhisttleBlowerRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<bool> Handle(UpdateWhisttleBlowerCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<WhisttleBlower>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            foreach (var assignStaff in entity.NameOfHandlingPerson.Split(","))
            {
                Guid staffPersonalInfoId = Guid.Parse(assignStaff);
                var staff = await _staffPersonalInfoRepository.GetByKeyAsync(staffPersonalInfoId, cancellationToken);
                string content = $"Dear {string.Concat(staff.FirstName, " ", staff.LastName)},\r\n\r\nYou have been selected as Handling Person.\r\n\r\n Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
                await _emailService.SendEmailAsync(staff.Email, "Handling Person on Care360", content);
            }
            return true;
        }
    }
}