using SecondBlock_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondBlock_interfaces
{
    public class Chrome : IWebBrowser
    {

        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;

        
        public bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.Chrome)
            {
                browserType1 = type;
                return true;
            }
            else
            {
                return false;
            }
            //if (true)
            //    type1 = type;
        }

        public BrowserType GetBrowser(BrowserType type)
        {
            browserType2 = type;
            return type;
        }

        public void Comparing()
        {
            if (browserType1 == browserType2)
                Console.WriteLine("Browsers are matching");
            else
                Console.WriteLine("Browsers are NOT matching");
        }

    }

   public class InternetExplorer : IWebBrowser
    {

        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;
        public bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.InternetExplorer)
            {
                browserType1 = type;
                return true;
            }
            else
            {
                return false;
            }
        }

        public BrowserType GetBrowser(BrowserType type)
        {
            browserType2 = type;
            return type;
        }

        public void Comparing()
        {
            if (browserType1 == browserType2)
                Console.WriteLine("Browsers are matching");
            else
                Console.WriteLine("Browsers are NOT matching");

        }
    }

    public class Firefox : IWebBrowser
    {
        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;
        public bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.Firefox)
            {
                browserType1 = type;
                return true;
            }
            else
            {
                return false;
            }
        }

        public BrowserType GetBrowser(BrowserType type)
        {
            browserType2 = type;
            return type;
        }

        public void Comparing()
        {
            if (browserType1 == browserType2)
                Console.WriteLine("Browsers are matching");
            else
                Console.WriteLine("Browsers are NOT matching");


        }

    }


}

