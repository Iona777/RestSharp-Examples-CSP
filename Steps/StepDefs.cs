using CardPaymentServicesComponentTestProject.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using TechTalk.SpecFlow;

namespace CardPaymentServicesComponentTestProject.Steps
{
    [Binding]
    public class StepDefs
    {
        //Class Variables
        private RestClient client;
        private IRestRequest request;
        private IRestResponse response;
        private readonly TestDataRepository _theTestDataRepostitory;

        //Constructor
        public StepDefs()
        {
            _theTestDataRepostitory = new TestDataRepository();
        }

        [Given(@"I want to go to baseURL")]
        public void GivenIWantToGoToBaseURL()
        {
            var baseURL = ConfigHelper.GetValueFromConfigKey("baseUrl");
            client = new RestClient(baseURL);
        }


        [Given(@"I want to go to baseURL ""(.*)""")]
        public void GivenIWantToGoToBaseURL(string baseURL)
        {
            client = new RestClient(baseURL);
        }

        [When(@"the ""(.*)"" endpoint is called with http POST and using row ""(.*)"" from payload ""(.*)""")]
        public void WhenTheEndpointIsCalledWithHttpPOSTAndUsingRowFromPayload(string endPoint, int row, string payloadFile)
        {
            var payload = _theTestDataRepostitory.GetNotificationPayload(payloadFile);

            request = new RestRequest(endPoint, Method.POST)
                .AddParameter("messagetype", payload[row].messagetype)
                .AddParameter("timestamp", payload[row].timestamp)
                .AddParameter("message", payload[row].message)
                .AddParameter("apiversion", payload[row].apiversion)
                .AddParameter("order_description", payload[row].order_description)
                .AddParameter("merchantreference", payload[row].merchantreference)
                .AddParameter("transactioncurrencycode", payload[row].transactioncurrencycode)
                .AddParameter("txnvalue", payload[row].txnvalue) //Could parameterise this for an Accept/Decline
                .AddParameter("pan", payload[row].pan)
                .AddParameter("card_expiry", payload[row].card_expiry)
                .AddParameter("pan_hash", payload[row].pan_hash)
                .AddParameter("tokenid", payload[row].tokenid)
                .AddParameter("tokenexpiration", payload[row].tokenexpiration)
                .AddParameter("transactionid", payload[row].transactionid)
                .AddParameter("resultdatetimestring", payload[row].resultdatetimestring)
                .AddParameter("authcode", payload[row].authcode) //Could parameterise this for an Accept/Decline
                .AddParameter("authmessage", payload[row].authmessage)//Could parameterise this for an Accept/Decline
                .AddParameter("messagenumber", payload[row].messagenumber)
                .AddParameter("txnresult", payload[row].txnresult) //Could parameterise this for an Accept/Decline
                .AddParameter("ad1avs_result", payload[row].ad1avs_result)
                .AddParameter("pcavs_result", payload[row].pcavs_result)
                .AddParameter("cvc_result", payload[row].cvc_result)
                .AddParameter("merchantnumber", payload[row].merchantnumber)
                .AddParameter("tid", payload[row].tid)
                .AddParameter("schemename", payload[row].schemename)
                .AddParameter("errordescription", payload[row].errordescription)
                .AddParameter("errorcode", payload[row].errorcode)
                .AddParameter("rejectcode", payload[row].rejectcode)
                .AddParameter("resultcode", payload[row].resultcode) //Could parameterise this for an Accept/Decline
                .AddParameter("schemeidentifier", payload[row].schemeidentifier)
                .AddParameter("vgisreference", payload[row].vgisreference)
                .AddParameter("customerspecifichash", payload[row].customerspecifichash)
                .AddParameter("enrolled", payload[row].enrolled)
                .AddParameter("authenticationstatus", payload[row].authenticationstatus)
                .AddParameter("atsdata", payload[row].atsdata)
                .AddParameter("authenticationcavv", payload[row].authenticationcavv)
                .AddParameter("authenticationeci", payload[row].authenticationeci)
                .AddParameter("authenticationtime", payload[row].authenticationtime)
                .AddParameter("payerauthrequestid", payload[row].payerauthrequestid)
                .AddParameter("dcccommissionfee", payload[row].dcccommissionfee)
                .AddParameter("dccconversionrateapplied", payload[row].dccconversionrateapplied)
                .AddParameter("dccmarkupfee", payload[row].dccmarkupfee)
                .AddParameter("exchangerateagreementdate", payload[row].exchangerateagreementdate)
                .AddParameter("fexcoid", payload[row].fexcoid)
                .AddParameter("originaltxnvalue", payload[row].originaltxnvalue)
                .AddParameter("originalmkaccountid", payload[row].originalmkaccountid)
                .AddParameter("schemereferencedata", payload[row].schemereferencedata)
                .AddParameter("signature", payload[row].signature)
                ;

            response = client.Execute(request);
        }


