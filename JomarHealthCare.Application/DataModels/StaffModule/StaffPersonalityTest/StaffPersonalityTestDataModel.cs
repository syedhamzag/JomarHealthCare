using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffPersonalityTestDataModel
    {
        public int TestId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int Question { get; set; }
        public int Answer { get; set; }
    }
}
