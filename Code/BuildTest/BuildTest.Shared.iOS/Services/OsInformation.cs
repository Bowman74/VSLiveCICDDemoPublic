using System;
using BuildTest.Services;
using UIKit;

namespace BuildTest.iOS.Services
{
    public class OsInformation : IOsInformation
    {
        public string GetVersionInformation()
        {
            return UIDevice.CurrentDevice.SystemVersion;
        }
    }
}