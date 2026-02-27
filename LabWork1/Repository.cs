using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabWork1
{
    public class Repository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);
        public IEnumerable<T> GetAll() => _items;
    }
}

