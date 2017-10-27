using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciseNestedEnumInClass
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var hero = new Character();
            hero.Name = "Tanko";
            hero.Type = Character.CharacterType.Fighter;
            if (hero.Type == Character.CharacterType.Fighter)
            {
                resultLabel.Text = "This hero is a Fighter!";
            }
        }
    }
}