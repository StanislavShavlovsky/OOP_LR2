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
        private int _machineId;
        private string _description;
        private string _plannedDate;
        private bool _completed;

        public MaintenanceTask(int id, int machineId, string description, string plannedDate)
        {
            _id = id;
            _machineId = machineId;
            _description = description;
            _plannedDate = plannedDate;
            _completed = false;
        }

        public int GetId() => _id;
        public int GetMachineId() => _machineId;
        public string GetDescription() => _description;
        public string GetPlannedDate() => _plannedDate;
        public bool IsCompleted() => _completed;

        public void MarkCompleted()
        {
            _completed = true;
        }
    }

}
