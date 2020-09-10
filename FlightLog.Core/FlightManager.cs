using System;
using System.IO;
using FlightLog.Core.Models;

namespace FlightLog.Core
{
    public class FlightManager
    {
        private const string  FILE_FLIGHT = "CUSTOMFLIGHT.FLT";
        private const string FILE_PLAN = "";

        private readonly string _path;
        public FlightManager(string path){
            this._path = path;
        }

        public Flight GetCurrent(){
            return BuildFromPath(_path + FILE_FLIGHT);
        }


        private Flight BuildFromPath(string path){
            var flight = new Flight();

            // open FLT file
            var reader = File.OpenText(path);
            
            var line = "";
            while (line != null){
                line = reader.ReadLine();
                if (line != null){
                    flight.AddData(line);
                }
            }

            return flight;
        }
    }
}
