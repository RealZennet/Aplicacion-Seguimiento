using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Seguimiento.Interfaces
{
    public class CustomerSearchByBatchIDInterface
    {
        public int BatchId { get; private set; }
        public string StreetDestination { get; private set; }
        public string DoorNumber { get; private set; }
        public DateTime ShippmentDate { get; private set; }
    }
}
