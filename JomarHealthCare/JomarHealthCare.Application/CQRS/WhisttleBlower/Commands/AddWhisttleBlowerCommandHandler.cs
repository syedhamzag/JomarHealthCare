using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Commands;


internal class AddWhisttleBlowerCommandHandler : IRequestHandler<AddWhisttleBlowerCommand, WhisttleBlowerDataModel>
{
    private readonly IEmailService _emailService;
    private readonly IWhisttleBlowerRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;
    private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

    public AddWhisttleBlowerCommandHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository,
        IWhisttleBlowerRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _mapper = mapper;
        _uow = uow;
        _emailService = emailService;
        _repo = repo;
        _staffPersonalInfoRepository = staffPersonalInfoRepository;
    }

    public async Task<WhisttleBlowerDataModel> Handle(AddWhisttleBlowerCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<WhisttleBlower>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        foreach (var assignStaff in created.NameOfHandlingPerson.Split(","))
        {
            Guid staffPersonalInfoId = Guid.Parse(assignStaff);
            var staff = await _staffPersonalInfoRepository.GetByKeyAsync(staffPersonalInfoId, cancellationToken);
            string content = $"Dear {string.Concat(staff.FirstName, " ", staff.LastName)},\r\n\r\nYou have been selected as Handling Person.\r\n\r\n Kindly log in to your Care360 account to review. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
            await _emailService.SendEmailAsync(staff.Email, "Handling Person on Care360", content);
        }
        return _mapper.Map<WhisttleBlowerDataModel>(created);
    }
}
