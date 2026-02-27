using System.Collections.Generic;

namespace LabWork1
{
    public class Factory
    {
        private int _id;
        private string _name;
        private string _location;
        private int _establishedYear;

        private List<Workshop> _workshops = new List<Workshop>();

        public Factory(int id, string name, string location, int establishedYear)
        {
            _id = id;
            _name = name;
            _location = location;
            _establishedYear = establishedYear;
        }

        public int GetId() => _id;
        public string GetName() => _name;

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _name = name;
        }

        public string GetLocation() => _location;

        public void SetLocation(string location)
        {
            if (!string.IsNullOrWhiteSpace(location))
                _location = location;
        }

        public int GetEstablishedYear() => _establishedYear;

        public void SetEstablishedYear(int year)
        {
            if (year > 1800)
                _establishedYear = year;
        }

        public string Describe()
        {
            return $"Завод «{_name}», расположен: {_location}, основан в {_establishedYear} году.";
        }

        public void AddWorkshop(Workshop workshop) => _workshops.Add(workshop);
        public IEnumerable<Workshop> GetWorkshops() => _workshops;
    }
}
