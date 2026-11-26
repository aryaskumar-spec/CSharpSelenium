using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumAutomationNew;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("www.google.com");
        driver.Close();
        Assert.Pass();
    }
}