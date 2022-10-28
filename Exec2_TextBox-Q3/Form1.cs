using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            DateTime dt;
            try
            {
                dt = GetTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

                        
            string result = Getage(dt);

            MessageBox.Show(result);


        }

        private void Displayresult(int age)
        {

        }

        private string Getage(DateTime dt)
        {
            string result = string.Empty;
            int dateend = DateTime.Today.Year;
            int year = dt.Year;
            int age = dateend - year;
            if (age >= 13)
            {
                result = ("已滿13歲");
            }
            else
            {
                result = ("小於13歲");
            }
            return result;

        }


        private DateTime GetTime()
        {
            string value = enterBox.Text;
            bool isdatetime = DateTime.TryParse(value, out DateTime dt);
            return isdatetime ? dt : throw new Exception("請輸入日期");
        }

    }
}

