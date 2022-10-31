using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetHomeWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        List<Employee> employers = new List<Employee>();
        int index;
        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Id = Convert.ToInt32(txtId.Text);
            cust.FirstName = txtName.Text;
            cust.LastName = txtLastName.Text;
            cust.PhoneNumber = txtPhone.Text;
            cust.Address = txtAddress.Text;

            customers.Add(cust);
            clearTxtBox();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Employee emply = new Employee();
            emply.Id = Convert.ToInt32(txtId.Text);
            emply.FirstName = txtName.Text;
            emply.LastName = txtLastName.Text;
            emply.PhoneNumber = txtPhone.Text;
            emply.Address = txtAddress.Text;
            employers.Add(emply);
            clearTxtBox();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in employers) { 

                if(comboBox2.Items.Contains(x.Id)!=true)
                    comboBox2.Items.Add(x.Id);
            }
                
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in customers) { 
                
                if(comboBox1.Items.Contains(x.Id)!=true)
                    comboBox1.Items.Add(x.Id);
            
            }
                
                

        }



        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String seelect_item = Convert.ToString(listBox1.SelectedItem);
            System.Diagnostics.Debug.WriteLine(seelect_item);
            listBox1.Items.Remove(listBox1.SelectedItem);
            
            
            for (int i = 0; i < customers.Count; i++) {
                if (customers[i].Id== index)
                {
                    customers.Remove(customers[i]);
                }


            }
            comboBox1.Items.Remove(index);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            emptylistbox();
            index = Convert.ToInt32(comboBox1.SelectedItem);
            foreach (IPerson x in customers)
            {

               
                if (x.Id == index)
                {
                    listBox1.Items.Add(x.FirstName + " " + x.LastName);
                }

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            emptylistbox();
            index = Convert.ToInt32(comboBox2.SelectedItem);
            foreach (IPerson x in employers)
            {

               
                if (x.Id == index)
                {
                    listBox1.Items.Add(x.FirstName + " " + x.LastName);
                }
                
            }
            


        }
        private void emptylistbox()
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String seelect_item = Convert.ToString(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            for (int i = 0; i < employers.Count; i++)
            {
                if (employers[i].Id == index)
                {
                    employers.Remove(employers[i]);
                }


            }
            comboBox2.Items.Remove(index);

        }
    }
}
