using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class EventHubTrigger1
    {
        [Function("EventHubTrigger1")]
        public static void Run([EventHubTrigger("samples-workitems", Connection = "AzureWebJobsStorage")] string[] input, FunctionContext context)
        {
            var logger = context.GetLogger("EventHubTrigger1");
            logger.LogInformation($"First Event Hubs triggered message: {input[0]}");
        }
    }
}
