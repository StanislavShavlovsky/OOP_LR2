using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class SafetyIncident
    {
        private int _id;
        private string _date;
        private int _workshopId;
        private string _description;
        private string _severity;

        public SafetyIncident(int id, string date, int workshopId, string description, string severity)
        {
            _id = id;
            _date = date;
            _workshopId = workshopId;
            _description = description;
            _severity = severity;
        }

        public int GetId() => _id;
        public string GetDate() => _date;
        public int GetWorkshopId() => _workshopId;
        public string GetDescription() => _description;
        public string GetSeverity() => _severity;

        public bool IsSevere() => _severity == "HIGH";
    }
}
