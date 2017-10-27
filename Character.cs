using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseNestedEnumInClass
{
    public class Character
    {
        public enum CharacterType
        {
            Witch,
            Monster,
            Wizard,
            Fighter,
        }
        public string Name { get; set; }
        public CharacterType Type { get; set; }
    }
}