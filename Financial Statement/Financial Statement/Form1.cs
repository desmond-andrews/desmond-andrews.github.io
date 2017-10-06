using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void incomecurrencybox1_Click(object sender, EventArgs e)
        {
            incomecurrencybox1.Clear();
        }

        private void incomecurrencybox2_Click(object sender, EventArgs e)
        {
            incomecurrencybox2.Clear();
        }

        private void incomecurrencybox3_Click(object sender, EventArgs e)
        {
            incomecurrencybox3.Clear();
        }

        private void incomecurrencybox4_Click(object sender, EventArgs e)
        {
            incomecurrencybox4.Clear();
        }

        private void incomecurrencybox5_Click(object sender, EventArgs e)
        {
            incomecurrencybox5.Clear();
        }

        private void expensescurrencybox1_Click(object sender, EventArgs e)
        {
            expensescurrencybox1.Clear();
        }

        private void expensescurrencybox2_Click(object sender, EventArgs e)
        {
            expensescurrencybox2.Clear();
        }

        private void expensescurrencybox3_Click(object sender, EventArgs e)
        {
            expensescurrencybox3.Clear();
        }

        private void expensescurrencybox4_Click(object sender, EventArgs e)
        {
            expensescurrencybox4.Clear();
        }

        private void expensescurrencybox5_Click(object sender, EventArgs e)
        {
            expensescurrencybox5.Clear();
        }

        private void expensescurrencybox6_Click(object sender, EventArgs e)
        {
            expensescurrencybox6.Clear();
        }

        private void expensescurrencybox7_Click(object sender, EventArgs e)
        {
            expensescurrencybox7.Clear();
        }

        private void expensescurrencybox8_Click(object sender, EventArgs e)
        {
            expensescurrencybox8.Clear();
        }

        private void incomecurrencybox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomecurrencybox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                incomecurrencybox1.Text = incomecurrencybox1.Text.Remove(incomecurrencybox1.Text.Length - 1);
            }
        }

        private void incomecurrencybox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomecurrencybox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                incomecurrencybox2.Text = incomecurrencybox2.Text.Remove(incomecurrencybox2.Text.Length - 1);
            }
        }

        private void incomecurrencybox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomecurrencybox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                incomecurrencybox3.Text = incomecurrencybox3.Text.Remove(incomecurrencybox3.Text.Length - 1);
            }
        }

        private void incomecurrencybox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomecurrencybox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                incomecurrencybox4.Text = incomecurrencybox4.Text.Remove(incomecurrencybox4.Text.Length - 1);
            }
        }

        private void incomecurrencybox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomecurrencybox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                incomecurrencybox5.Text = incomecurrencybox5.Text.Remove(incomecurrencybox5.Text.Length - 1);
            }
        }

        private void expensescurrencybox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox1.Text = expensescurrencybox1.Text.Remove(expensescurrencybox1.Text.Length - 1);
            }
        }

        private void expensescurrencybox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox2.Text = expensescurrencybox2.Text.Remove(expensescurrencybox2.Text.Length - 1);
            }
        }

        private void expensescurrencybox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox3.Text = expensescurrencybox3.Text.Remove(expensescurrencybox3.Text.Length - 1);
            }
        }

        private void expensescurrencybox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox4.Text = expensescurrencybox4.Text.Remove(expensescurrencybox4.Text.Length - 1);
            }
        }

        private void expensescurrencybox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox5.Text = expensescurrencybox5.Text.Remove(expensescurrencybox5.Text.Length - 1);
            }
        }

        private void expensescurrencybox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox6.Text = expensescurrencybox6.Text.Remove(expensescurrencybox6.Text.Length - 1);
            }
        }

        private void expensescurrencybox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox7.Text = expensescurrencybox7.Text.Remove(expensescurrencybox7.Text.Length - 1);
            }
        }

        private void expensescurrencybox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(expensescurrencybox8.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                expensescurrencybox8.Text = expensescurrencybox8.Text.Remove(expensescurrencybox8.Text.Length - 1);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (incomecurrencybox1.Text == "")
            { incomecurrencybox1.Text = "0"; }

            if (incomecurrencybox2.Text == "")
            { incomecurrencybox2.Text = "0"; }

            if (incomecurrencybox3.Text == "")
            { incomecurrencybox3.Text = "0"; }

            if (incomecurrencybox4.Text == "")
            { incomecurrencybox4.Text = "0"; }

            if (incomecurrencybox5.Text == "")
            { incomecurrencybox5.Text = "0"; }


            if (expensescurrencybox1.Text == "")
            { expensescurrencybox1.Text = "0"; }

            if (expensescurrencybox2.Text == "")
            { expensescurrencybox2.Text = "0"; }

            if (expensescurrencybox3.Text == "")
            { expensescurrencybox3.Text = "0"; }

            if (expensescurrencybox4.Text == "")
            { expensescurrencybox4.Text = "0"; }

            if (expensescurrencybox5.Text == "")
            { expensescurrencybox5.Text = "0"; }

            if (expensescurrencybox6.Text == "")
            { expensescurrencybox6.Text = "0"; }

            if (expensescurrencybox7.Text == "")
            { expensescurrencybox7.Text = "0"; }

            if (expensescurrencybox8.Text == "")
            { expensescurrencybox8.Text = "0"; }

            decimal icurrencyconvert1 = Convert.ToInt32(incomecurrencybox1.Text);
            decimal icurrencyconvert2 = Convert.ToInt32(incomecurrencybox2.Text);
            decimal icurrencyconvert3 = Convert.ToInt32(incomecurrencybox3.Text);
            decimal icurrencyconvert4 = Convert.ToInt32(incomecurrencybox4.Text);
            decimal icurrencyconvert5 = Convert.ToInt32(incomecurrencybox5.Text);

            decimal icurrencyparse1 = decimal.Parse(incomecurrencybox1.Text);
            decimal icurrencyparse2 = decimal.Parse(incomecurrencybox2.Text);
            decimal icurrencyparse3 = decimal.Parse(incomecurrencybox3.Text);
            decimal icurrencyparse4 = decimal.Parse(incomecurrencybox4.Text);
            decimal icurrencyparse5 = decimal.Parse(incomecurrencybox5.Text);

            decimal totaliCurrency = icurrencyparse1 + icurrencyparse2 + icurrencyparse3 + icurrencyparse4
             + icurrencyparse5;

            totalincomebox.Text = totaliCurrency.ToString("C");


            decimal ecurrencyconvert1 = Convert.ToInt32(expensescurrencybox1.Text);
            decimal ecurrencyconvert2 = Convert.ToInt32(expensescurrencybox2.Text);
            decimal ecurrencyconvert3 = Convert.ToInt32(expensescurrencybox3.Text);
            decimal ecurrencyconvert4 = Convert.ToInt32(expensescurrencybox4.Text);
            decimal ecurrencyconvert5 = Convert.ToInt32(expensescurrencybox5.Text);
            decimal ecurrencyconvert6 = Convert.ToInt32(expensescurrencybox6.Text);
            decimal ecurrencyconvert7 = Convert.ToInt32(expensescurrencybox7.Text);
            decimal ecurrencyconvert8 = Convert.ToInt32(expensescurrencybox8.Text);

            decimal ecurrencyparse1 = decimal.Parse(expensescurrencybox1.Text);
            decimal ecurrencyparse2 = decimal.Parse(expensescurrencybox2.Text);
            decimal ecurrencyparse3 = decimal.Parse(expensescurrencybox3.Text);
            decimal ecurrencyparse4 = decimal.Parse(expensescurrencybox4.Text);
            decimal ecurrencyparse5 = decimal.Parse(expensescurrencybox5.Text);
            decimal ecurrencyparse6 = decimal.Parse(expensescurrencybox6.Text);
            decimal ecurrencyparse7 = decimal.Parse(expensescurrencybox7.Text);
            decimal ecurrencyparse8 = decimal.Parse(expensescurrencybox8.Text);

            decimal totaleCurrency = ecurrencyparse1 + ecurrencyparse2 + ecurrencyparse3 + ecurrencyparse4
             + ecurrencyparse5 + ecurrencyparse6 + ecurrencyparse7 + ecurrencyparse8;

            totalexpensesbox.Text = totaleCurrency.ToString("C");


            decimal totalPayday = totaliCurrency - totaleCurrency;

            paydaybox.Text = totalPayday.ToString("C");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
