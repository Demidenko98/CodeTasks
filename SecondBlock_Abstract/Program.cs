using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondBlock_Abstract
{
    public enum BrowserType
    {
        InternetExplorer,
        Chrome,
        Firefox,
        Opera
    }
    public abstract class WebBrowser
    {
        public abstract bool CheckBrowser(BrowserType type);

        public abstract BrowserType GetBrowser(BrowserType type);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chrome chrome = new Chrome();
            chrome.CheckBrowser(BrowserType.Firefox);
            chrome.GetBrowser(BrowserType.Chrome);
            chrome.Comparing();


            InternetExplorer internetExplorer = new InternetExplorer();
            internetExplorer.CheckBrowser(BrowserType.Firefox);
            internetExplorer.GetBrowser(BrowserType.InternetExplorer);
            internetExplorer.Comparing();


            Firefox firefox = new Firefox();
            firefox.CheckBrowser(BrowserType.Firefox);
            firefox.GetBrowser(BrowserType.Firefox);
            firefox.Comparing();

            Console.ReadLine();
        }
    }
}
