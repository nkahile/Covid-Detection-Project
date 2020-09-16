using AutoMapper;
using CovidDetection.Controllers.API;
using CovidDetection.DTOs;
using CovidDetection.DTOs.Data;
using CovidDetection.Models;
using CovidDetection.Services.SQLServices;
using CovidDetection.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDetection.Services.DataServices
{
    public class DataService : IDataService
    {
        private readonly IDataPersistance _dP;

        public DataService(IDataPersistance dP)
        {
            _dP = dP;
        }
        public Task<ServiceResponse<GetDataDto>> Get()
        {
            throw new NotImplementedException();
        }

        public bool sendResult(FormDTO formData)
        {
             
            return   _dP.sendTestResult(formData.siteID, formData.testCount, formData.positiveCount);
        }
    }
}
