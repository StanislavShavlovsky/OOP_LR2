using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class QualityCheck
    {
        private int _id;
        private int _orderId;
        private int _productTypeId;
        private string _inspectorName;
        private string _result;
        private int _defectsCount;

        public QualityCheck(int id, int orderId, int productTypeId,
                            string inspectorName, string result, int defects)
        {
            _id = id;
            _orderId = orderId;
            _productTypeId = productTypeId;
            _inspectorName = inspectorName;
            _result = result;
            _defectsCount = defects;
        }

        public int GetId() => _id;
        public int GetOrderId() => _orderId;
        public int GetProductTypeId() => _productTypeId;
        public string GetInspectorName() => _inspectorName;
        public string GetResult() => _result;
        public int GetDefectsCount() => _defectsCount;

        public bool IsPassed() => _result == "PASSED";

        public double DefectRate(int totalChecked)
        {
            if (totalChecked <= 0) return 0;
            return (double)_defectsCount / totalChecked;
        }
    }
}
