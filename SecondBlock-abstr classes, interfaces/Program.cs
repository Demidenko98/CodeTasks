using System;


namespace SecondBlock_interfaces
{

    public enum BrowserType
    {
        InternetExplorer,
        Chrome,
        Firefox,
        Opera
    }

    public interface IWebBrowser
    {
        bool CheckBrowser(BrowserType type);

        BrowserType GetBrowser(BrowserType type);
    }

 
    public class Program
    {

        void PrintBrowser(BrowserType type)
        {
            Console.WriteLine(type);
        }
        static void Main(string[] args)
        {
            // new Program().PrintBrowser(BrowserType.Chrome);

            Chrome chrome = new Chrome();
            chrome.CheckBrowser(BrowserType.Chrome);
            chrome.GetBrowser(BrowserType.Chrome);
            chrome.Comparing();


            InternetExplorer internetExplorer = new InternetExplorer();
            internetExplorer.CheckBrowser(BrowserType.InternetExplorer);
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
