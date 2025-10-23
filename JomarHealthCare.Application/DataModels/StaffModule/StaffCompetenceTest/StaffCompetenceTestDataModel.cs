using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffCompetenceTestDataModel
    {
        public int StaffCompetenceTestId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
