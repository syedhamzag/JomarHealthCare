using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Commands
{
    public class UpdateCompanyBankCommand: IRequest<bool>
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Title { get; set; }
        public string AccountNo { get; set; }
        public string TransitNo { get; set; }
        public string InstitudionNo { get; set; }
        public string SortCode { get; set; }
        public bool IsUKBank { get; set; }
        public bool IsOperating { get; set; }
        public Guid CompanyId { get; set; }
    }
}
