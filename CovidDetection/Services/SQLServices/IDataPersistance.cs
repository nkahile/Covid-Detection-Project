using CovidDetection.Controllers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDetection.Services.SQLServices
{
    public interface IDataPersistance
    {

        bool sendTestResult(int id, int tests, int positives);


    }
}
