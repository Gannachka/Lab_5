using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public enum Types
    {
        Passenger,
        Cargo,
        War
    }
    public class Plane
    {
        List<CrewMember> Members { get; set; } = new List<CrewMember>();// автоматическое свойство
        public int ID { get; set; }
        public Types type { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public DateTime Date { get; set; }
        public Plane(int _id)
        {
            ID = _id;
        }
        public Plane(int id, Types type, string model, int capacity, DateTime date)
        {
            Capacity = capacity;
            Date = date;
            ID = id;
            this.type = type;
            Model=model;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Type: {type}, Model: {Model}, Capacity: {Capacity}, DateTime: {Date.Year}";
        }
    }
}
