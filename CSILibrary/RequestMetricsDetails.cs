using System;

namespace CSILibrary
{
    public class RequestMetricsDetails
    {
        public int RequestMetricsDetailsID {get; set;}
        public int RequestMetricId {get; set;}
        public string RequestType {get; set;}
        public DateTime BeginTime {get; set;}
        public DateTime EndTime {get; set;}
        public int RequestTime {get; set;}
        public string RequestDetail {get; set;}
        public bool IsError {get; set;}
        public int RequestMetricsExtID {get; set;}

    }
}
