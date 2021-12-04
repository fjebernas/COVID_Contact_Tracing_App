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

        private void ContactTracer_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelFocusGetter;
        }

        private void ContactTracer_Click(object sender, EventArgs e)
        {
            this.ActiveControl = labelFocusGetter;
        }
        

        string[] data = new string[6];

        string gender = "";

        string quesOneAns = "";
        string quesTwoAns = "";
        string quesThreeAns = "";

        string placeholder = "(Required field)";


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            data[0] = txtBxFN.Text;
            data[1] = txtBxMN.Text;
            data[2] = txtBxLN.Text;
            data[3] = txtBxAge.Text;
            data[4] = txtBxPN.Text;
            data[5] = txtBxAddress.Text;

            if (!data.Contains(placeholder))
            {
                GetGender(rdoBtnMale);
                GetGender(rdoBtnFemale);
                GetGender(rdoBtnIPNTS);

                GetQuesOneAns(rdoBtnQuesOneYes);
                GetQuesOneAns(rdoBtnQuesOneNo);
                GetQuesOneAns(rdoBtnQuesOneNS);

                GetQuesTwoAns(rdoBtnQuesTwoYes);
                GetQuesTwoAns(rdoBtnQuesTwoNo);
                GetQuesTwoAns(rdoBtnQuesTwoNS);

                GetQuesThreeAns(chkBxQuesOneCough);
                GetQuesThreeAns(chkBxQuesOneFever);
                GetQuesThreeAns(chkBxQuesOneBD);


                StreamWriter dataTxt;
                dataTxt = File.CreateText(@"C:\Users\franc\source\repos\Assign#6ContactTracer\ContactTracingApp\ContactTracingApp\Properties\Contact-Tracing-Records\"
                                            + data[2] + "," + data[0] + " " + data[1] + ".txt");

                dataTxt.WriteLine("First name: " + data[0] + "\n" +
                                  "Middle name: " + data[1] + "\n" +
                                  "Last name: " + data[2] + "\n" +
                                  "Age: " + data[3] + "\n" +
                                  "Phone number: " + data[4] + "\n" +
                                  "Address: " + data[5] + "\n" +
                                  "Gender: " + gender + "\n\n" +
                                  "USER'S ANSWERS:" + "\n\n" +
                                  "1. Have you traveled outside the country anytime from last month until now?\n" +
                                  quesOneAns + "\n" +
                                  "2. Have you come into contact with anyone who has traveled outside your country between the period of last month until now?\n" +
                                  quesTwoAns + "\n" +
                                  "3. Do you currently have any of the following conditions during this time?\n" +
                                  quesThreeAns + "\n"
                                  );
                dataTxt.Close();

                MessageBox.Show("Submitted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ResetAllControls(this);
                
            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetGender(RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                gender = radioButton.Text;
            }
            return gender;
        }

        private string GetQuesOneAns(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                quesOneAns = radiobutton.Text;
            }
            return quesOneAns;
        }

        private string GetQuesTwoAns(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                quesTwoAns = radiobutton.Text;
            }
            return quesTwoAns;
        }

        private string GetQuesThreeAns(CheckBox checkbox)
        {
            if (checkbox.Checked)
            {
                quesThreeAns = quesThreeAns + checkbox.Text + "\n";
            }
            return quesThreeAns;
        }

        private void txtBoxChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ReqField_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == placeholder)
            {
                textbox.Text = "";
            }
            textbox.ForeColor = Color.Black;
        }

        private void ReqField_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == "")
            {
                textbox.Text = placeholder;
                textbox.ForeColor = Color.DarkGray;
            }
        }

        
        private void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.DarkGray;
                }

                /*if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.
                }*/

                rdoBtnMale.Checked = false;
                rdoBtnFemale.Checked = false;
                rdoBtnIPNTS.Checked = false;

                rdoBtnQuesOneYes.Checked = false;
                rdoBtnQuesOneNo.Checked = false;
                rdoBtnQuesOneNS.Checked = false;

                rdoBtnQuesTwoYes.Checked = false;
                rdoBtnQuesTwoNo.Checked = false;
                rdoBtnQuesTwoNS.Checked = false;

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }
    }
}
