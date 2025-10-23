using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.CompanyBanks.Commands;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Commands
{
    internal class UpdateExpenselogCommandHandler : IRequestHandler<UpdateExpenseLogCommand, bool>
    {
        private readonly IExpenseLogRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly IClientRepository _client;

        public UpdateExpenselogCommandHandler(
            IUnitOfWork unitOfWork,
            IExpenseLogRepository repository,
            IUserIdentityService userIdentityService,
            IStaffPersonalInfoRepository staffPersonalInfoRepository,
            IClientRepository client)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
            _client = client;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<bool> Handle(UpdateExpenseLogCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var expenselog = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (expenselog == null)
            {
                return false;
            }
            var staff = await _staffPersonalInfoRepository.GetByKeyAsync(request.StaffId, cancellationToken);
            if (staff == null)
            {
                return false;
            }
            var client = await _client.GetByKeyAsync(request.ClientId, cancellationToken);
            if (client == null)
            {
                return false;
            }

            // Update properties
            expenselog.ClientId = client.ClientId;
            expenselog.ExpenseDate = request.ExpenseDate;
            expenselog.ReferenceNo = request.ReferenceNo;
            expenselog.ReceiptNo = request.ReceiptNo;
            expenselog.LocationOfPurchase = request.LocationOfPurchase;
            expenselog.StaffId = staff.StaffPersonalInfoId;
            expenselog.AmountGivenAdvance = request.AmountGivenAdvance;
            expenselog.Quantity = request.Quantity;
            expenselog.Price = request.Price;
            expenselog.PurchaseDate = request.PurchaseDate;
            expenselog.ProofOfPurchase = request.ProofOfPurchase;
            expenselog.Remarks = request.Remarks;


            _repository.Update(expenselog);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }

    }
}
