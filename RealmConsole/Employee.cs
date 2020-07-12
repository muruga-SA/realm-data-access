using Realms;

namespace RealmConsole
{
    public class Employee : RealmObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}