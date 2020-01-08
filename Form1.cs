using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Linq_Xml
{
    public partial class Form1 : Form
    {
        private List<Customer> customerList;
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadFromXML()
        {
            try
            {
                customerList = (from e in XDocument.Load("Customers.xml").Root.Elements("customer")
                                select new Customer
                                {
                                    CustomerID = (string)e.Element("id"),
                                    CompanyName = (string)e.Element("name"),
                                    Address = (string)e.Element("address"),
                                    City = (string)e.Element("city"),
                                    Region = (string)e.Element("region"),
                                    PostalCode = (string)e.Element("postalcode"),
                                    Country = (string)e.Element("country"),
                                    Phone = (string)e.Element("phone"),
                                    Fax = (string)e.Element("fax"),
                                    Orders = (
                                            from o in e.Elements("orders").Elements("order")
                                            select new Order
                                            {
                                                OrderId = (int)o.Element("id"),
                                                OrderDate = (DateTime)o.Element("orderdate"),
                                                Total = (decimal)o.Element("total")
                                            })
                                    .ToArray()



                                }).ToList();
                dgvXML.DataSource = customerList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromXML();
        }
    }
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

    }
}
