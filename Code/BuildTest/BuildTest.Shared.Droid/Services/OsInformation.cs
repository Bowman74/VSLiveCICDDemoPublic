using System;
using BuildTest.Services;

namespace BuildTest.Droid.Services
{
    public class OsInformation : IOsInformation
    {
        public string GetVersionInformation()
        {
            return Android.OS.Build.VERSION.Sdk;
        }
    }
}
