using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.TestHost;

using Moq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using RoshaniMSTest;
using Microsoft.AspNetCore.Hosting;

namespace RoshaniMSTest.TestStartup
{
    [TestClass]
    public class TestInitlizer
    {
        public static HttpClient TestHttpClient;
       
      /*  [AssemblyInitialize]
       public static void InitlizeTestServer(TestContext testcontext){
           var testserver=new TestServer(new WebHostBuilder().UseStartup<TestInitlizer>().UseEnvironment("IntegrationTest"));
           TestHttpClient=testserver.CreateClient();
       }
 */
       
    }
    
}