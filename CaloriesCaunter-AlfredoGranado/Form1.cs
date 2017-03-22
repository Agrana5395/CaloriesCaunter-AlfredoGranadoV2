using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesCaunter_AlfredoGranado
{
    public partial class xCaloriesForm1 : Form
    {
        public xCaloriesForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            xGoodToGoLable4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void xExitButton3_Click(object sender, EventArgs e)
        {
            DialogResult response;

            response = MessageBox.Show("Are you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void xClearButton2_Click(object sender, EventArgs e)
        {
            xPortionsTextBox1.Clear();
            xCaloriesTextBox2.Clear();
            xTotalCaloriesTextBox3.Clear();
            xGoodToGoTextBox4.Clear();
            xDidYouNeedItTextBox5.Clear();
        }

        private void xPortionsTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaloriesTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void xCalculationButton1_Click(object sender, EventArgs e)
        {
            //STORAGE 
            string num1portionst = xPortionsTextBox1.Text;
            string num2caloriesst = xCaloriesTextBox2.Text;




            //INPUT 
            int num1portions = Convert.ToInt16(xPortionsTextBox1.Text);
            int num2calories = Convert.ToInt16(xCaloriesTextBox2.Text);





            //PROCESS
            int sumcal = num1portions * num2calories;
            int maxcall = 2000;
            int restcal = (maxcall - sumcal);

            //OUTPUT 
            xTotalCaloriesTextBox3.Text = sumcal.ToString();

            if (sumcal <= maxcall)
            {

                xGoodToGoTextBox4.Text = restcal.ToString();
                xGoodToGoTextBox4.Visible = true;
                xGoodToGoLable4.Visible = true;


                if (sumcal >= maxcall)
                    xGoodToGoTextBox4.Text = restcal.ToString("");




            }
            else
            {

                xDidYouNeedItTextBox5.Text = (sumcal - maxcall).ToString();

                xDidYouNeedItLable5.Visible = true;


            }




        }

        private void xGoodToGoTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void xDidYouNeedItTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void xDidYouNeedItLable5_Click(object sender, EventArgs e)
        {
            xDidYouNeedItLable5.Visible = false;
        }

        private void xPoundsTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void xPoundsButton4_Click(object sender, EventArgs e)
        {
            //STORAGE 
            string num1portionst = xPortionsTextBox1.Text;
            string num2caloriesst = xCaloriesTextBox2.Text;






            //INPUT 
            int num1portions = Convert.ToInt16(xPortionsTextBox1.Text);
            int num2calories = Convert.ToInt16(xCaloriesTextBox2.Text);



            //PROCESS
            int sumcal = num1portions * num2calories;
            int maxcall = 2000;
            int restcal = (maxcall - sumcal);

            //OUTPUT 
           if (sumcal >= maxcall)
           {
               xPoundsTextBox6.Text = Convert.ToString(xPortionsTextBox1);
               xPoundsTextBox6.Text = Convert.ToString(xCaloriesTextBox2);
               xPoundsTextBox6.Visible = true;
               Console.Write("you"); 
           }
            else
           {
               xPoundsTextBox6.Text = Convert.ToString("you are gaining wheight");
               xPoundsTextBox6.Visible = true;
           }


        }
    }
}