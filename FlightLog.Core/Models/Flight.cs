
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FlightLog.Core.Models {
    public class Flight{

        private string _currentHeader = "_";

        private Dictionary<string, Dictionary<string, string>> _data = new Dictionary<string, Dictionary<string, string>>();

        public void AddData(string line){
            // match header
            const string regexHeader = @"\[(.*)\]";
            var m = Regex.Match(line, regexHeader);
            if (m != null && m.Success && m.Groups.Count > 1){
                var key = m.Groups[1];
                if (_currentHeader != key.Value) {
                    _currentHeader = key.Value;
                    Console.WriteLine("Change value to : " + _currentHeader);
                }
            } else {
                // regular line
                var words = line.Split('=');
                if (words.Length > 1) {
                    var key = words[0];
                    var value = words[1];

                    // get list
                    if (!_data.ContainsKey(_currentHeader)) {
                        _data.Add(_currentHeader, new Dictionary<string,string>());
                    }

                    var group = _data[_currentHeader];

                    group[key] = value;
                    Console.WriteLine($"Add {key} = {value}");
                }
            }
        }
    }

}