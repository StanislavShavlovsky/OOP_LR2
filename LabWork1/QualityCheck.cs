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
        private ProductionOrder _order;    
        private ProductType _productType;    
        private Person _inspector;
        private string _result;
        private int _defectsCount;

        public QualityCheck(int id, ProductionOrder order, ProductType productType,
                            Person inspector, string result, int defects)
        {
            _id = id;
            _order = order;
            _productType = productType;
            _inspector = inspector;
            _result = result;
            _defectsCount = defects;
        }

        public ProductionOrder GetOrder() => _order;
        public ProductType GetProductType() => _productType;
        public Person GetInspector() => _inspector;
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
