namespace U16Task3.Classes
{
    public class Person
    {
        // Public properties
        public string Name;
        public string ID;
        public string DoB;

        // Setter methods
        public void setName(string newName)
        {
            this.Name = newName;
        }

        public void setID(string newID)
        {
            this.ID = newID;
        }

        public void setDoB(string newDoB)
        {
            this.DoB = newDoB;
        }

        // Getter methods
        public string getName()
        {
            return this.Name;
        }

        public string getID()
        {
            return this.ID;
        }

        public string getDoB()
        {
            return this.DoB;
        }
    }
}
