using Microsoft.Extensions.Configuration;
//Need to add Nuget Package 'Microsoft.Extensions.Configuration.Json'
//But seems do not need to add to using list.

namespace CardPaymentServicesComponentTestProject.Utilities
{
    public class ConfigHelper
    {
        private static readonly string configFile = "appSettings.json";

        /// <summary>
        /// Allows us to read the specified config file
        /// </summary>
        /// <returns></returns>
        /// Be sure to set optional: false, so that it errors if it cannot find the file
        /// Remember to set your appSettings.json to Copy always 
        /// (Right click on file, properties. Set Copy to Output Director = Copy Always)
        public static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(System.AppContext.BaseDirectory)
                .AddJsonFile(configFile,
                optional: false,
                reloadOnChange: true);

            return builder.Build();
        }

        public static string GetValueFromConfigKey(string key)
        {
            IConfiguration settings = GetConfig();
            string value = settings[key];
            return value;
        }
    }
}
