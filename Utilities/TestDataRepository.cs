using CardPaymentServicesComponentTestProject.TestData.Models;
using FileHelpers;
using System;
using System.IO;
using System.Reflection;

namespace CardPaymentServicesComponentTestProject.Utilities
{
    public class TestDataRepository
    {
        // <summary>
        /// Used for finding where code is executed from, this is at the project level
        /// So an example path might be AssemblyDirectory/TestData
        /// </summary>
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        //Instance of the data model
        private PaymentNotification[] notificationPayload;

        public void ReadPayloadFileIntoDataRepository(string dataFile)
        {
            var engine = new FileHelperEngine<PaymentNotification>();
            var dataDirectoryPath = GetFilePath("TestData", "DataFiles");
            var dataFilePath = Path.Combine(dataDirectoryPath, dataFile);
            notificationPayload = engine.ReadFile(dataFilePath);
        }


        public PaymentNotification[] GetNotificationPayload(string dataFile)
        {
            ReadPayloadFileIntoDataRepository(dataFile);
            return notificationPayload;
        }


        /// <summary>
        /// Will combine assembly directory with given target folder
        /// E.G. ./TestData
        /// </summary>
        /// <param name="targetFolder"></param>
        /// <returns>string</returns>
        public string GetFilePath(string targetFolder)
        {
            return Path.Combine(Path.Combine(AssemblyDirectory, targetFolder));
        }

        public string GetFilePath(string targetFolder, string subFolder1)
        {
            return Path.Combine(Path.Combine(AssemblyDirectory, targetFolder, subFolder1));
        }

    }
}
