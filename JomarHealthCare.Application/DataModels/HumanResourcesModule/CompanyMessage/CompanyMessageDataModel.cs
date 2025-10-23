using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage
{
    public class CompanyMessageDataModel
    {
        public int Id { get; set; }
        public string CompanysMessage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}