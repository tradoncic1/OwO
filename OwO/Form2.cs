using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwO
{
    public partial class Form2 : Form
    {
        Form1 ret;

        public Form2()
        {
            InitializeComponent();
        }

        //consturctor to allow communication between forms
        public Form2 (Form1 f)
        {
            InitializeComponent();
            ret = f;
        }

        //check which radio button is checked and act accordingly
        private void submit_Click(object sender, EventArgs e)
        {
            string arg = inputStr.Text;

            if (triggerBtn.Checked)
            {
                ret.addTrigger(arg);
                this.Close();
            }

            else if (emojiBtn.Checked)
            {
                ret.addKawaii(arg);
                this.Close();
            }

            else
                MessageBox.Show("You must select a type");
        }
    }
}
