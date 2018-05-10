using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using CSIapp;

namespace CSIapp{
    public class BigDataModel{
        public RequestMetrics RequestMetric {get; set;}
        public RequestMetricsDetails RequestMetricDetail {get; set;}
    }
}