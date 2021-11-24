using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingApp
{
    public partial class ContactTracer : Form
    {
        public ContactTracer()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[6];
            data[0] = txtBxFN.Text;
            data[1] = txtBxMN.Text;
            data[2] = txtBxLN.Text;
            data[3] = txtBxAge.Text;
            data[4] = txtBxPN.Text;
            data[5] = txtBxAddress.Text;

            StreamWriter dataTxt;
            dataTxt = File.CreateText(@"C:\Users\franc\source\repos\Assign#6ContactTracer\ContactTracingApp\ContactTracingApp\Properties\CTAData.txt");
            dataTxt.WriteLine("First name: " + data[0] + "\n" +
                              "Middle name: " + data[1] + "\n" +
                              "Last name: " + data[2] + "\n" +
                              "Age: " + data[3] + "\n" +
                              "Phone number: " + data[4] + "\n" +
                              "Address: " + data[5]
                              );
            dataTxt.Close();

            MessageBox.Show("Submitted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
