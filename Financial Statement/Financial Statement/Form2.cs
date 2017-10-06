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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatebutton2_Click(object sender, EventArgs e)
        {
            this.Close();
            overall frm3 = new overall();
            frm3.Show();
        }
    }
}
