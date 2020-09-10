using System;

using FlightLog.Core.Models;

namespace FlightLog.Core
{
    public class FlightManager
    {
        private const string  FILE_FLIGHT = "";
        private const string FILE_PLAN = "";
        
        private readonly string _path;
        public FlightManager(string path){
            this._path = path;
        }

        public Flight GetCurrent(){
            return new Flight();
        }
    }
}
