using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Worker
    {
        private int _id;
        private string _fullName;
        private string _position;
        private int _workshopId;
        private double _hourlyRate;
        private bool _active;

        public Worker(int id, string fullName, string position, int workshopId, double hourlyRate)
        {
            _id = id;
            _fullName = fullName;
            _position = position;
            _workshopId = workshopId;
            _hourlyRate = hourlyRate;
            _active = true;
        }

        public int GetId() => _id;
        public string GetFullName() => _fullName;
        public string GetPosition() => _position;

        public void SetPosition(string position)
        {
            if (!string.IsNullOrWhiteSpace(position))
                _position = position;
        }

        public int GetWorkshopId() => _workshopId;
        public double GetHourlyRate() => _hourlyRate;

        public void SetHourlyRate(double rate)
        {
            if (rate > 0)
                _hourlyRate = rate;
        }

        public bool IsActive() => _active;

        public void Activate() => _active = true;
        public void Deactivate() => _active = false;

        public double CalculateDailyPay(double hours)
        {
            if (hours < 0) return 0;
            return hours * _hourlyRate;
        }
    }
}
