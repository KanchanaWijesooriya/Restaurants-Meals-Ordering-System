using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_course_work
{
    public partial class SelectMethod : Form
    {
        public SelectMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodItems fi = new FoodItems();
            fi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoodItems fi = new FoodItems();
            fi.Show();
            this.Hide();
        }

        private void SelectMethod_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
