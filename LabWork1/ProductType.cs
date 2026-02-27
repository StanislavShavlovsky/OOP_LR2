using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class ProductType
    {
        private int _id;
        private string _code;
        private string _name;
        private string _description;
        private double _standardCycleTimeMin;

        public ProductType(int id, string code, string name, string description, double cycleTime)
        {
            _id = id;
            _code = code;
            _name = name;
            _description = description;
            _standardCycleTimeMin = cycleTime;
        }

        public int GetId() => _id;
        public string GetCode() => _code;
        public string GetName() => _name;

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _name = name;
        }

        public string GetDescription() => _description;

        public void SetDescription(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
                _description = description;
        }

        public double GetStandardCycleTimeMin() => _standardCycleTimeMin;

        public bool IsComplex(double threshold)
        {
            return _standardCycleTimeMin >= threshold;
        }
    }
}
