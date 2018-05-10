using System;
using System.Collections.Generic;

namespace CSIapp
{
    public partial class RequestMetricsDetails
    {
        public long RequestMetricsDetailsId { get; set; }
        public long RequestMetricId { get; set; }
        public string RequestType { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public long? RequestTime { get; set; }
        public string RequestDetail { get; set; }
        public bool IsError { get; set; }
        public long? RequestMetricsExtId { get; set; }

        public RequestMetrics RequestMetric { get; set; }
    }
}
