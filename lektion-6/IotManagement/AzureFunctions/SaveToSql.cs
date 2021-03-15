using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System;
using Newtonsoft.Json;
using SharedRespository;

namespace AzureFunctions
{
    public static class SaveToSql
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("SaveToSql")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "IotHubConnection", ConsumerGroup = "win20")]EventData message, ILogger log)
        {
            log.LogInformation("function running");

            using (var conn = new SqlConnection(Environment.GetEnvironmentVariable("SqlConnection")))
            {
                log.LogInformation("sql running");

                conn.Open();

                using (var cmd = new SqlCommand("INSERT INTO DhtMeasurements VALUES(@deviceId, @temperature, @humidity, @measurementTime)", conn))
                {
                    log.LogInformation("cmd running");
                    
                    var data = JsonConvert.DeserializeObject<DhtMeasurement>(Encoding.UTF8.GetString(message.Body.Array));
                    data.DeviceId = message.SystemProperties["iothub-connection-device-id"].ToString();
                    data.MeasurementTime = message.SystemProperties["iothub-enqueuedtime"].ToString();

                    cmd.Parameters.AddWithValue("@deviceId", data.DeviceId);
                    cmd.Parameters.AddWithValue("@temperature", data.Temperature);
                    cmd.Parameters.AddWithValue("@humidity", data.Humidity);
                    cmd.Parameters.AddWithValue("@measurementTime", data.MeasurementTime);


                }
            }
        }
    }
}