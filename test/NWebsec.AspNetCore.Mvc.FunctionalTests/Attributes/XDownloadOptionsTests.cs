﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using NWebsec.AspNetCore.Mvc.FunctionalTests.Plumbing;

namespace NWebsec.AspNetCore.Mvc.FunctionalTests.Attributes
{
    [TestFixture]
    public class XDownloadOptionsTests
    {
        private TestServer _server;
        private HttpClient _httpClient;

        [SetUp]
        public void Setup()
        {
            _server = TestServerBuilder<MvcAttributeWebsite.Startup>.CreateTestServer();
            _httpClient = _server.CreateClient();
        }

        [TearDown]
        public void Cleanup()
        {
            _server.Dispose();
        }

        [Test]
        public async Task XDownloadOptions_Enabled_SetsHeaders()
        {
            const string path = "/XDownloadOptions";

            var response = await _httpClient.GetAsync(path);

            Assert.IsTrue(response.IsSuccessStatusCode, $"Request failed: {path}");
            Assert.IsTrue(response.Headers.Contains("X-Download-Options"), path);
        }

        [Test]
        public async Task XDownloadOptions_Disabled_NoHeaders()
        {
            const string path = "/XDownloadOptions/Disabled";

            var response = await _httpClient.GetAsync(path);

            Assert.IsTrue(response.IsSuccessStatusCode, $"Request failed: {path}");
            Assert.IsFalse(response.Headers.Contains("X-Download-Options"), path);
        }
    }
}