using System.Collections.Generic;
using System.Linq;
using Realms;

namespace RealmConsole
{
    public class EmployeeRepository
    {
        private readonly Realm _realm;

        public EmployeeRepository()
        {
            _realm = Realm.GetInstance();
        }

        public void AddEmployees(IEnumerable<Employee> employees)
        {
            _realm.Write(() =>
            {
                foreach (var e in employees)
                {
                    _realm.Add(e);
                }
            });
        }

        public int CountEmployees()
        {
            return _realm.All<Employee>().Count();
        }
    }
}