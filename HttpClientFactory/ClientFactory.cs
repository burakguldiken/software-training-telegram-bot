﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTraining.HttpClientFactory
{
    public class ClientFactory : IClientFactory
    {
        public IHttpClientFactory clientFactory;

        public ClientFactory(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task RequestTest()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.tutorialspoint.com/csharp/csharp_question_bank/62.htm?QN=2");

            var client = clientFactory.CreateClient();

            try
            {
                var response = await client.SendAsync(request);
                var responseString = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                var b = ex.Message;
            }

            var a = 5;
        }
    }
}