using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CSIapp
{
    public class SearchViewModel
    {
        public long SearchRequestMetricId { get; set; }
        public string SearchTimestamp { get; set; }
        public string SearchSourceIp { get; set; }
        public int SearchSourcePort { get; set; }
        public string SearchUri { get; set; }
        public string SearchVerb { get; set; }
        public string SearchRequestBody { get; set; }
        public string SearchReasonPhrase { get; set; }
        public string SearchResponseBody { get; set; }
        public int SearchResponseCode { get; set; }
        public long? SearchDuration { get; set; }
        public int SearchChannel { get; set; }
        public string SearchApiversion { get; set; }
        public string SearchApicontroller { get; set; }
        public string SearchApimethod { get; set; }
        public int? SearchBankNumber { get; set; }
        public string SearchServerName { get; set; }
        public long? SearchUserId { get; set; }
        public long? SearchEmpId { get; set; }
        public long? SearchSessionId { get; set; }
        public string SearchRequestCert { get; set; }
        public string SearchPartnerKey { get; set; }
        //public string SearchIsError {get; set;}
        public bool SearchIsError { get; set; }
        public DateTime? SearchStartTime {get; set;}
        public DateTime? SearchEndTime {get; set;}
    }
}