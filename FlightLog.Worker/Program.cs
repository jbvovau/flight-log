using System;
using FlightLog.Core;

namespace FlightLog.Worker
{
    class Program
    {
        // my directory
        private const string dir = @"C:\Users\vovau\AppData\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalState\MISSIONS\Custom\CustomFlight\";
        static void Main(string[] args)
        {
            var manager = new FlightManager(dir);
            var f = manager.GetCurrent();
        }
    }
}
