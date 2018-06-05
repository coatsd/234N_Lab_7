using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class Form1 : Form
    {

        // FOR MARI
        // My statements are under region tags named "My Work". There you can see my data fetching statements.

        public Form1()
        {
            InitializeComponent();
        }

        private void fillComboButton_Click(object sender, EventArgs e)
        {
            // *** Use both syntax to get a list of state objects sorted by statename
            //List<State> states = MMABooksEntity.mmaBooks.States.OrderBy(s => s.StateName).ToList();
            //List<State> states = (from state in MMABooksEntity.mmaBooks.States orderby state.StateCode select state).ToList();
            // *** bind the list to a combo box
            //comboBox1.DataSource = states;
            //comboBox1.DisplayMember = "StateName";
            //comboBox1.ValueMember = "StateCode";

            // *** Use lambda expression syntax to get sorted list of customers
            //List<Customer> customers = MMABooksEntity.mmaBooks.Customers.OrderBy(c => c.Name).ToList();
            // *** Use both syntax filter by state
            //List<Customer> customers = MMABooksEntity.mmaBooks.Customers.Where(c => c.State == "NY").OrderBy(c => c.Name).ToList();
            //List<Customer> customers = (from c in MMABooksEntity.mmaBooks.Customers orderby c.Name select c).ToList();
            // *** create an "implicitly typed" list that contains just the customer id and name
            //var customers = (from c in MMABooksEntity.mmaBooks.Customers orderby c.Name select new { c.CustomerID, c.Name }).ToList();
            //comboBox1.DataSource = customers;
            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "CustomerID";

            #region My Work

            // *** MY WORK ***
            // *** Can you use both syntax to
            //Get a list of products sorted by product name
            //List<Product> products = MMABooksEntity.mmaBooks.Products.OrderBy(p => p.Description).ToList();
            //comboBox1.DataSource = products;
            //comboBox1.DisplayMember = "Description";
            //comboBox1.ValueMember = "ProductCode";

            //Get a list of products with a unit price of 56.50 sorted by product name
            //List<Product> products = MMABooksEntity.mmaBooks.Products.Where(p => p.UnitPrice == 56.50m).OrderBy(p => p.Description).ToList();
            //comboBox1.DataSource = products;
            //comboBox1.DisplayMember = "Description";

            #endregion My Work
        }

        private void fillGridButton_Click(object sender, EventArgs e)
        {
            // *** Use both syntax to return implicitly typed list
            //var customers = (from c in MMABooksEntity.mmaBooks.Customers orderby c.Name select new { c.CustomerID, c.Name }).ToList();
            //var customers = MMABooksEntity.mmaBooks.Customers.Where(c => c.State == "NY").OrderBy(c => c.Name).Select(c => new { c.CustomerID, c.Name }).ToList();
            // *** Use both syntax to combine customer and state information
            //var customers = (from c in MMABooksEntity.mmaBooks.Customers 
            //                 join s in MMABooksEntity.mmaBooks.States
            //                 on c.State equals s.StateCode
            //                 orderby c.Name select new { c.CustomerID, c.Name, c.State, s.StateName }).ToList();
            //var customers = MMABooksEntity.mmaBooks.Customers.Join(
            //    MMABooksEntity.mmaBooks.States,
            //    c => c.State,
            //    s => s.StateCode,
            //    (c, s) => new { c.CustomerID, c.Name, c.State, s.StateName }).OrderBy(r => r.StateName).ToList();

            //dataGridView1.DataSource = customers;

            #region My Work

            //*** MY WORK ***
            // *** Can you use both syntax to
            // Get a list of Invoices
            //var invoices = (from i in MMABooksEntity.mmaBooks.Invoices 
            //                orderby i.InvoiceID select new { i.InvoiceID, i.InvoiceTotal }).ToList();
            //dataGridView1.DataSource = invoices;

            // Add the customer name to the invoices
            //var invoices = (from i in MMABooksEntity.mmaBooks.Invoices
            //                join c in MMABooksEntity.mmaBooks.Customers
            //                on i.CustomerID equals c.CustomerID
            //                orderby c.Name
            //                select new { c.Name, i.InvoiceID, i.InvoiceDate, i.InvoiceTotal }).ToList();
            //dataGridView1.DataSource = invoices;

            // MIGHT NEED WORK
            // Get a list of items ordered on each invoice
            //var items = (from i in MMABooksEntity.mmaBooks.Invoices
            //             join n in MMABooksEntity.mmaBooks.InvoiceLineItems
            //             on i.InvoiceID equals n.InvoiceID
            //             orderby i.InvoiceID
            //             select new { i.InvoiceID, n.ProductCode, i.InvoiceDate }).ToList();
            //dataGridView1.DataSource = items;

            // Add the product name to the list of items
            //var items = (from i in MMABooksEntity.mmaBooks.Invoices
            //             join n in MMABooksEntity.mmaBooks.InvoiceLineItems
            //             on i.InvoiceID equals n.InvoiceID
            //             join p in MMABooksEntity.mmaBooks.Products
            //             on n.ProductCode equals p.ProductCode
            //             orderby i.InvoiceID
            //             select new { i.InvoiceID, p.Description, i.InvoiceDate }).ToList();
            //dataGridView1.DataSource = items;

            #endregion My Work
        }
    }
}
