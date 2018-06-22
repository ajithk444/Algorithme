using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Entities
{
    public class Room : IComparable<Room>
    {
        public int Num { get; set; }

        public Room(int num)
        {
            Num = num;
        }

        public int CompareTo(Room other)
        {
            return other.Num - this.Num;
        }

        public override string ToString()
        {
            return Num.ToString();
        }
    }
}
