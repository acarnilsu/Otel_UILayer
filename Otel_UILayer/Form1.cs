using DataAccessLayer.ProjectContext;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_UILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context c = new Context();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = c.Customers.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerSurname= txtCustomerSurname.Text;
            customer.CustomerGender = cmbGender.Text;
            customer.CustomerPhone=txtCustomerPhone.Text;
            c.Customers.Add(customer);
            c.SaveChanges();
            MessageBox.Show("Eklendi");
        }
    }
}
