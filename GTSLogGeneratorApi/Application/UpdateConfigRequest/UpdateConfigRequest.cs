using MediatR;

namespace GTSLogGeneratorApi.Application.UpdateConfigRequest
{
    public class UpdateConfigRequest : IRequest
    {
        public string ConfigFilePath { get; set; }
        
        public string LogsInputFolder { get; set; }

        public string ErrorLogsFolder { get; set; }

        public string LoggerOutputFileLocation { get; set; }

        public int InitialTimestampRoundBase { get; set; }
        
        public int Timewindow { get; set; }

        public int TimewindowSendCount { get; set; }
        
        public string InfluxdbHost { get; set; }
        
        public string InfluxdbLogsMetricsBucket { get; set; }
        
        public string InfluxdbSystemMetricsBucket { get; set; }
        
        public string InfluxdbAuthToken { get; set; }
    }
}