using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using FileHelpers;

namespace CardPaymentServicesComponentTestProject.TestData.Models
{
    [DelimitedRecord(",")]
    public class PaymentNotification
    {
        public string messagetype { get; set; }
        public string timestamp { get; set; }
        public string message { get; set; }
        public string apiversion { get; set; }
        public string order_description { get; set; }
        public string merchantreference { get; set; }
        public string transactioncurrencycode { get; set; }
        public string txnvalue { get; set; }
        public string pan { get; set; }
        public string card_expiry { get; set; }
        public string pan_hash { get; set; }
        public string tokenid { get; set; }
        public string tokenexpiration { get; set; }
        public string transactionid { get; set; }
        public string resultdatetimestring { get; set; }
        public string authcode { get; set; }
        public string authmessage { get; set; }
        public string messagenumber { get; set; }
        public string txnresult { get; set; }
        public string ad1avs_result { get; set; }
        public string pcavs_result { get; set; }
        public string cvc_result { get; set; }
        public string merchantnumber { get; set; }
        public string tid { get; set; }
        public string schemename { get; set; }
        public string errordescription { get; set; }
        public string errorcode { get; set; }
        public string rejectcode { get; set; }
        public string resultcode { get; set; }
        public string schemeidentifier { get; set; }
        public string vgisreference { get; set; }
        public string customerspecifichash { get; set; }
        public string enrolled { get; set; }
        public string authenticationstatus { get; set; }
        public string atsdata { get; set; }
        public string authenticationcavv { get; set; }
        public string authenticationeci { get; set; }
        public string authenticationtime { get; set; }
        public string payerauthrequestid { get; set; }
        public string dcccommissionfee { get; set; }
        public string dccconversionrateapplied { get; set; }
        public string dccmarkupfee { get; set; }
        public string exchangerateagreementdate { get; set; }
        public string fexcoid { get; set; }
        public string originaltxnvalue { get; set; }
        public string originalmkaccountid { get; set; }
        public string schemereferencedata { get; set; }
        public string signature { get; set; }

    }   
}
