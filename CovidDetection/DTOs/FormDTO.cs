using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDetection.DTOs
{
    public class FormDTO
    {
        public int siteID { get; set; }

        public int testCount { get; set; }

        public int positiveCount { get; set; }

    }
}
