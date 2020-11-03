using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MakeMyTripTest
{
    public class Class1
    {
        string url = "https://www.makemytrip.com/";

        [Fact]
        public void Openmakemytrip()
        {
            IWebDriver webDriver;
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(url);
           // webDriver.Navigate().GoToUrl("https://www.makemytrip.com/hotels");
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.CssSelector(".userNameText")).Click();
            webDriver.FindElement(By.CssSelector(".appendBottom10 .font16")).Click();
            webDriver.FindElement(By.CssSelector(".font10 > .makeFlex > p")).Click();
            webDriver.FindElement(By.Id("username")).Click();
            webDriver.FindElement(By.Id("username")).SendKeys("akhilakhivnl@gmail.com");
            webDriver.FindElement(By.CssSelector(".btnContainer > .capText")).Click();           
            webDriver.FindElement(By.Id("password")).Click();
            webDriver.FindElement(By.Id("password")).SendKeys("test@123");       
            webDriver.FindElement(By.CssSelector(".btnContainer > .capText")).Click();
            webDriver.FindElement(By.CssSelector(".chHotels")).Click();
            webDriver.FindElement(By.Id("city")).Click();
            webDriver.FindElement(By.Id("city")).SendKeys("Delhi");
            webDriver.FindElement(By.CssSelector("#react-autowhatever-1-section-0-item-1 .font12")).Click();
            webDriver.FindElement(By.CssSelector(".DayPicker-Month:nth-child(1) .DayPicker-Week:nth-child(1) > .DayPicker-Day:nth-child(6)")).Click();
            webDriver.FindElement(By.CssSelector(".DayPicker-Day--selected:nth-child(7)")).Click();
            webDriver.FindElement(By.Id("hsw_search_button")).Click();
            webDriver.FindElement(By.CssSelector("#Listing_hotel_0 .amenList")).Click();
            webDriver.FindElement(By.Id("detpg_headerright_book_now")).Click();
            webDriver.FindElement(By.Id("fName")).Click();
            webDriver.FindElement(By.Id("fName")).SendKeys("akhil");
            webDriver.FindElement(By.Id("lName")).Click();
            webDriver.FindElement(By.Id("lName")).SendKeys("p");
            webDriver.FindElement(By.Id("email")).Click();
            webDriver.FindElement(By.Id("email")).SendKeys("p.akhilsathyan@gmail.com");
            webDriver.FindElement(By.Id("mNo")).Click();
            webDriver.FindElement(By.Id("mNo")).SendKeys("9539847979");
            webDriver.FindElement(By.CssSelector(".primaryBtn > div")).Click();
            webDriver.FindElement(By.Id("PAYMENT_inputVpa")).Click();
            webDriver.FindElement(By.Id("PAYMENT_inputVpa")).Click();
            webDriver.FindElement(By.Id("PAYMENT_inputVpa")).Click();
            webDriver.FindElement(By.Id("PAYMENT_inputVpa")).SendKeys("test");
            webDriver.FindElement(By.Id("makePaymentButton")).Click();
            webDriver.Close();
        }
    }    
   
}
