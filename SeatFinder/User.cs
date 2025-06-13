using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatFinder
{
    internal class User
    {
        public string Name { get; set; }
        public SeatClass Preference { get; set; }

        public User(string name, SeatClass preference)
        {
            Name = name;
            Preference = preference;
        }
    }
}
