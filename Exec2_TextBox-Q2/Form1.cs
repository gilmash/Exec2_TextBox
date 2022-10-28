using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkButton_Click(object sender, EventArgs e)
        {
            //讀取日期
            
            DateTime dt;


            //判斷正確與否
            try
            {
                dt = GetDate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //輸出結果
            if (dt > DateTime.Now)
            {
                MessageBox.Show("大於今天日期");
            }
            else
            {
                MessageBox.Show("小於今天日期");
            }

        }

        private DateTime GetDate()
        {
            
            string value = enterTextBox.Text;
            bool isdatetime = DateTime.TryParse(value, out DateTime dt);


            if (isdatetime == false)
            {
                throw new Exception("給我輸入日期啦");
            }

            return dt;
        }    
    }
}
