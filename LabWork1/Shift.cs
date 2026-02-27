using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Shift
    {
        private int _id;
        private string _code;
        private double _startHour;
        private double _endHour;
        private int _maxWorkers;

        public Shift(int id, string code, double startHour, double endHour, int maxWorkers)
        {
            _id = id;
            _code = code;
            _startHour = startHour;
            _endHour = endHour;
            _maxWorkers = maxWorkers;
        }

        public int GetId() => _id;
        public string GetCode() => _code;
        public double GetStartHour() => _startHour;
        public double GetEndHour() => _endHour;
        public int GetMaxWorkers() => _maxWorkers;

        public double DurationHours()
        {
            if (_endHour >= _startHour)
                return _endHour - _startHour;

            return (24 - _startHour) + _endHour;
        }

        public bool CanAcceptMore(int currentCount)
        {
            return currentCount < _maxWorkers;
        }
    }
}
