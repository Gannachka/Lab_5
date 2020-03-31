using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    enum Position
    {
        Pilot,
        SecondPilot,
        Hostess
    }
    class CrewMember
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public Position Position { get; set; }
    }
}
