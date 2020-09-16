using CovidDetection.Controllers.API;
using CovidDetection.DTOs;
using CovidDetection.DTOs.Data;
using CovidDetection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDetection.Services.DataServices
{
    public interface IDataService
    {
        Task<ServiceResponse<GetDataDto>> Get();

        bool sendResult(FormDTO result);
    }


}
