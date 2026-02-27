using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Machine
    {
        private int _id;
        private string _inventoryNumber;
        private string _model;
        private int _workshopId;

        private string _status;
        private double _hoursWorked;

        public Machine(int id, string inventoryNumber, string model, int workshopId)
        {
            _id = id;
            _inventoryNumber = inventoryNumber;
            _model = model;
            _workshopId = workshopId;
            _status = "ОЖИДАНИЕ";
            _hoursWorked = 0;
        }

        public int GetId() => _id;
        public string GetInventoryNumber() => _inventoryNumber;
        public string GetModel() => _model;
        public int GetWorkshopId() => _workshopId;
        public string GetStatus() => _status;
        public double GetHoursWorked() => _hoursWorked;

        public void Start()
        {
            if (_status != "НЕИСПРАВЕН")
                _status = "РАБОТАЕТ";
        }

        public void Stop()
        {
            if (_status == "РАБОТАЕТ")
                _status = "ОЖИДАНИЕ";
        }

        public void AddHours(double hours)
        {
            if (hours > 0)
                _hoursWorked += hours;
        }

        public void AddHours(int hours) => AddHours((double)hours);

        public void MarkBroken()
        {
            _status = "НЕИСПРАВЕН";
        }

        public bool IsOperational()
        {
            return _status != "НЕИСПРАВЕН";
        }
    }
}
