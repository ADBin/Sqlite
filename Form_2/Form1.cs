using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                this.Visible = false;
                Form2 f2 = new Form2();
                //显示Form2
                f2.ShowDialog();
                //显示当前窗口 
                this.Close();
                //this.Visible = true;
            }
            else
            {
                MessageBox.Show("密码用户名错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
