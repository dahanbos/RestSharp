using System;

namespace RestSharp.Authenticators
{
    public class OAuth2LeggedAuthenticator : IAuthenticator
    {
        private string _consumerKey;
        private string _consumerSecret;

        public OAuth2LeggedAuthenticator(string consumerKey, string consumerSecret)
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            var uri = new Uri(new Uri(client.BaseUrl), request.Resource);
            throw new System.NotImplementedException();
        }
    }
}