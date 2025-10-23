using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage
{
    public class AppMessageDataModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int ToWhom { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool PauseOrStart { get; set; }
    }
}