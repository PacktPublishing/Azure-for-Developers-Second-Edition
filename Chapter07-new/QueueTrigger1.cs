using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class QueueTrigger1
    {
        [Function("QueueTrigger1")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "AzureWebJobsStorage")] string myQueueItem,
            FunctionContext context)
        {
        }
    }
}
