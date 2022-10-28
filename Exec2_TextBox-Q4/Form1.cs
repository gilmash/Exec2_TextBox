using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                carResultLabel.Text = string.Empty;
                personResultLabel.Text = string.Empty;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {

            
            int countOfCar, countOfPeople;

            try
            {
                countOfCar = GetCar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                countOfPeople = GetPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            

            int caltcar = 200, caltperson = 60;

            int result = GetCarCal(countOfCar, caltcar);

            int result1 = GetPeopleCal(countOfPeople, caltperson);
            carResultLabel.Text = $"{result.ToString()}元";
            personResultLabel.Text = $"{result1.ToString()}元";
            



        }

        private int GetPeopleCal(int countOfPeople, int caltperson)
        {
            int result;

            result = countOfPeople * caltperson;
            return result;

        }

        private int GetCarCal(int countOfCar, int caltcar)
        {
            int result;

            result = countOfCar * caltcar;
            return result;

        }


        private int GetPeople()
        {
            string people = personTextBox.Text;
            bool iscar = int.TryParse(people, out int count);


            if (count <= 0)
            {
                throw new Exception("不得小於等於零");
            }
            return iscar ? count : throw new Exception("請輸入整數");
        }

        private int GetCar()
        {
            string car = carTextBox.Text;
            bool iscar = int.TryParse(car, out int count);


            if (count <= 0)
            {
                throw new Exception("不得小於等於零");
            }
            return iscar ? count : throw new Exception("請輸入整數");
        }

        private void carResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

