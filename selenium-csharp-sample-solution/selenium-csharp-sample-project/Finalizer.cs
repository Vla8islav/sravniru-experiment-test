using System;
using NUnit.Framework;

namespace SravniRuTests
{
    [SetUpFixture]
    public class Finalizer
    {
        [TearDown]
	    public void RunInTheEndOfAll()
	    {
            WebDriverFactory.DismissAll();
        }
    }
}
