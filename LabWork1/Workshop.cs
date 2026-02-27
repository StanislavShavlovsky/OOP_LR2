using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Workshop
    {
        private int _id;
        private string _code;
        private string _name;
        private int _factoryId;
        private double _areaSqM;

        private List<Machine> _machines = new List<Machine>();

        public Workshop(int id, string code, string name, int factoryId, double areaSqM)
        {
            _id = id;
            _code = code;
            _name = name;
            _factoryId = factoryId;
            _areaSqM = areaSqM;
        }

        public int GetId() => _id;
        public string GetCode() => _code;
        public string GetName() => _name;

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _name = name;
        }

        public int GetFactoryId() => _factoryId;
        public double GetAreaSqM() => _areaSqM;

        public bool IsLarge(double threshold)
        {
            return _areaSqM >= threshold;
        }

        public void AddMachine(Machine machine) => _machines.Add(machine);
        public IEnumerable<Machine> GetMachines() => _machines;
    }
}
