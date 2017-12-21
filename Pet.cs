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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LocalDbsample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SkypletEntities db = new SkypletEntities();
            var customers = db.Customers;
            
            //string result = "";
            //foreach (var customer in customers)
            // {
            // result += string.Format("{0} | {1} | {2}", customer.Name, customer.CustomerId, customer.Address);
            // }
            customerGridView.DataSource = customers.ToList(); // Using Gridview to get data from database
            customerGridView.DataBind();// Populate out data
        
            //resultLabel.Text = result;
        }

        protected void customerGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = customerGridView.Rows[index];
            var view = row.Cells[0].Text;
            var CustomerIdValue = row.Cells[1].Text;
            var Name = row.Cells[2].Text;
            var Address = row.Cells[3].Text;
            var City = row.Cells[4].Text;
            var Note = row.Cells[7].Text;
            var CustomerId = Guid.Parse(CustomerIdValue);
            resultLabel.Text = string.Format("{0} | {1} | {2} | {3} | {4}", CustomerId, Name, Address, City, Note);


        }
    }
}
 
    }
}
