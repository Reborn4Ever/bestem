using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Microsoft.Extensions.Configuration;

namespace NgProjectTrackerBEST.Services {
    public class NavServiceClientFactory {

        private const string NAV_CONFIG_NAME = "NAVService";
        private const string NAV_CONFIG_USERNAME = "UserName";
        private const string NAV_CONFIG_PASSWORD = "Password";
        private const string NAV_CONFIG_URL = "Url";

        private readonly IConfiguration _configuration;
        
        public NavServiceClientFactory(IConfiguration configuration) {
            _configuration = configuration;
        }

        public TClient CreatePageClient<TClient, TChannel>(string pageName, Func<Binding, EndpointAddress, TClient> createFunction) 
            where TChannel : class where TClient : ClientBase<TChannel>, new() {

            var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportCredentialOnly);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            var configSection = _configuration.GetSection(NAV_CONFIG_NAME);
            var endpointAddress = new EndpointAddress(configSection[NAV_CONFIG_URL] + "Page/" + pageName);

            var clientRef = createFunction(binding, endpointAddress);
            clientRef.ClientCredentials.UserName.UserName = configSection[NAV_CONFIG_USERNAME];
            clientRef.ClientCredentials.UserName.Password = configSection[NAV_CONFIG_PASSWORD];

            return clientRef;
        }
    }
}
