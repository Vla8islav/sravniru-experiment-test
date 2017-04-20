using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;

namespace SravniRuTests
{

    [TestFixture()]
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void StartApplication()
        {
            string browserType = System.Environment.GetEnvironmentVariable("BROWSER");
            string baseUrl = System.Environment.GetEnvironmentVariable("BASE_URL");
            string hubUrl = System.Environment.GetEnvironmentVariable("HUB_URL");

            if (baseUrl == null)
            {
                baseUrl = "https://www.sravni.ru/";
            }

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName,
                browserType != null ? browserType : "chrome");

            app = new ApplicationManager(capabilities, baseUrl, hubUrl);
        }
    }
}
