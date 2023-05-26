using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentSystem
{
    class Person
    {
        private int id;
        private string name;

        public void setID(int newID)
        {
            id = newID;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public int getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }
    }
}
