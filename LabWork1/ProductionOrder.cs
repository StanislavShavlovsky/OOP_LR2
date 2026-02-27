using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class ProductionOrder
    {
        private int _id;                    
        private string _orderNumber;         
        private int _productTypeId;          
        private int _quantity;              
        private string _plannedStartDate;   
        private string _plannedEndDate;     


        private string _status;

        public ProductionOrder(int id, string orderNumber, int productTypeId, int quantity,
                               string startDate, string endDate)
        {
            _id = id;
            _orderNumber = orderNumber;
            _productTypeId = productTypeId;
            _quantity = quantity;
            _plannedStartDate = startDate;
            _plannedEndDate = endDate;
            _status = "ЗАПЛАНИРОВАН";
        }

        public int GetId() => _id;
        public string GetOrderNumber() => _orderNumber;
        public int GetProductTypeId() => _productTypeId;
        public int GetQuantity() => _quantity;
        public string GetPlannedStartDate() => _plannedStartDate;
        public string GetPlannedEndDate() => _plannedEndDate;
        public string GetStatus() => _status;

        public void Start()
        {
            if (_status == "ЗАПЛАНИРОВАН")
                _status = "В РАБОТЕ";
        }

        public void Complete()
        {
            if (_status == "В РАБОТЕ")
                _status = "ЗАВЕРШЁН";
        }

        public bool IsInProgress() => _status == "В РАБОТЕ";
    }

}
