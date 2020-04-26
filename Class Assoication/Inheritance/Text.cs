using System;

namespace Inheritance
{
    // in c# , we can have one parent class
    public class Text : PresentationObject
    {
        public string FontSize { get; set; }
        public string FontName { get; set; }

        public void Hyperlink(string url)
        {
            Console.WriteLine($"hyper link {url}");
        }
    }
}
