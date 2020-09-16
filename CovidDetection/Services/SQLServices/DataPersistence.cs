using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;
using CovidDetection.Controllers.API;
using System.Configuration;
using CovidDetection.Services.SQLServices;
using Microsoft.Extensions.Configuration;

namespace CovidDetection.SQL
{
    public class DataPersistence : IDataPersistance
    {

        public readonly IConfiguration _config;

        public DataPersistence(IConfiguration config)
        {
            _config = config;
        }

        public Data getTestSiteDetails(int id)
        {
            SqlConnection connection;
            string connectionString = ConfigurationManager.ConnectionStrings["coviddetection"].ConnectionString;
            connection = new SqlConnection();

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                Data site = new Data();

                SqlDataReader sqlReader = null;

                String sqlStr = "Select * From TestResults WHERE SiteID = " + id.ToString();

                SqlCommand command = new SqlCommand(sqlStr, connection);

                sqlReader = command.ExecuteReader();
                if (sqlReader.Read())
                {
                    site.SiteId = sqlReader.GetInt32(0);
                    site.TestCount = sqlReader.GetInt32(2);
                    site.PositiveCount = sqlReader.GetInt32(3);
                    return site;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception except)
            {
                throw except;
            }
        }

        public Data getTestSiteID(string SiteName)
        {
            SqlConnection connection;
            string connectionString = _config.GetConnectionString("coviddetection");
            connection = new SqlConnection();

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                Data site = new Data();

                SqlDataReader sqlReader = null;

                String sqlStr = "Select SiteID From TestResults WHERE SiteID = " + SiteName;

                SqlCommand command = new SqlCommand(sqlStr, connection);

                sqlReader = command.ExecuteReader();
                if (sqlReader.Read())
                {
                    site.SiteId = sqlReader.GetInt32(0);
                    site.TestCount = sqlReader.GetInt32(2);
                    site.PositiveCount = sqlReader.GetInt32(3);
                    return site;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception except)
            {
                throw except;
            }
        }
        public bool sendTestResult(int id, int tests, int positives)
        {



            SqlConnection connection;
            string connectionString = _config.GetConnectionString("coviddetection");
            connection = new SqlConnection();

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                Data site = new Data();

                // SqlDataReader sqlReader = null;

                String sqlStr = "UPDATE TestResults SET Tested = Tested + " + tests + ", Positive = Positive + " + positives + " WHERE SiteID = " + id;

                SqlCommand command = new SqlCommand(sqlStr, connection);

                command.ExecuteNonQuery();



                connection.Close();
                return true;

            }
            catch (Exception except)
            {
                throw except;
            }
        }
    }
}

