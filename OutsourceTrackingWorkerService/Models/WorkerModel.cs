using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourceTrackingWorkerService.Models
{
    public class WorkerModel
    {
        public string WorkMode { get; set; }
        public int PeriodSeconds { get; set; }
        public string Conn { get; set; }
        public string BaseAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
