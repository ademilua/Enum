using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EnumerationLesson
{
    public class Pet
    {
        string Name { get; set; }
        int Age { get; set; }
        //public string Type { get; set; }
        PetType Type { get; set; }
        private StringBuilder _sb;
        //public Pet(string Name, int Age, string Type)
        public Pet(string Name, int Age, PetType Type)
        {
            this.Name = Name;
            this.Age = Age;
            this.Type = Type;
            _sb = new StringBuilder();


        }
        //Create an enum PetType and replace the string identifier for Type property to PetType.
        //However, an enum – by definition – allows you to restrict your set of options only to values that are relevant. 
        // Here is how you create an enum:
        public enum PetType
        {
            dog,
            snake,
            cat,
            tortoise,

        }

 
    }
}
