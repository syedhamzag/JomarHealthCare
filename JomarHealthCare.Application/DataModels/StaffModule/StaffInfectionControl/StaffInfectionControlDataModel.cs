using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffInfectionControlDataModel
    {
        public int InfectionId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public int Type { get; set; }
        public string Guideline { get; set; }
        public DateTime TestDate { get; set; }
        public int VaccStatus { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
    }
}
