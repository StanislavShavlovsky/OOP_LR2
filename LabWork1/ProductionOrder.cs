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
        private ProductType _productType;   
        private int _quantity;
        private string _plannedStartDate;
        private string _plannedEndDate;

        private string _status;
        private List<Person> _assignedPeople = new List<Person>();

        public ProductionOrder(int id, string orderNumber, ProductType productType, int quantity,
                               string startDate, string endDate)
        {
            _id = id;
            _orderNumber = orderNumber;
            _productType = productType;
            _quantity = quantity;
            _plannedStartDate = startDate;
            _plannedEndDate = endDate;
            _status = "ЗАПЛАНИРОВАН";
        }

        public ProductType GetProductType() => _productType;
        public void AssignPerson(Person p) => _assignedPeople.Add(p);
        public IEnumerable<Person> GetAssignedPeople() => _assignedPeople;

        public void Start() { if (_status == "ЗАПЛАНИРОВАН") _status = "В РАБОТЕ"; }
        public void Complete() { if (_status == "В РАБОТЕ") _status = "ЗАВЕРШЁН"; }
        public bool IsInProgress() => _status == "В РАБОТЕ";

        public int GetId() => _id;
        public string GetOrderNumber() => _orderNumber;
        public int GetQuantity() => _quantity;
        public string GetPlannedStartDate() => _plannedStartDate;
        public string GetPlannedEndDate() => _plannedEndDate;
        public string GetStatus() => _status;
    }

}

