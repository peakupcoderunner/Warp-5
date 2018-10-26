using System;
using System.Net;

namespace likeitClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                var returnedValue = client.UploadString("https://j1csq3ukgg.execute-api.us-east-2.amazonaws.com/dev/", "\"peakup\"");
                Console.WriteLine(returnedValue);
            }
            Console.ReadLine();
        }
    }
}
