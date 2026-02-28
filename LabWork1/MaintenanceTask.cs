using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class MaintenanceTask
    {
        private int _id;
        private Machine _machine;        
        private string _description;
        private string _plannedDate;
        private bool _completed;

        public MaintenanceTask(int id, Machine machine, string description, string plannedDate)
        {
            _id = id;
            _machine = machine;
            _description = description;
            _plannedDate = plannedDate;
            _completed = false;
        }

        public Machine GetMachine() => _machine;
        public string GetDescription() => _description;
        public string GetPlannedDate() => _plannedDate;
        public bool IsCompleted() => _completed;

        public void MarkCompleted() => _completed = true;
    }

}