        [When(@"the ""(.*)"" endpoint is called with http POST")]
        public void WhenTheEndpointIsCalledWithHttpPOST(string endPoint)
        {
            request = new RestRequest(endPoint, Method.POST)
               // .AddParameter("messagetype", "Txn_Response")
               // .AddParameter("timestamp", "2020-10-28T13:47:05:14")
               .AddParameter("message", "Failed") //Could parameterise this for an Accept/Decline
               .AddParameter("apiversion", "2.0.0.0")
               .AddParameter("order_description", "")
               .AddParameter("merchantreference", "01|46001262748|Online|1000795955")
               .AddParameter("transactioncurrencycode", "826")
               .AddParameter("txnvalue", "1.05") //Could parameterise this for an Accept/Decline
               .AddParameter("pan", "401200******8884")
               .AddParameter("card_expiry", "1023")
               .AddParameter("pan_hash", "nBaY3riqVPpSw1zs15jIW1/Zd5lApJwbt7u2L0lSQlk=")
               .AddParameter("tokenid", "0")
               .AddParameter("tokenexpiration", "")
               .AddParameter("transactionid", "10880978")
               .AddParameter("resultdatetimestring", "2020-10-28T13:47:34.483")
               .AddParameter("authcode", "") //Could parameterise this for an Accept/Decline
               .AddParameter("authmessage", "Declined")//Could parameterise this for an Accept/Decline
               .AddParameter("messagenumber", "1075")
               .AddParameter("txnresult", "DECLINED") //Could parameterise this for an Accept/Decline
               .AddParameter("ad1avs_result", "0")
               .AddParameter("pcavs_result", "0")
               .AddParameter("cvc_result", "2")
               .AddParameter("merchantnumber", "21249872")
               .AddParameter("tid", "04380001")
               .AddParameter("schemename", "Visa")
               .AddParameter("errordescription", "")
               .AddParameter("errorcode", "")
               .AddParameter("rejectcode", "0")
               .AddParameter("resultcode", "5") //Could parameterise this for an Accept/Decline
               .AddParameter("schemeidentifier", "SRD 28102020 10880978")
               .AddParameter("vgisreference", "9999")
               .AddParameter("customerspecifichash", "")
               .AddParameter("enrolled", "")
               .AddParameter("authenticationstatus", "")
               .AddParameter("atsdata", "")
               .AddParameter("authenticationcavv", "")
               .AddParameter("authenticationeci", "")
               .AddParameter("authenticationtime", "")
               .AddParameter("payerauthrequestid", "")
               .AddParameter("dcccommissionfee", "")
               .AddParameter("dccconversionrateapplied", "")
               .AddParameter("dccmarkupfee", "")
               .AddParameter("exchangerateagreementdate", "")
               .AddParameter("fexcoid", "")
               .AddParameter("originaltxnvalue", "")
               .AddParameter("originalmkaccountid", "")
               .AddParameter("schemereferencedata", "")
               .AddParameter("signature", "NwWXv/38OIQZIDmX9kAHq8Jpx8410D+Ni2Tjyge8Dq1moxRdk/ZVz79+Z2BaDN9IpBifI5+5YSuuNUaYo1a+IMe2b7KyPca7QN8nBHiVRqj9LVTREVzQhP4dP+ZkXEd/x0H0Vnsp4keVbGctiZXxsfTUxYC3IWFur/mIP7dlbA4=");

            response = client.Execute(request);
        }

        [Then(@"call is successful with status code ""(.*)""")]
        public void ThenCallIsSuccessfulWithStatusCode(string expectedStatusCode)
        {
            Assert.AreEqual(expectedStatusCode, response.StatusCode.ToString());
        }
    }
}
