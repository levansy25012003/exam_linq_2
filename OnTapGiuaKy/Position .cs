using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public class Position
    {
        public int id { get; set; }
        public string name { get; set; }

        public Position(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public static List<Position> positionList()
        {
            List<Position> list = new List<Position>();
            list.Add(new Position(1, "Developer"));
            list.Add(new Position(2, "Tester"));
            list.Add(new Position(3, "Human Resources"));
            list.Add(new Position(4, "President"));
            return list;
        }
    }
}
