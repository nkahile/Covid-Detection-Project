using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDetection.DTOs.Data
{
    public class GetDataDto
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public int testCount { get; set; }

        public int positiveCount { get; set; }

        public double percentagePos { get; set; }
    }
}
