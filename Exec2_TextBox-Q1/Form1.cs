using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkButton_Click(object sender, EventArgs e)
        {

            int number;
                
            try
            {
                number = GetNumber();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{number}在1~99之間");


        }

        private int GetNumber()
        {
            
            string input = enterTextBox.Text;
            bool isInt = int.TryParse(input, out int numbers);

            if (isInt == false)
            {
                throw new Exception("請輸入整數");
            }
            if (numbers < 0 || numbers > 99)
            {
                throw new Exception("只能輸入1~99的整數");
            }
            return numbers;
        }

    }
   
}
