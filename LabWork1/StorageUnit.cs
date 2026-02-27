using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class StorageUnit
    {
        private int _id;
        private string _code;
        private double _capacityKg;
        private double _currentLoadKg;

        public StorageUnit(int id, string code, double capacityKg)
        {
            _id = id;
            _code = code;
            _capacityKg = capacityKg;
            _currentLoadKg = 0;
        }

        public int GetId() => _id;
        public string GetCode() => _code;
        public double GetCapacityKg() => _capacityKg;
        public double GetCurrentLoadKg() => _currentLoadKg;

        public bool CanStore(double weight)
        {
            return weight >= 0 && _currentLoadKg + weight <= _capacityKg;
        }

        public void AddLoad(double weight)
        {
            if (CanStore(weight))
                _currentLoadKg += weight;
        }

        public void RemoveLoad(double weight)
        {
            if (weight >= 0 && weight <= _currentLoadKg)
                _currentLoadKg -= weight;
        }
    }

}
