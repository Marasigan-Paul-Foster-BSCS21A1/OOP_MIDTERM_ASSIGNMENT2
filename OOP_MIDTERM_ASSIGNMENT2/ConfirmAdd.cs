using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOlistapplication
{
    public partial class ConfirmAdd : Form
    {
        public ConfirmAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Form1.i;
            Class1.MarkTaskAsDone(i);
            this.Close();
        }
    }

}
