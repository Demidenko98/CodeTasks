using System;

namespace SecondBlock_Abstract
{
    public class Chrome : WebBrowser
    {

        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;
        public override bool CheckBrowser(BrowserType type)
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
        }

        public override BrowserType GetBrowser(BrowserType type)
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

    class InternetExplorer : WebBrowser
    {

        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;
        public override bool CheckBrowser(BrowserType type)
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

        public override BrowserType GetBrowser(BrowserType type)
        {
            browserType2 = type;
            return type;
        }

        public void Comparing()
        {
            if (browserType1 == browserType2)
                Console.WriteLine("Browsers are matching");
            else
            {
                Console.WriteLine("Browsers are NOT matching");
            }


        }
    }

    public class Firefox : WebBrowser
    {
        BrowserType? browserType1 = null;
        BrowserType? browserType2 = null;
        public override bool  CheckBrowser(BrowserType type)
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

        public override BrowserType GetBrowser(BrowserType type)
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
