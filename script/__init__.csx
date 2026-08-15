using System;
using System.IO;
using Newtonsoft.Json;

namespace MiniCSC.Scripts
{
    public class ExecutionPayload
    {
        [JsonProperty("task_name")]
        public string TaskName { get; set; } = "DefaultTask";

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [JsonProperty("status")]
        public string Status { get; set; } = "Success";
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[MiniCSC] Initializing script execution harness...");

            // 1. System Environment Check
            string currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"[MiniCSC] Working Directory: {currentDir}");

            // 2. Generate JSON Data via Newtonsoft.Json
            var payload = new ExecutionPayload
            {
                TaskName = args.Length > 0 ? args[0] : "AutomatedPipelineRun",
                Status = "Initialized"
            };

            string jsonOutput = JsonConvert.SerializeObject(payload, Formatting.Indented);
            
            // 3. Output Results
            Console.WriteLine("[MiniCSC] Environment Context Payload:");
            Console.WriteLine(jsonOutput);

            Console.WriteLine("[MiniCSC] Execution completed successfully.");
        }
    }
}
