using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewCrashMidLoad
{
    internal class MyImage : Image
    {
        ~MyImage()
        {
            Console.WriteLine("MyImage finalized");
        }
    }
}
