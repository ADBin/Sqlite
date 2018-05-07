using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Form_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //init();
            procTimer_start();
        }
        SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

        private void toolStripNew_Click(object sender, EventArgs e)  //新建一条信息
        {
            toolStripLabelStatus.Text = "";
            //检查id是否有重复
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Students where id = @id";
            command.Parameters.Add(new SQLiteParameter("@id", int.Parse(textId.Text)));
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Console.WriteLine(dt.Rows.Count.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textId.Text == dt.Rows[i]["id"].ToString())
                {
                    MessageBox.Show("学号有重复！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            int sex = textSex.Text == "男" ? 1 : 0;
            //SQLiteCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "INSERT into Students (id, name, age, sex, born, address, phone) VALUES(@id, @name, @age, @sex, @born, @address, @phone)";
                command.Parameters.Add(new SQLiteParameter("@id", int.Parse(textId.Text)));
                command.Parameters.Add(new SQLiteParameter("@name", textName.Text));
                command.Parameters.Add(new SQLiteParameter("@age", int.Parse(textAge.Text)));
                command.Parameters.Add(new SQLiteParameter("@sex", sex));
                command.Parameters.Add(new SQLiteParameter("@born", int.Parse(textBorn.Text)));
                command.Parameters.Add(new SQLiteParameter("@address", textAddress.Text));
                command.Parameters.Add(new SQLiteParameter("@phone", int.Parse(textPhone.Text)));
                command.ExecuteNonQuery();
                MessageBox.Show("添加成功！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("输入数据有误，请检查", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            command.Dispose();
            show_all();
        }

        private void toolStripDel_Click(object sender, EventArgs e) //删除一条信息
        {
            toolStripLabelStatus.Text = "";
            DialogResult TS = MessageBox.Show("是否删除？？", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (TS == DialogResult.No) return;
            SQLiteCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "DELETE FROM Students where id = @id";

                command.Parameters.AddWithValue("@id", int.Parse(textId.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("删除成功！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                show_all();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("错误，删除失败！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            command.Dispose();
        }

        private void toolStripChange_Click(object sender, EventArgs e)  //修改一条信息
        {
            toolStripLabelStatus.Text = "";
            int sex = textSex.Text == "男" ? 1 : 0;
            SQLiteCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "UPDATE Students set name=@name, age=@age, sex=@sex, born=@born, address=@address, phone=@phone WHERE id = @id";
                command.Parameters.Add(new SQLiteParameter("@id", int.Parse(textId.Text)));
                command.Parameters.Add(new SQLiteParameter("@name", textName.Text));
                command.Parameters.Add(new SQLiteParameter("@age", int.Parse(textAge.Text)));
                command.Parameters.Add(new SQLiteParameter("@sex", sex));
                command.Parameters.Add(new SQLiteParameter("@born", int.Parse(textBorn.Text)));
                command.Parameters.Add(new SQLiteParameter("@address", textAddress.Text));
                command.Parameters.Add(new SQLiteParameter("@phone", int.Parse(textPhone.Text)));
                command.ExecuteNonQuery();

                MessageBox.Show("修改成功！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("输入数据有误，请检查", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            command.Dispose();
            show_all();
        }

        private void toolStripSearchId_Click(object sender, EventArgs e)  //搜索一条信息
        {
            toolStripLabelStatus.Text = "";
            SQLiteCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Students where id = @id";
                command.Parameters.Add(new SQLiteParameter("@id", int.Parse(toolStripTextId.Text)));
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("输入id有误，请检查", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            
            //Console.WriteLine(dt);
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textId.Text = dt.Rows[0]["id"].ToString();
                textName.Text = dt.Rows[0]["name"].ToString();
                textAge.Text = dt.Rows[0]["age"].ToString();
                textSex.Text = dt.Rows[0]["sex"].ToString() == "True" ? "男" : "女";
                textBorn.Text = dt.Rows[0]["born"].ToString();
                textAddress.Text = dt.Rows[0]["address"].ToString();
                textPhone.Text = dt.Rows[0]["phone"].ToString();
                toolStripLabelStatus.Text = "查询成功";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                toolStripLabelStatus.Text = "没有该id";
            }
            //
            command.Dispose();
        }

        //private void init()
        //{
        //    connect();
        //}
        Timer procTimer = new Timer();
        
        private void procTimer_start()//3秒后自动连接数据库，3秒内可以重置数据库
        {
            toolStripLabelStatus.Text = "3秒后连接数据库";
            procTimer.Interval = 3000;
            procTimer.Tick += new EventHandler(procTimer_stop);
            //buttonClean.Hide();
            procTimer.Start();
        }

        private void procTimer_stop(object sender, EventArgs e)
        {
            buttonClean.Hide();    //隐藏重置按键
            procTimer.Stop();      //关闭定时器
            connect();             //连接数据库
        }

        private void buttonClean_Click(object sender, EventArgs e)  //重置数据库并创建表
        {
            buttonClean.Hide();    //隐藏重置按键
            procTimer.Stop();      //关闭定时器

            SQLiteConnection.CreateFile("Database.sqlite");
            //这是数据库登录密码
            conn.SetPassword("1234");
            conn.Open();
            string query = "create table Students (id INTEGER, name VARCHAR, age INT, sex BIT, born INT, address VARCHAR, phone INT)";
            //创建命令
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            //执行命令
            cmd.ExecuteNonQuery();
            toolStripLabelStatus.Text = "重置并连接完成";
            show_all();
        }

        private void show_all()
        {
            string query = "select * from Students";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void connect()
        {
            conn.SetPassword("1234");
            //打开数据库
            conn.Open();
            toolStripLabelStatus.Text = "数据库连接完成";
            show_all();
        }


        //private void buttonConnect_Click(object sender, EventArgs e) //数据连接
        //{       
        //    conn.SetPassword("1234");
        //打开数据库
        //    conn.Open();
        //}
    }
}
