using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Commands
{
    internal class AddExpenseLogCommandHandler: IRequestHandler<AddExpenseLogCommand, Expenselog>
    {

        private readonly IExpenseLogRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly IClientRepository _client;

        public AddExpenseLogCommandHandler(
            IUnitOfWork unitOfWork,
            IExpenseLogRepository repository,
            IUserIdentityService userIdentityService,
            IStaffPersonalInfoRepository staffPersonalInfoRepository,
            IClientRepository client)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _client = client;
        }

        public async Task<Domain.Entities.Expenselog> Handle(AddExpenseLogCommand request, CancellationToken cancellationToken)
        {

            var staff = await _staffPersonalInfoRepository.GetByKeyAsync(request.StaffId, cancellationToken );
            if (staff == null)
            {
                return null;
            }
            var client = await _client.GetByKeyAsync(request.ClientId, cancellationToken );
            if (client == null)
            {
                return null;
            }
            var expenselog = new Domain.Entities.Expenselog
            {
                ExpenseDate = request.ExpenseDate,
                ReferenceNo = request.ReferenceNo,
                StaffId = staff.StaffPersonalInfoId,
                ItemOfPurchase = request.ItemOfPurchase,
                Quantity = request.Quantity,
                Price = request.Price,
                AmountGivenAdvance = request.AmountGivenAdvance,
                ReceiptNo = request.ReceiptNo,
                ReturnBalance = request.ReturnBalance,
                PurchaseDate = request.PurchaseDate,
                LocationOfPurchase = request.LocationOfPurchase,
                ProofOfPurchase = request.ProofOfPurchase,
                WhoApproved = request.WhoApproved,
                Remarks = request.Remarks,
                ClientId = client.ClientId,
                CompanyId = _userIdentityService.CompanyId
               
            };

            await _repository.AddAsync(expenselog, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return expenselog;
        }
    
    }
}
