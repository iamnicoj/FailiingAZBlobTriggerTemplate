using System;
using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace mycompany
{
    public static class BlobTriggerCSharpError
    {
        [Function("BlobTriggerCSharpError")]
        public static void Run([BlobTrigger("reproerrorazbt/{name}", Connection = "nicocsetrips_STORAGE")] Stream myBlob, string name,
            FunctionContext context)
        {
            var logger = context.GetLogger("BlobTriggerCSharpError");
            logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
        }
    }
}
