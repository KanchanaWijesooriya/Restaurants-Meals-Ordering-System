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
    
    public partial class Form1 : Form
    {
        OneForAll ofa;
        security s;
        public Form1()
        {
            InitializeComponent();
            ofa = new OneForAll();
            s = new security();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectMethod sm = new SelectMethod();
            sm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            s.searchData(1);
            if(s.Username == Convert.ToString(textBox1.Text) && s.Password == Convert.ToString(textBox2.Text)) {
                Admin a = new Admin();
                a.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usename or password is incorrect please re-enter");
                textBox1.Clear();
                textBox2.Clear();
            }

            /*Admin a = new Admin();
            a.Show();
            this.Hide();*/

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
