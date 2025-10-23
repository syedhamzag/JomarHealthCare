using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Queries
{
    internal class GetAllCompanyBankByCompanyIdQueryHandler: IRequestHandler<GetAllCompanyBankByCompanyIdQuery, List<CompanyBank>>
    {
        private readonly ICompanyBankRepository _repository;
        public GetAllCompanyBankByCompanyIdQueryHandler(ICompanyBankRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<CompanyBank>> Handle(GetAllCompanyBankByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new CompanyBank
            {
                Id = entity.Id,
                BankName = entity.BankName,
                Title = entity.Title,
                AccountNo = entity.AccountNo,
                TransitNo = entity.TransitNo,
                InstitudionNo = entity.InstitudionNo,
                SortCode = entity.SortCode,
                IsUKBank = entity.IsUKBank,
                IsOperating = entity.IsOperating,
                CompanyId = entity.CompanyId
            }).ToList();
        }
    }
}
