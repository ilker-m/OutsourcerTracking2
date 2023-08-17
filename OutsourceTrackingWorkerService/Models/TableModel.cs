using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourceTrackingWorkerService.Models
{
    public class TableModel
    {
        public int Id { get; set; }
        public bool IsChanged { get; set; }
    }
}
