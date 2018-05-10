using System;

namespace CSILibrary
{
    public class RequestMetrics
    {
        public int RequestMetricId {get; set;}
        public DateTime Timestamp {get; set;}
        public string SourceIp {get; set;}
        public int SourcePort {get; set;}
        public string URI {get; set;}
        public string Verb {get; set;}
        public string RequestBody {get; set;}
        public string ReasonPhrase {get; set;}
        public string ResponseBody {get; set;}
        public int ResponseCode {get; set;}
        public int Duration {get; set;}
        public int Channel {get; set;}
        public string APIVersion {get; set;}
        public string APIController {get; set;}
        public string APIMethod {get; set;}
        public int BankNumber {get; set;}
        public string ServerName {get; set;}
        public int UserID {get; set;}
        public int EmpID {get; set;}
        public int SessionID {get; set;}
        public string RequestCert {get; set;}
        public string PartnerKey {get; set;}
    }
}
