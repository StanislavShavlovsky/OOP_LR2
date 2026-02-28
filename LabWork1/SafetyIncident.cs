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
        private Workshop _workshop;    
        private string _description;
        private string _severity;

        public SafetyIncident(int id, string date, Workshop workshop, string description, string severity)
        {
            _id = id;
            _date = date;
            _workshop = workshop;
            _description = description;
            _severity = severity;
        }

        public Workshop GetWorkshop() => _workshop;
        public string GetDate() => _date;
        public string GetDescription() => _description;
        public string GetSeverity() => _severity;

        public bool IsSevere() => _severity == "HIGH";
    }

}
