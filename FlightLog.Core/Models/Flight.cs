
using System.Collections.Generic;

namespace FlightLog.Core.Models {
    public class Flight{

        private string _currentHeader = "_";

        private Dictionary<string, List<KeyValue>> _data = new Dictionary<string, List<KeyValue>>();

        public void AddData(string line){

        }


        public class KeyValue{
            public string Key {get;set;}
            public string Value  {get;set;}
        }
    }

}