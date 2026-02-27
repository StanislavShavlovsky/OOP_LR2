using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Worker : Person
    {
        private string _position;
        private int _workshopId;
        private double _hourlyRate;

        public Worker(int id, string fullName, string position, int workshopId, double hourlyRate)
            : base(id, fullName, 0)
        {
            _position = position;
            _workshopId = workshopId;
            _hourlyRate = hourlyRate;
        }

        public override string GetRole() => "Рабочий";

        public string GetPosition() => _position;
        public int GetWorkshopId() => _workshopId;
        public double GetHourlyRate() => _hourlyRate;
    }
}
